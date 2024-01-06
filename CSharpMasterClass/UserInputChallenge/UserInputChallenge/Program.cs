// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
numberOne += numberTwo;
Console.WriteLine($"You total is: {numberOne}");