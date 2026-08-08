using BankSystem.Models;
Console.WriteLine("======Welcome our Bank system=======");
while (true)
{
    Console.Write("1. Savings Account ");
    Console.Write("2. CreditAccount ");
    Console.Write("3. Stop the program ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Bank savingAccount = new SavingsAccount("Ergashev",75000);
            savingAccount.ShowBalance();
            savingAccount.Deposit(1_000);
            savingAccount.Withdraw(65000);
            break;
        case 2:
            Bank creditAccount = new CreditAccount("Abduraimov",95000);
            creditAccount.ShowBalance();
            creditAccount.Deposit(100_000);
            creditAccount.ShowBalance();
            creditAccount.Withdraw(175000);
            break;
        case 3:
            break;
        default:
            Console.WriteLine("Wrong Number ");
            break;
    }
}
