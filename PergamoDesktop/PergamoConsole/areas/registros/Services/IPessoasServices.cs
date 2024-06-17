using PergamoConsole.areas.registros.MVVM.Models;

namespace PergamoConsole.areas.registros.Services
{
    public interface IPessoasServices
    {
        Task InitializeAsync();
        Task<List<Pessoas>> GetPessoas();
        Task<Pessoas> GetPessoa(int IdPessoa);
        Task<int> AddPessoas(Pessoas pessoas);
        Task<int> UpdatePessoas(Pessoas pessoas);
        Task<int> DeletePessoas(Pessoas pessoas);        
    }
}