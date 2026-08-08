namespace BankSystem.Models;
public abstract class Bank
{
    public string OwnerName{get;set;}
    public decimal Balance{get;set;}
    public Bank(string ownerName,decimal balance)
    {
        OwnerName = ownerName;
        Balance = balance;
    }
    public abstract decimal Withdraw(decimal amount );
    public abstract void ShowBalance();
    public  decimal Deposit(decimal amount)
    {
        this.Balance += amount;
        return this.Balance;
    }
}