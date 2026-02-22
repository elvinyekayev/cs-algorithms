/**
 * 
 * Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers 
 * entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
 * 
 * */


Console.WriteLine("Input the first number:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number:");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
Console.WriteLine($"{firstNum} mod {secondNum} = {firstNum % secondNum}");

