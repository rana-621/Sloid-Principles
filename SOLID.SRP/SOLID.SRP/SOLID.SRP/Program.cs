using SOLID.SRP.After;

namespace SOLID.SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestWithtSRP();
            // TestWithoutSRP();
        }
        public static void TestWithoutSRP()
        {
            var account = new Before.Account("John Doe", "johndo@example.com", 1000m);
            account.MakeTransaction(-500);
            account.MakeTransaction(200);
        }
        public static void TestWithtSRP()
        {
            var account = new After.Account("John Doe", "johndo@example.com", 1000m);
            AccountService service = new AccountService();
            service.Deposit(account, 500);
            service.WithDraw(account, 11000);
        }
    }
}
