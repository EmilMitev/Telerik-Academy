namespace AdoDotNetNorthwind
{
    using System;
    using MySql.Data.MySqlClient;

    public class TaskWithMySql
    {
        private const string Task7GetQuery = @"SELECT Title, Author, ISBN, PublishDate FROM books_information";
        private const string Task7InsertQuery = "INSERT INTO books_information(ISBN, Title,Author, PublishDate) VALUES (@isbn,@title,@author,@publishDate)";

        public static void Task7Get(MySqlConnection connection)
        {
            var command = new MySqlCommand(Task7GetQuery, connection);

            var reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Title: {0},\nAuthor: {1},\nISBN: {2},\nPublishDate: {3}", reader["Title"], reader["Author"], reader["ISBN"], (DateTime)reader["PublishDate"]);
                }
            }
        }

        public static void Task7Insert(MySqlConnection connection)
        {
            Random random = new Random();
            var command = new MySqlCommand(Task7InsertQuery, connection);
            command.Parameters.AddWithValue("@isbn", random.Next());
            command.Parameters.AddWithValue("@title", "New Book");
            command.Parameters.AddWithValue("@author", "New Author");
            command.Parameters.AddWithValue("@publishDate", DateTime.Now);

            command.ExecuteNonQuery();
        }

        public static void Task7Search(MySqlConnection connection, string input)
        {
            input = EscapeSymbols(input);

            var command = new MySqlCommand(string.Format("SELECT Title FROM books_information WHERE Title LIKE '%{0}%'", input), connection);

            var reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader["Title"]);
                }
            }
        }

        private static string EscapeSymbols(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }
            }

            return input;
        }
    }
}
