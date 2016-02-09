namespace AdoDotNetNorthwind
{
    using System;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using MySql.Data.MySqlClient;

    public class Startup
    {
        public static void Main()
        {
            // If you have exception check the connection string!!!
            SqlConnection sqlDbConnection = new SqlConnection("Server=.; " +
                                                 "Database=Northwind; " +
                                                 "Integrated Security=true");

            OleDbConnection excelDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                      "Data Source=../../Excel/Sample.xlsx;" +
                                                      "Extended Properties=\"Excel 8.0\"");

            MySqlConnection mysqlDbConnection = new MySqlConnection("Server=localhost;" +
                                                                    "Database=Books;" +
                                                                    "Uid=root;" +
                                                                    "Pwd=yourPass;");

            sqlDbConnection.Open();
            using (sqlDbConnection)
            {
                // Task 1.
                Console.WriteLine("Task 1: Number of rows in the Categories table.");
                TaskWithNorthwind.Task1(sqlDbConnection);

                // Task 2.
                Console.WriteLine("Task 2: Name and description of all categories.");
                TaskWithNorthwind.Task2(sqlDbConnection);

                // Task 3.
                Console.WriteLine();
                Console.WriteLine("Task 3: All product categories and the names of the products in each category.");
                TaskWithNorthwind.Task3(sqlDbConnection);

                // Task 4.
                Console.WriteLine();
                Console.WriteLine("Task 4: Adds a new product in the products table.");
                TaskWithNorthwind.Task4(sqlDbConnection);
                Console.WriteLine("DONE!!! Check the database.");

                // Task 5.
                Console.WriteLine();
                Console.WriteLine("Task 5: Images for all categories, stores them as JPG files in the file system.");
                TaskWithNorthwind.Task5(sqlDbConnection);
                Console.WriteLine("DONE!!! Check picture folder!");

                // Task 8.
                Console.WriteLine();
                Console.WriteLine("Task 8: Program that reads a string from the console and finds all products that contain this string.");
                Console.Write("Please enter text to search product:");
                string input = Console.ReadLine();
                Console.WriteLine(new string('-', 30));
                Console.WriteLine("Products that contain: {0}", input);
                TaskWithNorthwind.Task8(sqlDbConnection, input);
            }

            excelDbConnection.Open();
            using (excelDbConnection)
            {
                // Task 6: Check AdoDotNetNorthwind\Excel
                Console.WriteLine();
                Console.WriteLine("Task 6: From Exel displays the name and score row by row.");
                TaskWithExel.Task6(excelDbConnection);

                // Task 7.
                Console.WriteLine();
                Console.WriteLine("Task 7: Implement appending new rows to the Excel file.");
                TaskWithExel.Task7(excelDbConnection);
                Console.WriteLine("DONE!!! Check file.");
            }

            mysqlDbConnection.Open();
            using (mysqlDbConnection)
            {
                // Task 9.
                Console.WriteLine();
                Console.WriteLine("Task 9:");
                Console.WriteLine("All records in books");
                TaskWithMySql.Task7Get(mysqlDbConnection);

                Console.WriteLine();
                Console.WriteLine("Inserting...");
                TaskWithMySql.Task7Insert(mysqlDbConnection);
                Console.WriteLine("DONE!!! Check database!");

                Console.WriteLine();
                Console.Write("Write pattern for searching book by title:");
                var pattern = Console.ReadLine();
                Console.WriteLine("All reasult:");
                TaskWithMySql.Task7Search(mysqlDbConnection, pattern);
            }
        }
    }
}