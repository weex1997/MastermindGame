class GameManager : GameSettings
{
    int currentAttempt = 0;
    bool isWin = false;

    // ----- Components -----
    private CodeChecker codeChecker; // Responsible for checking guesses
    private CodeGenerator codeGenerator; // Responsible for generating the code

    // Constructor initializes the game components
    public GameManager()
    {
        codeChecker = new CodeChecker();
        codeGenerator = new CodeGenerator();
    }

    // Starts the game logic
    public void Start()
    {
        // Generate random code if none was provided
        if (string.IsNullOrEmpty(code))
            code = codeGenerator.RandomHiddenCodeGenerator(codeLength);


        Console.WriteLine("Can you break the code? Enter a valid guess.");


        // Main game loop
        while (currentAttempt < maxAttempts)
        {
            Console.WriteLine("---");
            Console.WriteLine("Round " + currentAttempt);

            string? guess = Console.ReadLine();

            // If input is valid and pass the game rules, check the guess
            if (!string.IsNullOrEmpty(guess) && PassTheRules(guess))
            {
                (int wellPlaced, int misplaced) = codeChecker.CheckPlaces(guess, code, codeLength);

                Console.WriteLine($"Well placed pieces: {wellPlaced}");
                Console.WriteLine($"Misplaced pieces: {misplaced}");

                //If the player has well placed numbers equal to the length of the code, they will win
                if (wellPlaced == codeLength)
                {
                    Win();
                    break;
                }
            }
            //This for handle the sequence Ctrl + z. It's End Of File, as a normal execution. 
            else if (guess == null)
            {
                Console.WriteLine("Exiting the game");
                break;
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            // Check for loss condition if the player reach the max attempts
            //And check if it is not winning, so as not to conflict with the last attempt
            if (currentAttempt == maxAttempts - 1 && !isWin)
            {
                Lose();
                break;
            }

            currentAttempt++; // Move to the next attempt
        }
    }

    //This method checks if the code passes the game rules
    // 1: The code must contain only numbers.
    // 2: Allowed digits range from 0 to 8.
    // 3: The code must be exactly the same length as defined in the game settings.
    // 4: No repeated digits are allowed in the code.
    public bool PassTheRules(string code)
    {
        if (code.All(c => char.IsDigit(c) && c >= '0' && c <= '8') && code.Length == codeLength && code.Distinct().Count() == code.Length)
        {
            return true;
        }
        else return false;
    }

    // Handles win logic
    void Win()
    {
        isWin = true;
        Console.WriteLine("Congratz! You did it!");
    }

    // Handles lose logic
    void Lose()
    {
        Console.WriteLine("Out of attempts. You lose!");
        Console.WriteLine("The hidden code is: " + code);
    }

}