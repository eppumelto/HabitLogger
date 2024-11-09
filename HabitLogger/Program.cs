using Microsoft.Data.Sqlite;

class Program
{
    static void Main(string[] args)
    {
        UserInput();

        string connectionString = @"Data Source=habit-tracker.db";
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "CREATE TABLE IF NOT EXISTS habits (id INTEGER PRIMARY KEY, name TEXT NOT NULL, description TEXT, created_at TEXT NOT NULL, updated_at TEXT NOT NULL)";

            command.ExecuteNonQuery();
            connection.Close();
        }
    }


    static void ViewRecords()
    {

    }
    static void InsertRecord()
    {

    }

    static void DeleteRecord()
    {

    }

    static void UpdateRecord()
    {

    }
    static void UserInput()
    {
        Console.WriteLine("Main Menu \n What would you like to do \n Type 0 to close app \n Type 1 to view all records \n Type 2 to Insert record \n Type 3 to delete record \n Type 4 to update record \n ------");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                ViewRecords();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 0:
                // close app
                Console.WriteLine("Closing app");
                break;
        }

    }


}