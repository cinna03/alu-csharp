using NUnit.Framework;
using Banking;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void GetBalance_NewAccount_ReturnsZero()
        {
            var account = new Banking.BankAccount();
            Assert.AreEqual(0m, account.GetBalance());
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            var account = new Banking.BankAccount();
            account.Deposit(100m);
            Assert.AreEqual(100m, account.GetBalance());
        }

        [Test]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            var account = new Banking.BankAccount();
            Assert.Throws<ArgumentException>(() => account.Deposit(-50m));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            var account = new Banking.BankAccount();
            account.Deposit(100m);
            account.Withdraw(30m);
            Assert.AreEqual(70m, account.GetBalance());
        }

        [Test]
        public void Withdraw_NegativeAmount_ThrowsException()
        {
            var account = new Banking.BankAccount();
            Assert.Throws<ArgumentException>(() => account.Withdraw(-10m));
        }

        [Test]
        public void Withdraw_MoreThanBalance_ThrowsException()
        {
            var account = new Banking.BankAccount();
            account.Deposit(50m);
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100m));
        }
    }
}