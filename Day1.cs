using System;

namespace Advent_of_Code_2019 {
   
    public class AOC2019_Day1 {
        public int calculateFuelFromMass(int partMass) {
            int partFuel = 0;
            partFuel = (partMass / 3) - 2;
            return partFuel;
        }
        
        public int calculateTotalFuel(int[] parts) {
            int totalFuel = 0;
            for (int i = 0; i < parts.Length; i++) {
                totalFuel += calculateFuelFromAddedMassOfFuel(parts[i]);
            }
            return totalFuel;
        }
        
        public int calculateFuelFromAddedMassOfFuel(int partFuel) {
            int extraFuel = calculateFuelFromMass(partFuel);
            int totalExtraFuel = 0;
            if (extraFuel <= 0) {
                return 0;
            }
            do {
                totalExtraFuel += extraFuel;
                extraFuel = calculateFuelFromMass(extraFuel);
            } while (extraFuel > 0);
            return totalExtraFuel;
        }   
    }
}