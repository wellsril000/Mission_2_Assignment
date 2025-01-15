namespace DiceRoller;

public class DiceRoller
{
    // this Method should return an array
    public int[] RollDiceMethod(int diceRolls)
    {
        // Create Random instance
        Random random = new Random(); // Random is a class, Next is a method of a class 
        int[] results = new int[diceRolls];

        for (int i = 0; i < diceRolls; i++)
        {
            // Generate a random number between 1 and 6 for the first dice
            int firstNum = random.Next(1, 7); // The upper bound is exclusive, so use 7
            int secondNum = random.Next(1, 7);

            // Add the numbers together
            results[i] = firstNum + secondNum;
        }

        return results;
    }
}
