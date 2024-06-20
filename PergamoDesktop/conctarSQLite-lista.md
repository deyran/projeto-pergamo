# Conexão com SQLite e uma lista

```
using PergamoConsole.areas.registros.MVVM.Models;
using SQLite;

string filename = "database//dbPergamo.db";
SQLiteConnection conn = new SQLiteConnection(filename);
conn.CreateTable<Pessoas>();

List<Pessoas> PessoasLst = conn.Table<Pessoas>().ToList();

foreach(var pessoa in PessoasLst)
{
    System.Console.WriteLine("Id....: " + pessoa.Id);
    System.Console.WriteLine("Nome..: " + pessoa.Nome);
    System.Console.WriteLine("-----------------------------");
}

// Fonte: https://learn.microsoft.com/pt-pt/training/modules/store-local-data/3-store-data-locally-with-sqlite
```