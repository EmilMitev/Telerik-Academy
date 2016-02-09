using System;

/*  Problem 10. Employee Data
    A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        First name
        Last name
        Age (0...100)
        Gender (m or f)
        Personal ID number (e.g. 8 306 112 507)
        Unique employee number (27 560 000…27 569 999)
    Declare the variables needed to keep the information for a single employee using 
    appropriate primitive data types. Use descriptive names. Print the data at the console.
 */
public class EmployeeData
{
    public static void Main()
    {
        Console.Write("Enter your first and last name:");
        string name = Console.ReadLine();

        Console.Write("\nEnter your age:");
        int age = int.Parse(Console.ReadLine());
        if (age < 0 || age > 100)
        {
            Console.WriteLine("Wrong age!");
            return;
        }

        Console.Write("\nEnter your gender(m or f):");
        char gender = char.Parse(Console.ReadLine());
        if (!(gender.Equals("m") || gender.Equals("f")))
        {
            Console.WriteLine("Wrong gender!");
            return;
        }

        Console.Write("\nEnter your personal ID number:");
        long idNumber = long.Parse(Console.ReadLine());
        if (idNumber < 1000000000 || idNumber > 999999999999)
        {
            Console.WriteLine("Wrong ID number!");
        }

        Console.WriteLine("You have successfully registered in the system!");
        Console.WriteLine("Press any key to recive unique number...");
        Console.ReadLine();
        Random randomNumber = new Random();
        int employeeNumber = randomNumber.Next(27560000, 27569999);
        Console.WriteLine("You are: " + name + ".");
        Console.WriteLine(age + " years old.");
        Console.WriteLine("Your gender is: " + gender);
        Console.WriteLine("ID Number: " + idNumber);
        Console.WriteLine("Your Unique employee number is: " + employeeNumber);
    }
}