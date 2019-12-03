using System;

namespace Advent_of_Code_2019 {
   
    public class AOC2019_Day2 {
        public int computeOutput (int[] inputIntcode) {
            for (int i = 0; i < inputIntcode.Length; i += 4) {
                switch (inputIntcode[i]) {
                    case 1:
                        inputIntcode[inputIntcode[i+3]] = inputIntcode[inputIntcode[i+1]] + inputIntcode[inputIntcode[i+2]];
                        //Console.WriteLine(" Addition");
                        break;
                    case 2:
                        inputIntcode[inputIntcode[i+3]] = inputIntcode[inputIntcode[i+1]] * inputIntcode[inputIntcode[i+2]];
                        //Console.WriteLine(" Multiplication");
                        break;
                    case 99:
                        return inputIntcode[0];
                    default:
                        Console.WriteLine($"Error opcode  { inputIntcode[i] } does not exist.");
                        break;
                }
            }
            return -1;
        }

        public string findNounAndVerb(int[] inputIntcode) {
            int[] resetIntcode = new int[inputIntcode.Length];
            Array.Copy(inputIntcode, resetIntcode, inputIntcode.Length);
            for (int i = 0; i <= 99; i++) {
                for (int j = 0; j <= 99; j++) {
                    inputIntcode[1] = i;
                    inputIntcode[2] = j;
                    if (computeOutput(inputIntcode) == 19690720) {
                        return $"Error Code: {inputIntcode[1]}{inputIntcode[2]}";
                    }
                    Array.Copy(resetIntcode, inputIntcode, resetIntcode.Length);
                }
            }
            return "Error Code Not Found";
        }
    }
}