/*
 * Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
 */
Console.WriteLine("Enter the First number:");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int second = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the third number: ");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the fpurth number: ");
int fourth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The average of {first}, {second}, {third}, {fourth} is :  {(first + second + third + fourth)/4}");
