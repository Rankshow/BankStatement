using System.IO;
using System.Linq;
using System.Globalization;
using BankStatement;

bool status = true;

// * loop while the status is true
while(status)  
{
        AccountDetails accoutState = new AccountDetails();
        Console.WriteLine("Please provide us your account name");
        accoutState.Name = Console.ReadLine();

        Console.WriteLine($"Good Evening! {accoutState.Name}, Tell us how much you withdrawe last");
        accoutState.Withdrawal = Console.ReadLine();  

        Console.WriteLine("Enter our account number");
        accoutState.AccountNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please, How much did you deposited last?");
        accoutState.Deposit = Console.ReadLine();

        Console.WriteLine("What is your last balance?");
        accoutState.Balance = Console.ReadLine();

    try
    { 
        // ! storing the data in the console.........
        Console.WriteLine($"Id : { accoutState.Id} ");
        Console.WriteLine($"Name : {accoutState.Name}");
        Console.WriteLine($"Account number : {accoutState.AccountNumber}");
        Console.WriteLine($"Withdrawal : {accoutState.Withdrawal}");
        Console.WriteLine($"Deposit : {accoutState.Deposit}");
        Console.WriteLine($"Balance : {accoutState.Balance}");
     }
    catch(Exception e)
    {
        Console.WriteLine("Sorry we can find your file:" + e.ToString());
    }
    
    // * This line of code will terminate or continue the program depending on what is given.
        Console.WriteLine("Do you want to proceed in displaying it to the text file?");
        status = Convert.ToBoolean(Console.ReadLine()); 
}
