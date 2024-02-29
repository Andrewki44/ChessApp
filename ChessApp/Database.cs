using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data;
using Microsoft.Data.Sqlite;
using System.IO;


namespace Database
{
    class Database
    {
        SqliteConnectionStringBuilder connectionString = new SqliteConnectionStringBuilder()
        {
            Mode = SqliteOpenMode.ReadWriteCreate,
            DataSource = "Application.db"
        };
        
        SqliteConnection dbConnection;
        SqliteCommand command;
        string sqlCommand;
        string dbPath = Environment.CurrentDirectory + "\\DB";
        string dbFilePath;

        public async static void createDbFile()
        {
            string dbPath = Environment.CurrentDirectory + "\\DB";
            string dbFile = Path.Combine(dbPath, "sqlite.db");

            if (!string.IsNullOrEmpty(dbPath) && !Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);

            
            using (var db = new SqliteConnection($"Filename={dbFile}"))
            {
                db.Open();

                string tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                var createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
