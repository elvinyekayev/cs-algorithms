// See https://aka.ms/new-console-template for more information
/*
 * 1.Write a C# Sharp program to print Hello and your name in a separate line.
 * 2.Write a C# program to print a greeting message using string interpolation and environment variables to include the current username.
   3.Write a C# program that prints “Hello” and the full name read dynamically from user input, and then display the name in reverse order on a new line.
   4.Write a C# program that displays the greeting using a randomly generated title (Mr., Ms., Dr.) followed by the user's name entered via the console.
   5.Write a C# program to print "Hello" and a name from a list of names stored in an array, selected by index input from the user.
 */

// 1. Write a C# Sharp program to print Hello and your name in a separate line.
string name = "Elvin";

Console.WriteLine("Hello, ");
Console.WriteLine(name);


//2. Write a C# program to print a greeting message using string interpolation and environment variables to include the current username.
// string message = $"Hello, my name is {firstName} {lastName} and I am {age} years old.";

string username = Environment.UserName;
string greetingMessage = $"Hello, {username}! Welcome to C# programming.";
Console.WriteLine(greetingMessage);

//3 Write a C# program that prints “Hello” and the full name read dynamically from user input, and then display the name in reverse order on a new line.
// Console.WriteLine("Enter your full name");
// string fullName = Console.ReadLine();
// string reversedFullName = new string(fullName.Reverse().ToArray());
// Console.WriteLine($"Hello  + {fullName}!");
// Console.WriteLine(reversedFullName);

//4. Write a C# program that displays the greeting using a randomly generated title (Mr., Ms., Dr.) followed by the user's name entered via the console.

// string[] titles = ["Mr.", "Ms.","Dr."];
// Random random = new Random();
// int index = random.Next(titles.Length);
// Console.WriteLine(titles[index]);
// Console.WriteLine("Enter a name");
// string userName = Console.ReadLine();
// Console.WriteLine($"Hello {titles[index]} {userName}!");

//5. Write a C# program to print "Hello" and a name from a list of names stored in an array, selected by index input from the user.
string[] names = ["Elvin", "John", "Alice", "Bob", "Eve"];
Console.WriteLine("Enter index of the name you want to select (1-5):");
var index = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine($"Hello {names[index]}!");
