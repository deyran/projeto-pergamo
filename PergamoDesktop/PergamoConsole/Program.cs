using PergamoConsole.areas.registros.MVVM.Models;
using PergamoConsole.database;

using(var pergContext = new PergamoContext())
{
    List<Pessoas> PessoasLst = pergContext.Pessoas.ToList();

    System.Console.WriteLine("*************************************");

    foreach(var pessoa in PessoasLst)
    {
        System.Console.WriteLine("id....: " + pessoa.Id);
        System.Console.WriteLine("Nome..: " + pessoa.Nome);
        System.Console.WriteLine("-------------------------");
    } 

    System.Console.WriteLine("*************************************");
}