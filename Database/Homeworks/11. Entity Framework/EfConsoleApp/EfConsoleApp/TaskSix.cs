﻿namespace EfConsoleApp
{
    using System;

    public class TaskSix
    {
        public static void Execute(NorthwindEntities dbConnection)
        {
            // You must change your App.config file in order to generate a clone of Northwind

            // Summary:
            //     Creates a new database on the database server for the model defined in the backing
            //     context, but only if a database with the same name does not already exist on
            //     the server.
            //
            // Returns:
            //     True if the database did not exist and was created; false otherwise.
            var flag = dbConnection.Database.CreateIfNotExists();
            Console.WriteLine("\t" + (flag ? "Database was created":"Database already exist"));
        }
    }
}
