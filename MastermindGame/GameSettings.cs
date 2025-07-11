public abstract class GameSettings
{
    protected int codeLength = 4;
    protected int maxAttempts = 10;
    protected string code = "";

    //To access change the value by using the inherited
    public string? Code { get; set; }
    public int MaxAttempts { get; set; }

}