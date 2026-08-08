namespace BankSystem.Models;
public class CreditAccount : Bank
{
    public CreditAccount(string ownerName,decimal balance): base(ownerName,balance)
    {

    }
    public override void ShowBalance()
    {
         Console.WriteLine($"Balance : { Balance}");
    }
    public override decimal Withdraw(decimal amount)
    {
        if (Balance - amount < -5000)
        {
            Console.WriteLine("Credit limit exceeded ");
        }
        else 
        {
            Balance -= amount;
            Console.WriteLine("Successfully");
            Console.WriteLine(Balance < 0 ? $"You can get ${5000 + Balance} credit again."
                : $"You can get ${5000} credit.");
        }
        return Balance;
    }
}