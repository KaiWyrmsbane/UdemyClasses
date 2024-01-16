////Implicit and Explicit Conversion challenge ClassTime: 5:54
////convert a float into a string
//float myFloat = 13.37f;
//string myString = myFloat.ToString();
//Console.WriteLine(myString);

////Parsing a String to an integer
////convert string to a number
//string stringOne = "15";
//string stringTwo = "13";
//int result = int.Parse(stringOne) + int.Parse(stringTwo);
//Console.WriteLine(result.ToString());

////Assignment 1: Parsing
//string stringForFloat = "0.85"; //datatype should be a float
//string stringForInt = "12345"; //datatype should be a float
//float ParsedStringToFloat = float.Parse(stringForFloat);
//float ParsedStringToInt = int.Parse(stringForInt);

using System.Transactions;

namespace CSharpMasterClassInClassCodingPractice
{
    class Program
    {
        static void Main()
        {
            string answerValue = "";
            Console.WriteLine("Enter number for option: ");
            Console.WriteLine("1 for UserInputChallengeSimple: ");
            Console.WriteLine("2 for UserInputChallenge: ");
            answerValue = Console.ReadLine();
            if (answerValue == "1")
            {
                UserInputChallengeSimple();
            }
            else if (answerValue == "2")
            {
                UserInputChallenge();
            }
            else
            {
                Console.WriteLine("you exited");
            }

        }

        static void UserInputChallengeSimple()
        {
            //how will I handle an exception if there was to be one
            try
            {

            }
            catch 
            {
            
            }
            Console.WriteLine("Enter the first number: ");
            int initialValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int valueAdded = Convert.ToInt32(Console.ReadLine());
            initialValue += valueAdded;
            Console.WriteLine(initialValue);

        }
        //work in progress
        static void UserInputChallenge()
        {
            var currentNumber = 0;
            Console.WriteLine("What operation do you want to perform: ");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Subtract");
            Console.WriteLine("3: multiply");
            Console.WriteLine("4: divide");
            Console.WriteLine("5: Find division remainder");
            Console.WriteLine("6: Exit");

            string qOneAnswer = Console.ReadLine();

            switch (qOneAnswer)
            {
                case "1":
                    Addition(currentNumber);
                    break;
                case "2":
                    Subtraction(currentNumber);
                    break;
                case "3":
                    Multiplication(currentNumber);
                    break;
                case "4":
                    Division(currentNumber);
                    break;
                case "5":
                    Modulo(currentNumber);
                    break;
                default:
                    Console.WriteLine("Exiting");
                    break;
            }
        }

        static float Addition(float number)
        {
            var numToAdd = Console.Read();
            number += numToAdd;
            Console.WriteLine(number);
            return number;
        }
        static void Subtraction(double number)
        {
            Console.WriteLine("Coming soon");
        }
        static void Multiplication(double number)
        {
            Console.WriteLine("Coming soon");
        }
        static void Division(double number)
        {
            Console.WriteLine("Coming soon");
        }
        static void Modulo(double number)
        {
            Console.WriteLine("Coming soon");
        }

        //try catch finally
        public void TrtCatchFinallyLesson()
        {
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            try{
                int userInput = int.Parse(Name);
            }
            catch (Exception e)
            {
                Console.WriteLine("A string can't be parsed into a number!");
            }
        }

        //operators 
        public void OperatorLesson()
        {

        }

    }

}