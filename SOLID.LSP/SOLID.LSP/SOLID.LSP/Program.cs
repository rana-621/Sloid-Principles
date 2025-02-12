namespace SOLID.LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Before.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);

            var account = new After.SavingAccount("Issam", 10_000);
            account.Withdraw(1000);

            //error When you use this 
            //var account = new After.FixedDepositAccount("Issam", 10_000);
            //account.Withdraw(1000);

        }
    }
}
