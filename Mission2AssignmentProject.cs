//Grant Murdock
using Mission2Assignment;
using System;
//Make the class
class DiceSimulator
{
    static void Main()
    {
        // Figure out how many rolls the user wants
        Console.Write("How many dice rolls would you like to simulate? ");
        if (int.TryParse(Console.ReadLine(), out int numRolls) && numRolls > 0)
        {
            // Create an instance of the DiceRoll class and simulate dice rolls
            DiceRoll roller = new DiceRoll();
            int[] results = roller.SimulateRolls(numRolls);
        // Figure out how many times each combination was rolled
            for (int i = 2; i <= 12; i++)
            {
                int percentage = (int)Math.Round((double)results[i] / numRolls * 100);
                Console.WriteLine($"{i}: {new string('*', percentage)}");
            }

            Console.WriteLine($"\nTotal number of rolls = {numRolls}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
        }
    }
}
