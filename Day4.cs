using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Advent_of_Code_2019 {
   
    public class AOC2019_Day4 {
        public bool passwordTester(string password) {
            bool[] hasDouble = new bool[6];
            char lastChar = password[0];
            char twoPrev = ' ';
            if (password.Length != 6) {
                return false;
            }
            for (int i = 1; i < password.Length; i++) {
                if (password[i] < lastChar) {
                    return false;
                }
                if (password[i] == lastChar && password[i] != twoPrev) {
                    hasDouble[i-1] = true;
                }
                if (password[i] == lastChar && password[i] == twoPrev) {
                    hasDouble[i-2] = false;
                }
                twoPrev = lastChar;
                lastChar = password[i];
            }
            return hasDouble.Any(x => x == true);
        }
        
        public List<int> passwordRange(int rangeStart, int rangeEnd) {
            List<int> passwords = new List<int>();
            for (int i = rangeStart; i <= rangeEnd; i++) {
                if (passwordTester(i.ToString())) {
                    passwords.Add(i);
                }
            }
            return passwords;
        }

        public int findNumPasswords(int rangeStart, int rangeEnd) {
            return (passwordRange(rangeStart, rangeEnd).Count);
        }
    }

}