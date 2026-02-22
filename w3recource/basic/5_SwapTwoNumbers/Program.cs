/* 
 
 Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
 */

//first solutinon
//int a = 5;
//int b = 6;
//Console.WriteLine($"before a = {a}, b = {b}");
//int temp = a;
//a = b;
//b = temp;

//Console.WriteLine($"after a = {a}, b= {b}");

//int a = 5;
//int b = 6;
//Console.WriteLine($"before a = {a}, b = {b}");
//a = a + b;
//b = a - b;
//a = a - b;

//Console.WriteLine($"after a = {a}, b= {b}");

//2.Write a C# program to swap three numbers in a circular way without using any additional variables.

//int a = 5;
//int b = 6;
//int c = 7;

//Console.WriteLine($"before a = {a}, b = {b}, c = {c}");
//a = a + b + c;
//b = a - (b + c);
//c = a - (c + b);
//a = a - (b + c);
//Console.WriteLine($"after a = {a}, b = {b}, c = {c}");

//Write a C# program to swap two numbers using XOR bitwise operations only.
int a = 5;
int b = 6;
Console.WriteLine($"before a = {a}, b = {b}");

a = a ^ b;
b = a ^ b;
a = a ^ b;

Console.WriteLine($"after a = {a}, b = {b}");
