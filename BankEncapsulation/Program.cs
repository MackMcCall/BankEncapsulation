using System.Drawing;
using System.Threading.Channels;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Welcome to ATMlite!");
            Console.WriteLine();

            while (true)
            {

                Console.WriteLine("Options:\nPress 1 for Balance\nPress 2 for Deposit\nPress 3 for withdrawal\nPress 4 to quit");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine($"Your choice: {option}\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input\n");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: ${myAccount.GetBalance()}");
                        break;

                    case 2:
                        Console.Write("How much would you like to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            Console.WriteLine($"Depositing: ${depositAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        myAccount.Deposit(depositAmount);
                        Console.WriteLine($"New Balace: ${myAccount.GetBalance()}");
                        break;

                    case 3:
                        Console.Write("How much would you like to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            Console.WriteLine($"Withdrawing: ${withdrawAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        myAccount.Withdraw(withdrawAmount);
                        Console.WriteLine($"New Balace: ${myAccount.GetBalance()}");
                        break;

                    case 4:
                        return;

                    default:
                        continue;
                }
            }
        }
    }
}
