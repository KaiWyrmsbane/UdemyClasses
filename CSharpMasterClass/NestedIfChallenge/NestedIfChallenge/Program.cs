using System.Threading.Channels;

namespace NestedIfChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var answer = Convert.ToInt32(Console.WriteLine());
            NestedIfChallenge(answer);
        }

        public static void NestedIfCheck(int number)
        {
            if (number % 2 == 0)
            {
                switch (true)
                { 
                    case 1:
                    if((number % 3 == 0) && (number % 7 == 0))
                    {
                        Console.WriteLine("Divisible by 3.");
                    }
                    break;
                case number % 3 == 0:
                    Console.WriteLine("Divisible by 3.");
                    break;
                case number % 7 == 0:
                    Console.WriteLine("Divisible by 7.");
                    break;
                }
            }
            else
            {
                switch (number)
                    case (number % 3 == 0) && (number % 7 == 0):
                    Console.WriteLine("Divisible by 3.");
                    break;
                case number % 3 == 0:
                    Console.WriteLine("Divisible by 3.");
                    break;
                case number % 7 == 0:
                    Console.WriteLine("Divisible by 7.");
                    break;
                }
            }
        }
    }
}