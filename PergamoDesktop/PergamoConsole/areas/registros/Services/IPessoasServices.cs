using PergamoConsole.areas.registros.MVVM.Models;

namespace PergamoConsole.areas.registros.Services
{
    public interface IPessoasServices
    {
        Task InitializeAsync();
        Task<List<Pessoa>> GetPessoas();
        Task<Pessoa> GetPessoa(int IdPessoa);
        Task<int> AddPessoas(Pessoa pessoas);
        Task<int> UpdatePessoas(Pessoa pessoas);
        Task<int> DeletePessoas(Pessoa pessoas);        
    }
}