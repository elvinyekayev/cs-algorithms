/*
 * 
 * Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 * 
 */

Console.WriteLine("Enter the first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"({first} + {second}) * {third} = {(first + second) * third}");
Console.WriteLine($"{first} * {second} +  {second} + {third} = {(first * second) + (second * third)}");