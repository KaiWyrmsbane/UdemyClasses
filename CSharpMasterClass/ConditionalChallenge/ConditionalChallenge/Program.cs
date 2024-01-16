using System;

namespace ConditionalChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for the following");
            Console.WriteLine("1 - Check weather using if statement");
            Console.WriteLine("2 - Check weather using switch statement");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    CheckTheWeatherUsingIf();
                    break;
                case 2:
                    CheckTheWeatherUsingSwitch();
                    break;
                default:
                    break;
            }
        }
        //make it to read all forms of temp
        static void CheckTheWeatherUsingIf()
        {
            //cw + tab is the shortcut for Console.WriteLine();
            Console.WriteLine("Enter the temperature of you area :");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 60)
            {
                Console.WriteLine("That is some pretty great weather");
            }
            else if (temp > 30)
            {
                Console.WriteLine("Well at least it's above freezing lol");
            }
            else if (temp > 15)
            {
                Console.WriteLine("Better watch those pipes");
            }
            else
            {
                Console.WriteLine("Why on earth are you here!!!");
            }
        }

        static void CheckTheWeatherUsingSwitch()
        {
            Console.WriteLine("Enter the weather: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case > 60:
                    Console.WriteLine("That is some pretty great weather");
                    break;
                case > 30:
                    Console.WriteLine("Well at least it's above freezing lol");
                    break;
                case > 15:
                    Console.WriteLine("Better watch those pipes");
                    break;
                default:
                    Console.WriteLine("Why on earth are you here!!!");
                    break;
            }
        }
    }
}

//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}