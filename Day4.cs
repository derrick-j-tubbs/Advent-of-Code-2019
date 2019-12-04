using System;
using System.Collections.Generic;
using System.Drawing;

namespace Advent_of_Code_2019 {
   
    public class AOC2019_Day4 {
        public bool passwordTester(string password) {
            bool hasDouble = false;
            bool decreases = false;
            char lastChar = ' ';
            if (password.Length != 6) {
                return false;
            }
            foreach (char currentChar in password) {
                if (lastChar != ' ') {
                    if (currentChar == lastChar) {
                        //Console.WriteLine("has double");
                        hasDouble = true;
                    }
                    
                    if (currentChar < lastChar) {
                        decreases = true;
                        //Console.WriteLine("decreases");
                    }
                }
                lastChar = currentChar;
            }
            return hasDouble && !decreases;
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