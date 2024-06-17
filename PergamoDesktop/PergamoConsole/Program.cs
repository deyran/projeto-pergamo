using SQLite;
using PergamoConsole.database;

Console.WriteLine("------------------------------");
Console.WriteLine("--> " + DbConstantes.DatabaseFilename);
Console.WriteLine("--> " + DbConstantes.DatabasePath);
Console.WriteLine("--> " + DbConstantes.Flags);
Console.WriteLine("------------------------------");

SQLiteConnection db = new SQLiteConnection(DbConstantes.DatabaseFilename);