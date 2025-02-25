using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Maintenance()
        {
            //cửa sổ riêng//
            Console.WriteLine("Enter employee's ID: ");
            int employeeID = int.Parse(Console.ReadLine());
            int id = 1234; //truy cập database để lấy id//
            int count = 0;
            bool keepGoing = true;
            while (employeeID != id)
            {
                Console.WriteLine("Invalid ID. Please try again.");
                Console.WriteLine("Enter employee's ID: ");
                employeeID = int.Parse(Console.ReadLine());
                count++;
                if (count == 2)
                {
                    Console.WriteLine("You have entered the wrong ID 3 times. Your account has been blocked.");
                    break;
                }
            }
            while (keepGoing)
            {
                Console.WriteLine("Welcome to the maintenance.");
                Console.WriteLine("Please select an option.");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Add cash to the ATM");
                Console.WriteLine("2. Check history");
                Console.WriteLine("3. Exit");
                Console.WriteLine("-------------------------");
                int choice = int.Parse(Console.ReadLine());
                int cash = 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to add to the ATM: ");
                        int deposit = int.Parse(Console.ReadLine());
                        cash += deposit;
                        Console.WriteLine("You have added $" + deposit + " to the ATM. The new balance is $" + (cash) + ".");
                        break;
                    case 2:
                        Console.WriteLine("Show history: ");//connect sql for balance history//
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using our service.");
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM machine.");
            Console.ReadKey(true);
            char userInput;
            do
            {
                Console.WriteLine("Maintenance: Y/N");
                userInput = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (userInput != 'Y' && userInput != 'N');
            if (userInput == 'Y') 
            {
                Maintenance();
            }
            else if (userInput == 'N')
            {   
                Console.WriteLine("Please insert your card.");
                Console.ReadKey(true);
                Console.Write("Enter pin number: ");
                int pinNumber = int.Parse(Console.ReadLine());
                int pin = 1234; //truy cập database để lấy pin//
                int count = 0;
                bool keepGoing = true;

                while (pinNumber != pin)
                {
                    Console.WriteLine("Invalid pin number. Please try again.");
                    Console.Write("Enter pin number: ");
                    pinNumber = int.Parse(Console.ReadLine());
                    count++;
                    if (count == 2)
                    {
                        Console.WriteLine("You have entered the wrong pin number 3 times. Your account has been blocked.");
                        break;
                    }
                }
                if (pinNumber == pin)
                {
                    Console.WriteLine("Pin number is correct.");
                }
                while (keepGoing)
                {
                    Console.WriteLine("Welcome to your account.");
                    Console.WriteLine("Please select an option.");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1. Check balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("-------------------------");

                    int choice = int.Parse(Console.ReadLine());
                    int balance = 0;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Your balance is $" + balance + ".");
                            break;
                        case 2:
                            Console.WriteLine("Enter the amount you want to deposit: ");
                            int deposit = int.Parse(Console.ReadLine());
                            balance += deposit;
                            Console.WriteLine("You have deposited $" + deposit + ". Your new balance is $" + (balance) + ".");
                            break;
                        case 3:
                            Console.WriteLine("Enter the amount you want to withdraw: ");
                            int withdraw = int.Parse(Console.ReadLine());
                            if (balance < withdraw)
                            {
                                Console.WriteLine("You do not have enough balance.");
                            }
                            else
                            {
                                balance -= withdraw;
                                Console.WriteLine("You have withdrawn $" + withdraw + ". Your new balance is $" + (balance) + ".");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using our service.");
                            keepGoing = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }

        }
    }
}
