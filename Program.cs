using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using BankSystem.Models;
Console.WriteLine("======Welcome our Bank system=======");

    
Bank savingAccount = new SavingsAccount("Ergashev",75000);
Bank creditAccount = new CreditAccount("Abduraimov",90000);
bool savingaccount = true;
while (savingaccount)
{
    Console.WriteLine($"{savingAccount.OwnerName} is owner account  ");
    Console.WriteLine($"Your balance : {savingAccount.Balance}");
    Console.WriteLine(" 1. Enter deposit : ");
    Console.WriteLine(" 2. Enter withdraw : ");
    Console.WriteLine(" 3. Logout ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Enter your deposit : ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            savingAccount.Deposit(depositAmount);
            Console.WriteLine($"Added,your deposit {savingAccount.Balance}");
            break;
        case 2:
            Console.Write("How much do you want withdraw : ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            savingAccount.Withdraw(withdrawAmount);
            Console.WriteLine($"Your Balance : {savingAccount.Balance}");
            break;
        case 3:
            savingaccount = false;
            break;
        default:
            Console.WriteLine("Wrong number !!!");
            break;
    }
    Console.WriteLine();
    
    
}
Console.WriteLine($"{creditAccount.OwnerName} is your account");
Console.WriteLine($"Your balance {creditAccount.Balance}");
while (true)
{
    
    Console.WriteLine(" 1. Enter deposit : ");
    Console.WriteLine(" 2. Enter withdraw : ");
    Console.WriteLine(" 3. Logout ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Enter your deposit : ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            creditAccount.Deposit(depositAmount);
            Console.WriteLine($"Added,your deposit { creditAccount.Balance}");
            break;
        case 2:
            Console.Write("How much do you want withdraw : ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            creditAccount.Withdraw(withdrawAmount);
            Console.WriteLine($"Your Balance : { creditAccount.Balance}");
            break;
        case 3:
           return;
        default:
            Console.WriteLine("Wrong number !!!");
            break;
    }
}
