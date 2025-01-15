using DiceRoller;

internal class Program
{
    public static void Main(string[] args)
    {
        // create an instance of the DiceRoller class
        DiceRoller.DiceRoller diceRoller = new DiceRoller.DiceRoller();
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int input = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("");
        
       //Pass user input to a second class(DiceRoller) that has a method(RollDiceMethod) that simulates the roll of
       // the dice for the number of times that the user specified. 
       int[] results = diceRoller.RollDiceMethod(input);
       // call printhistogram method 
       PrintHistogram(results);
    }
    
    // pass the array of dice rolls to the method
    public static void PrintHistogram(int[] results)
    {
        // create an array to count the frequency of each number 2-12
        int[] frequency = new int[13];

        // count the frequency of each number
        foreach (int roll in results)
        {
            frequency[roll]++;
        }
        
        // Get the total number of rolls
        int totalRolls = results.Length;
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS:");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total Number of rolls: {totalRolls}");
        Console.WriteLine("");
        
        for (int i = 2; i < frequency.Length; i++)
        {
            // Calculate percentage of total rolls
            int percentage = (int)((double)frequency[i] / totalRolls * 100);
            
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}