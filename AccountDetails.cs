using System.Text;

namespace BankStatement
{
    public class AccountDetails
    {
       
        public AccountDetails()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public double AccountNumber { get; set; } 
        public string? Name { set; get;} 
        public string? Withdrawal { get; set; }  
        public string? Deposit {set; get; }
        public string? Balance {set; get;}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Id : { Id } \n");
            sb.Append($"Name : { Name } \n");
            sb.Append($"AccountNumber : { AccountNumber } \n");
            sb.Append($"Withdrawal : { Withdrawal } \n");
            sb.Append($"Deposit : { Deposit } \n");
            sb.Append($"Balance : { Balance } \n");

            return sb.ToString();    
        }
    }

}