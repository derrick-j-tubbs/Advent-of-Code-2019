using System;


namespace Advent_of_Code_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Inputs inputs = new Inputs();
            //day 1

/*          var day1 = new AOC2019_Day1();

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var totalFuel = day1.calculateTotalFuel(inputs.partList);
                Console.WriteLine(totalFuel);
            stopwatch.Stop();
            Console.WriteLine($"Day 1 Execution time: { stopwatch.ElapsedMilliseconds } ms");
            //Console.WriteLine(day1.calculatePartFuel(14));
            //Console.WriteLine(day1.calculateFuelFromMass(14));
 
            //day 2
            int[] sample = {1,1,1,4,99,5,6,0,99};

            var day2 = new AOC2019_Day2();
            //Console.WriteLine(day2.intcode(sample));
            //Console.WriteLine(day2.computeOutput(intcode));
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(day2.findNounAndVerb(inputs.intcode));
            stopwatch.Stop();
            Console.WriteLine($"Day 2 Execution time: { stopwatch.ElapsedMilliseconds } ms");
*/
            /* // day 3
            var day3 = new AOC2019_Day3();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            //day3.mapCollisions(inputs.sampleWire1, inputs.sampleWire2);
            //day3.mapCollisions(inputs.sampleWire3, inputs.sampleWire4);
            day3.mapCollisions(inputs.wire1, inputs.wire2);
            stopwatch.Stop();
            Console.WriteLine($"Day 3 Execution time: { stopwatch.ElapsedMilliseconds } ms");
 */
            // day 4
            var day4 = new AOC2019_Day4();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //Console.WriteLine(day4.passwordTester("111111"));
            //Console.WriteLine(day4.passwordTester("223450"));
            //Console.WriteLine(day4.passwordTester("1234789"));
            //Console.WriteLine(day4.passwordTester("556699"));
            //Console.WriteLine(day4.passwordTester("988546"));
            //Console.WriteLine(day4.passwordTester("112223"));
            //Console.WriteLine(day4.passwordTester("113333")); // true
            //Console.WriteLine(day4.passwordTester("111333")); // false
            //Console.WriteLine(day4.passwordTester("122333")); // true
            Console.WriteLine(day4.findNumPasswords(206938, 679128));
            stopwatch.Stop();
            Console.WriteLine($"Day 4 Execution time: { stopwatch.ElapsedMilliseconds } ms");
        }           
    }
}

