namespace Banking
{
    public class BankAccount
    {
        private decimal _balance = 0m;

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative");
            
            if (amount > _balance)
                throw new InvalidOperationException("Insufficient funds");
            
            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}