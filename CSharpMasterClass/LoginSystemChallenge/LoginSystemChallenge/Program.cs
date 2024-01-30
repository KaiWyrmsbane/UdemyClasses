/*
Create a user Login System, where the user can first register and then 
Login in. The Program should check if the user has entered the correct 
username and password, wenn login in (so the same ones that he used when registering).
As we haven't covered storing data yet, just create the program in a way, that
registering and logging in, happen in the same execution of it.
User If statements and User Input and Methods to solve the challenge.
*/
using System.Net.NetworkInformation;
using System.Text;

namespace LoginSystemChallenge
{
    public class Program
    {
        public static string name;
        public static string email;
        public static bool hasAccount = false;
        public static bool isleaving = false;
        public static void Main(string[] args)
        {
            if (hasAccount != true)
            {
                Console.WriteLine("Would you like to register for an account? ");
                string answer = Console.ReadLine();
                bool isBusinessDone = false;

                while (hasAccount != true)
                {
                    switch (answer)
                    {
                        case "Yes":
                            register();
                            rejection();
                            break;
                        case "yes":
                            register();
                            rejection();
                            break;
                        case "yEs":
                            register();
                            rejection();
                            break;
                        case "yeS":
                            register();
                            rejection();
                            break;
                        case "YEs":
                            register();
                            rejection();
                            break;
                        case "yES":
                            register();
                            rejection();
                            break;
                        case "YES":
                            register();
                            rejection();
                            break;
                        case "no":
                            rejection();
                            break;
                        case "NO":
                            rejection();
                            break;
                        case "No":
                            rejection();
                            break;
                        case "nO":
                            rejection();
                            break;
                        default:
                            Console.WriteLine("Please Enter Yes or No when answering the question");
                            break;
                    }

                    if (isleaving == true)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Would you like to register for an account? ");
                        answer = Console.ReadLine();
                    }
                }
            }
            else
            {
                Login(name, email);
                deleteAccount();

            }
        }

        public static string register()
        {
            Console.Write("Please enter name: ");
            name = Console.ReadLine();
            Console.Write("Please enter email: ");
            email = Console.ReadLine();
            string account = $"You've created an account under the name of {name}, and under this email {email}";
            hasAccount = true;
            return account;
        }

        public static void Login(string name, string email)
        {
            Console.WriteLine($"Welcome back {name}, of {email}");
        }

        public static void rejection()
        {
            Console.WriteLine("Thank you for your time, the program is no closing!");
        }

        public static void deleteAccount()
        {
            Console.Write("Would you like to delete your present account?");
            string answer = Console.ReadLine();
            bool isBusinessDone = false;

            while (isBusinessDone == false) {
                switch (answer)
                {
                    case "Yes":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "yes":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "yEs":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "yeS":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "YEs":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "yES":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "YES":
                        ResetAccountInfo(isBusinessDone);
                        break;
                    case "no":
                        rejection();
                        break;
                    case "NO":
                        rejection();
                        break;
                    case "No":
                        rejection();
                        break;
                    case "nO":
                        rejection();
                        break;
                    default:
                        Console.WriteLine("Please Enter Yes or No when answering the question");
                        break;
                }

            }
        }

        public static bool ResetAccountInfo(bool isAccountReset)
        {
            name = "";
            email = "";
            hasAccount = false;
            Console.WriteLine("Account has be deleted");
            return isAccountReset = true;
        }
    }
}