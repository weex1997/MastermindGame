class CodeGenerator
{
    List<int> codeList = new List<int>(); // Stores the digits of the generated code

    // Generates a random hidden code with unique digits between 0 and 8
    public string RandomHiddenCodeGenerator(int codeLength)
    {

        for (int j = 0; j < codeLength; j++)
        {
            Random random = new Random();
            int rand = random.Next(0, 8);

            // Ensure no duplicate digits
            while (codeList.Contains(rand))
            {
                rand = random.Next(0, 8);
            }
            codeList.Add(rand); // Add the unique digit to the list
        }

        // Convert list of digits into a string
        string code = string.Join("", codeList);

        return code;
    }
}