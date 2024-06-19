using Microsoft.Data.Sqlite;

using (var connection = new SqliteConnection("Data Source=dbPergamo.db"))
{
    connection.Open();

    var command = connection.CreateCommand();
    command.CommandText =
    "SELECT P.Id, P.Nome FROM REG_PESSOAS AS P";

    using (var reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            var Id = reader.GetString(0);
            var Nome = reader.GetString(1);

            Console.WriteLine("Id....: " + Id);
            Console.WriteLine("Nome..: " + Nome);
            Console.WriteLine("--------------------------");
        }
    }
}

//FONTE: https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=net-cli