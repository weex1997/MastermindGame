public class CodeChecker
{
    // This method checks how many digits in the guess are:
    // - wellPlaced: correct digit and correct position
    // - misplaced: correct digit but wrong position
    public (int wellPlaced, int misplaced) CheckPlaces(string guess, string code, int codeLength)
    {
        int wellPlaced = 0;
        int misplaced = 0;

        //Loop to check numbers ordered one by one and compare them
        for (int i = 0; i < codeLength; i++)
        {
            if (code[i] == guess[i])
            {
                wellPlaced++;
            }
            //If the guess number is not equal to the code, then check the total of the code if contains the number
            else if (code.Contains(guess[i]))
            {
                misplaced++;
            }
        }

        return (wellPlaced, misplaced);
    }

}