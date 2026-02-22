/*
 * 1.Write a C# Sharp program to print the sum of two numbers.
 * 2.Write a C# program that takes two floating-point numbers, rounds them, and then calculates their sum.
   3.Write a C# program that reads two hexadecimal numbers from input and prints their sum in decimal form.
   4.Write a C# program to add two user-entered values but swap them using XOR logic before adding.
   5.Write a C# program that calculates the sum of two randomly generated integers between 100 and 999 and checks if the result is even.
 */


//1.Write a C# Sharp program to print the sum of two numbers.
// Console.WriteLine("Enter first number: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine(a + b);

//2.Write a C# program that takes two floating-point numbers, rounds them, and then calculates their sum.
// Console.WriteLine("Enter first number: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// double b = Math.Round(Convert.ToDouble(Console.ReadLine()));
//
// double roundedA =Math.Round(a);
// double roundedB = Math.Round(b);
// var result = roundedA + roundedB;
//
// Console.WriteLine("The result is: " + result);

//3.Write a C# program that reads two hexadecimal numbers from input and prints their sum in decimal form.

// Console.WriteLine("Enter first hex number:");
// string firstHex = Console.ReadLine();
// Console.WriteLine("Enter second hex number:");
// string secondHex = Console.ReadLine();
//
// int firstNum = Convert.ToInt32(firstHex, 16);
// int secondNum = Convert.ToInt32(secondHex, 16);
//
// int sum = firstNum + secondNum;
// Console.WriteLine("Converted first number is: " + firstNum);
// Console.WriteLine("Converted second number is: " + secondNum);
// Console.WriteLine("The sum is: " + firstHex +  " and " + secondHex +  " is: " + sum);

//   4.Write a C# program to add two user-entered values but swap them using XOR logic before adding.

/*
 * Klassik swap (əlavə dəyişənlə):
   temp = a
   a = b
   b = temp
   XOR swap (əlavə dəyişən OLMADAN):
   a = a ^ b
   b = a ^ b
   a = a ^ b
 */

// Console.WriteLine("Enter the first number: ");
// int firstNumber = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// int secondNumber = int.Parse(Console.ReadLine());
//
// firstNumber = firstNumber ^ secondNumber;
// secondNumber = firstNumber ^ secondNumber;
// firstNumber = firstNumber ^ secondNumber;
//
// Console.WriteLine("firstNumber:  " + firstNumber);
// Console.WriteLine("secondNumber : " + secondNumber);
//
// Console.WriteLine("Sum of two numbers: " + (firstNumber + secondNumber));

// 5.Write a C# program that calculates the sum of two randomly generated integers between 100 and 999 and checks if the result is even.

Random random = new Random();
int a = random.Next(100, 999);
int b = random.Next(100, 999);

Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);
Console.WriteLine("Sum: " + (a + b));

Console.WriteLine((a + b) % 2 == 0 ? "even" : "odd");