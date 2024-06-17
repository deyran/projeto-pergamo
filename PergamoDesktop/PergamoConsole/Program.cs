using PergamoConsole.areas.registros.MVVM.Models;
using PergamoConsole.areas.registros.Services;

public class Program
{
    static void Main(string[] args)
    {
        ObterEImprimirPessoas().GetAwaiter().GetResult();
    }

    private static async Task ObterEImprimirPessoas()
    {
        var pessoaLst = await new PessoasServices().GetPessoas();

        foreach (var pessoa in pessoaLst)
        {
            Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}");
        }
    }
}
