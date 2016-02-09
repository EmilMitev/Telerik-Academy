namespace AdoDotNetNorthwind
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    public class TaskWithNorthwind
    {
        private const string Task1Query = "SELECT COUNT(*) FROM Categories";
        private const string Task2Query = "SELECT CategoryName, Description FROM Categories";
        private const string Task3Query = "SELECT c.CategoryName, p.ProductName " +
                                        "FROM Categories c " +
                                            "JOIN Products p " +
                                                "ON p.CategoryID = c.CategoryID " +
                                        "ORDER BY c.CategoryName";

        private const string Task4Query = "INSERT INTO Products " +
                                        "(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                                        "VALUES " +
                                        "(@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitInStock,@unitsOnOrder,@recordLevel,@discontinued)";

        private const string Task5Query = "SELECT Picture FROM Categories";

        private static SqlCommand command;

        public static void Task1(SqlConnection db)
        {
            command = new SqlCommand(Task1Query, db);

            int numberOfRows = (int)command.ExecuteScalar();
            Console.WriteLine("\tNumber of categories is: {0}", numberOfRows);
        }

        public static void Task2(SqlConnection db)
        {
            command = new SqlCommand(Task2Query, db);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];

                    Console.WriteLine("\tName: {0} - {1}", categoryName, description);
                }
            }
        }

        public static void Task3(SqlConnection db)
        {
            command = new SqlCommand(Task3Query, db);

            SqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string productName = (string)reader["ProductName"];

                    Console.WriteLine("\tCategory name: {0} - Product name: {1}", categoryName, productName);
                }
            }
        }

        public static void Task4(SqlConnection db)
        {
            command = new SqlCommand(Task4Query, db);

            command.Parameters.AddWithValue("@name", "From C#");
            command.Parameters.AddWithValue("@supplierId", 1);
            command.Parameters.AddWithValue("@categoryId", 1);
            command.Parameters.AddWithValue("@quantityPerUnit", "2 bags");
            command.Parameters.AddWithValue("@unitPrice", 234.5);
            command.Parameters.AddWithValue("@unitInStock", 1000);
            command.Parameters.AddWithValue("@unitsOnOrder", 50);
            command.Parameters.AddWithValue("@recordLevel", 12);
            command.Parameters.AddWithValue("@discontinued", 0);

            command.ExecuteNonQuery();
        }

        public static void Task5(SqlConnection db)
        {
            byte[] image = null;
            SqlCommand cmd = new SqlCommand(Task5Query, db);
            SqlDataReader reader = cmd.ExecuteReader();

            var count = 0;
            string filePath;
            using (reader)
            {
                while (reader.Read())
                {
                    filePath = string.Format(@"..\..\Pictures\CategoryPicture{0}.jpg", count);
                    image = (byte[])reader["Picture"];
                    WiriteImageFile(filePath, image);
                    count++;
                }
            }
        }

        public static void Task8(SqlConnection db, string input)
        {
            input = EscapeInputString(input);

            string sqlStringCommand = string.Format(
                                                    @"SELECT ProductName
                                                    FROM Products
                                                    WHERE ProductName LIKE '%{0}%'", input);

            SqlCommand allProducts = new SqlCommand(sqlStringCommand, db);

            SqlDataReader reader = allProducts.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    Console.WriteLine("\t{0}", productName);
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, i) + "'" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }
            }

            return input;
        }

        private static void WiriteImageFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 78, fileContents.Length - 78);
            }
        }
    }
}
