using System;

namespace Bank{
    public class Account : Bank.IAccount
    {
        public string Name { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }

        public void Block()
        {
            IsBlocked = true;
        }

        public void Unblock()
        {
            IsBlocked = false;
        }

        public bool Deposit(decimal amount)
        {
            if (IsBlocked || amount <= 0)
                return false;
            Balance = Math.Round(Balance + amount, 4);
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            if (IsBlocked || amount <= 0 || amount > Balance)
                return false;
            Balance = Math.Round(Balance - amount, 4);
            return true;
        }
        public Account(string name, decimal balance = 0, bool isBlocked = false)
        {   
            if (string.IsNullOrWhiteSpace(name) || name == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            name = name.Trim();
            
            if(name.Length < 3){
                throw new ArgumentException("Name is too short");
            }
            if(balance < 0){
                throw new ArgumentOutOfRangeException("Balance is negative");
            }
            Name = name;
            Balance = Math.Round(balance, 4);
            IsBlocked = isBlocked;
        }
        public override string ToString()
        {
            string result = $"Account name: {Name}, balance: {Balance.ToString("F2")}";
            if(IsBlocked)    
                result += ", blocked";
            return result;
        }

        

    }
}