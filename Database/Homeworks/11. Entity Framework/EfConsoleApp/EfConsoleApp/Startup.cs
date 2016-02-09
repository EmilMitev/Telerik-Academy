namespace EfConsoleApp
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            RandomGenerator random = RandomGenerator.Instance;
            NorthwindEntities dbConnection = new NorthwindEntities();

            using (dbConnection)
            {
                // Task 2.
                Console.WriteLine("Task 2:");

                // Insert records
                Console.WriteLine("Inserting...");
                TaskTwo.ExecuteInsert(dbConnection, random);

                // Deleting records(this delete all record from our insert!)
                Console.WriteLine("Deleting...");
                TaskTwo.ExecuteDelete(dbConnection);

                // Update records(if you want to work this comment ExecuteDelete
                Console.WriteLine("Updating...");
                TaskTwo.ExecuteUpdate(dbConnection);

                // Task 3.
                Console.WriteLine();
                Console.WriteLine("Task 3:");
                TaskThree.Execute(dbConnection);

                // Task 4.
                Console.WriteLine();
                Console.WriteLine("Task 4.");
                TaskFour.Execute(dbConnection);

                // Task 5.
                Console.WriteLine();
                Console.WriteLine("Task 5.");
                TaskFive.Execute(dbConnection);

                // Task6.
                Console.WriteLine();
                Console.WriteLine("Task 6.");
                TaskSix.Execute(dbConnection);

                // Task 8.
                Console.WriteLine();
                Console.WriteLine("Task 8.");
                TaskEight.Execute(dbConnection);
            }

            // Task 7.
            Console.WriteLine();
            Console.WriteLine("Task 7.");
            TaskSeven.Execute();
        }
    }
}
