using AsyncInitialization;

public class MyFundamentalType : IMyFundamentalType, IAsyncInitializer
{
    public int Number { get; set; } = 0;
    public MyFundamentalType()
    {
        Initialization = InitializeAsync();
    }
    public Task Initialization { get; private set; }

    public async Task InitializeAsync()
    {
        Number = Random.Shared.Next();
        await Task.Delay(100);
    }
}

public interface IMyFundamentalType
{
    public int Number { get; set; }

}