﻿namespace SOLID.LSP.Before
{
    class CheckingAccount : Account
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
                throw new Exception("Cannot withdraw more than 1000");
            }
            else
            {
                Balance -= amount;
            }
        }

    }
}
