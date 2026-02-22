/**
 * 
 * Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
 * 
 */


Console.WriteLine("Input the first number to multiply");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number to multiply:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the third number to multiply: ");
int thirdNumber = int.Parse(Console.ReadLine());


Console.WriteLine($"The result of {firstNumber} * {secondNumber} * {thirdNumber} = {firstNumber * secondNumber * thirdNumber}");
