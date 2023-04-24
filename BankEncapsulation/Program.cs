namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.Deposit(50);
            account.Deposit(50);
            Console.WriteLine($"Balance:  {account.GetBalance()}");

            account.Deposit(20);
            account.Deposit(350);
            Console.WriteLine($"Balance:  {account.GetBalance()}");
        }
    }
}
