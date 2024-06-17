using SQLite;


 string connectionString = "Data Source=dbPergamo.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Pessoas";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming 'Pessoas' table has 'Name' and 'Age' columns
                            Console.WriteLine("Name: " + reader["Name"] + "\tAge: " + reader["Age"]);
                        }
                    }
                }

                connection.Close();
            }