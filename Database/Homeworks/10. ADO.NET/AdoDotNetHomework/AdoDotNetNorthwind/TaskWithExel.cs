namespace AdoDotNetNorthwind
{
    using System;
    using System.Data.OleDb;

    public class TaskWithExel
    {
        private const string Task6Query = "SELECT * FROM [Sheet1$]";
        private const string Task7Query = "INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)";

        public static void Task6(OleDbConnection oleDbConn)
        {
            OleDbCommand command = new OleDbCommand(Task6Query, oleDbConn);

            OleDbDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("\t{0} - {1}", name, score);
                }
            }
        }

        public static void Task7(OleDbConnection oleDbConn)
        {
            OleDbCommand command = new OleDbCommand(Task7Query, oleDbConn);

            command.Parameters.AddWithValue("@name", "pesho");
            command.Parameters.AddWithValue("@value", 55);

            command.ExecuteNonQuery();
        }
    }
}
