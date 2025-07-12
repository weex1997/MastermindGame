public abstract class GameSettings
{
    protected int codeLength = 4;
    protected int maxAttempts = 10;
    protected string code = "";

    //To access and change the values
    public string? Code { get; set; }
    public int MaxAttempts { get; set; }

}