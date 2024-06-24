using PergamoConsole.areas.registros.MVVM.Models;
using SQLite;

string filename = $"database//dbPergamo.db";
SQLiteConnection conn = new SQLiteConnection(filename);
conn.CreateTable<Pessoa>();

List<Pessoa> Pessoas = conn.Table<Pessoa>().ToList();

foreach(var pessoa in Pessoas)
{
    System.Console.WriteLine("Id....: " + pessoa.Id);
    System.Console.WriteLine("Nome..: " + pessoa.Nome);
    System.Console.WriteLine("-----------------------------");
}

// Fonte: https://learn.microsoft.com/pt-pt/training/modules/store-local-data/3-store-data-locally-with-sqlite