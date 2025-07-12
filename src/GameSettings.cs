public abstract class GameSettings
{
    public int codeLength = 4;
    public string code { get; set; } = "";
    public int maxAttempts { get; set; } = 10;

}