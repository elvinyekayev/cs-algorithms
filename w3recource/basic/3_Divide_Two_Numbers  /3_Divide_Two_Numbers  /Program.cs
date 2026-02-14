/*
// See https://aka.ms/new-console-template for more information
 * 1.Write a C# Sharp program to print the result of dividing two numbers.
 * 2.Write a C# program that divides two integers, prints both the quotient and remainder, and determines if the division is exact.
 * 3.Write a C# program that divides two double values but validates and rejects division by zero before processing.
 * 4.Write a C# program that takes two numbers and returns the reciprocal of the quotient if the quotient is greater than 1.
 * 5.Write a C# program to divide two numbers and output the result with 5 digits after the decimal point.
 */

//1. Write a C# Sharp program to print the result of dividing two numbers.
// Console.WriteLine("Enter the first number:");
// var firstNumber = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter the second number: ");
// var secondNumber = int.Parse(Console.ReadLine()?? "0");
// var result = firstNumber / secondNumber;
// Console.WriteLine($"The result is: {result}");

//2. Write a C# program that divides two integers, prints both the quotient and remainder, and determines if the division is exact.
// Console.WriteLine("Enter the first number:");
// var firstNumber = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter the second number: ");
// var secondNumber = int.Parse(Console.ReadLine() ?? "0");
// var quotient = firstNumber / secondNumber;
// var remainder = firstNumber % secondNumber;
// bool isDivisible = quotient != 0 && remainder != 0;
// Console.WriteLine($"The quotient is {quotient}, the remainder is {remainder} and the division is {(isDivisible ? "not exact" : "exact")}.");

//3. Write a C# program that divides two double values but validates and rejects division by zero before processing.
// Console.WriteLine("Enter the first number:");
// var firstNumber = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter the second number: ");
// var secondNumber = double.Parse(Console.ReadLine() ?? "0");
// if(secondNumber == 0)
// {
//     Console.WriteLine("Division by zero is not allowed.");
// }
// else
// {
//     var result = firstNumber / secondNumber;
//     Console.WriteLine($"The result is: {result}");
// }

//4. Write a C# program that takes two numbers and returns the reciprocal of the quotient if the quotient is greater than 1.

// Console.WriteLine("Enter the first number:");
// var firstNumber = double.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Enter the second number: ");
// var secondNumber = double.Parse(Console.ReadLine() ?? "0");
// var quotient = firstNumber / secondNumber;
// if (quotient > 1)
// {
//     var reciprocal = 1 / quotient;
//     Console.WriteLine($"The reciprocal of the quotient is: {reciprocal}");
// }
// else
// {
//     Console.WriteLine($"The reciprocal of the quotient is: {quotient}");
// }

//5. Write a C# program to divide two numbers and output the result with 5 digits after the decimal point.
Console.WriteLine("Enter the first number:");
var firstNumber = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter the second number: ");
var secondNumber = double.Parse(Console.ReadLine() ?? "0");
var result = firstNumber / secondNumber;
Console.WriteLine($"The result is: {result:F5}");
