class Program
{
    static void Main(string[] args)
    {

        GameManager gameManager = new GameManager();

        // Loop through command-line arguments to parse options
        for (int i = 0; i < args.Length; i++)
        {
            // Check for code argument: "-c" followed by the code
            if (args[i] == "-c" && i + 1 < args.Length)
            {
                string inputCode = args[i + 1];

                // Validate the code format using GameManager's rule checker
                if (!gameManager.PassTheRules(inputCode))
                {
                    Console.WriteLine("Invalid code format");
                    return;// Exit the program if the code is invalid
                }

                gameManager.Code = inputCode; // Set code on game setting by using game Manager
            }

            // Check for max attempts argument: "-t" followed by a number

            if (args[i] == "-t" && i + 1 < args.Length)
            {
                //Make sure the attempt format is valid, the attempt must be numbers and larger than 0
                if (int.TryParse(args[i + 1], out int attempts) && attempts > 0)
                {
                    gameManager.MaxAttempts = attempts; // Set attempts
                }
                else
                {
                    Console.WriteLine("Invalid Attempts format");
                    return;
                }
            }

        }

        // Start the game after parsing and validating inputs
        gameManager.Start();

    }
}