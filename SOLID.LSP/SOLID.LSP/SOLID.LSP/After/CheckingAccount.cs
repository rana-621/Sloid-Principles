namespace SOLID.LSP.After
{
    class CheckingAccount : RegularAccount
    {
        public CheckingAccount(string name, decimal balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("incorrect to withdraw");
                return;
            }

            Balance -= amount;
        }
    }
}
