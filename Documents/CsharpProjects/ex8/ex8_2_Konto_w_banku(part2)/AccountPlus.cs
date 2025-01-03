using System;

namespace Bank
{
    public class AccountPlus : Account, IAccountWithLimit
    {
        private decimal _oneTimeDebetLimit;

        public new string Name { get; set; }
        public new decimal Balance { get; private set; }
        public new bool IsBlocked { get; private set; } = false;

        public decimal OneTimeDebetLimit
        {
            get { return _oneTimeDebetLimit; }
            set
            {
                if (!IsBlocked)
                {
                    _oneTimeDebetLimit = Math.Max(0, Math.Round(value, 2));
                }
            }
        }

        public decimal AvaibleFounds => Math.Max(0, Balance + OneTimeDebetLimit);

        public AccountPlus(string name, decimal initialLimit = 100.00m, decimal initialBalance = 0.00m) : base(name, initialBalance)
        {
            Name = name;
            Balance = Math.Max(0, initialBalance);
            OneTimeDebetLimit = Math.Max(0, initialLimit);
            if (Balance < 0)
            {
                Block();
            }
        }

        public new bool Deposit(decimal amount)
        {
            if (amount <= 0) return false;

            Balance += amount;

            if (Balance >= 0)
            {
                Unblock();
            }

            return true;
        }

        public new bool Withdrawal(decimal amount)
        {
            if (amount <= 0 || IsBlocked || amount > AvaibleFounds) return false;

            Balance -= amount;

            if (Balance < 0)
            {
                Block();
            }

            return true;
        }

        public new void Block() => IsBlocked = true;

        public new void Unblock()
        {
            if (Balance >= 0)
            {
                IsBlocked = false;
            }
        }

        public override string ToString()
        {
            decimal displayedBalance = Balance < 0 ? 0 : Balance;

            return IsBlocked
                ? $"Account name: {Name}, balance: {displayedBalance:F2}, blocked, avaible founds: {AvaibleFounds:F2}, limit: {OneTimeDebetLimit:F2}"
                : $"Account name: {Name}, balance: {displayedBalance:F2}, avaible founds: {AvaibleFounds:F2}, limit: {OneTimeDebetLimit:F2}";
        }
    }
}
