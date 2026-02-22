
using System.ComponentModel;

/**
 * 
 * Write a C# Sharp program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
 * 
 */
//Console.WriteLine("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"1 * {num} = {1*num}");
//Console.WriteLine($"2 * {num} = {2*num}");
//Console.WriteLine($"3 * {num} = {3*num}");
//Console.WriteLine($"4 * {num} = {4*num}");
//Console.WriteLine($"5 * {num} = {5*num}");
//Console.WriteLine($"6 * {num} = {6*num}");
//Console.WriteLine($"7 * {num} = {7*num}");
//Console.WriteLine($"8 * {num} = {8*num}");
//Console.WriteLine($"9 * {num} = {9*num}");



//Write a C# program that prints the multiplication table of a number in descending order.
//Console.WriteLine("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"9 * {num} = {9 * num}");
//Console.WriteLine($"8 * {num} = {8 * num}");
//Console.WriteLine($"7 * {num} = {7 * num}");
//Console.WriteLine($"6 * {num} = {6 * num}");
//Console.WriteLine($"5 * {num} = {5 * num}");
//Console.WriteLine($"4 * {num} = {4 * num}");
//Console.WriteLine($"3 * {num} = {3 * num}");
//Console.WriteLine($"2 * {num} = {2 * num}");
//Console.WriteLine($"1 * {num} = {1 * num}");


//Write a C# program that prints multiplication tables from 1 to the input number using nested loops.
//Console.WriteLine("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= num; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{j} * {i} = {j * i}");
//    }
//    Console.WriteLine();
//}

//Write a C# program to display a multiplication table but skip multiples of 4 and 7.
//for (int i = 1; i <= 10; i++)
//{
//    if(i == 4 || i == 7)
//        continue;
    
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{j} * {i} = {j * i}");
//    }
//    Console.WriteLine();
//}

//Write a C# program to print the multiplication table of a number but stop printing when the product exceeds 50.
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        if (i * j >= 50)
            return  ;

        Console.WriteLine($"{j} * {i} = {j * i}");
    }
    Console.WriteLine();
}