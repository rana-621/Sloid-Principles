namespace SOLID.LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new Before.FixedDepositAccount("Issam", 10_000);
            account.Withdraw(1000);
        }
    }
}
