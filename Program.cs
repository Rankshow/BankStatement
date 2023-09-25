using System.IO;
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

    // * creating and storing the datas that is been supply in this file
    string? filePath = @"C:\Bank\BankData.txt";

    try
    {
        File.WriteAllText(filePath, accoutState.ToString());  
    }
    catch(Exception e)
    {
        Console.WriteLine("Sorry we can find your file:" + e.ToString());
    }
    
    // * This line of code will terminate or continue the program depending on what is given.
        Console.WriteLine("Do you want to proceed in displaying it to the text file?");
        status = Convert.ToBoolean(Console.ReadLine()); 
}
