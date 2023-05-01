namespace AsyncConstructor.Service
{
    public class MyTestService
    {
        private readonly IMyFundamentalType _myFundamentalType;
        public MyTestService(IMyFundamentalType myFundamentalType)
        {
            _myFundamentalType = myFundamentalType;
        }
        public void Print()
        {
            Console.WriteLine(_myFundamentalType.Number);
        }
    }


    public class MySecTestService
    {
        private readonly IMyFundamentalType _myFundamentalType;
        public MySecTestService(IMyFundamentalType myFundamentalType)
        {
            _myFundamentalType = myFundamentalType;
        }
        public void Print()
        {
            Console.WriteLine(_myFundamentalType.Number);
        }
    }
}
