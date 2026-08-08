namespace BankSystem.Models;
public class SavingsAccount : Bank
{
    public SavingsAccount(string ownerName,decimal balance)
        : base( ownerName, balance)
    {
        
    }
    public override void ShowBalance()
    {
        Console.WriteLine($"Balance : { Balance}");
    }
    public override decimal Withdraw(decimal amount)
    {
        if(Balance < amount)
        {
            Console.WriteLine("Your balance is not enuogh!!!");
        }
        else 
        {
            Balance -= amount;
            Console.WriteLine("Successfully ");
        }
        return Balance;
    }
}