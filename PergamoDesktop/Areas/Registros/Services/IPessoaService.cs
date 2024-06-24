using PergamoDesktop.Areas.Registros.MVVM.Models;

namespace PergamoDesktop.Areas.Registros.Services
{
    public interface IPessoaService
    {
        Task InitializeAsync();
        Task<List<Pessoa>> GetPessoas();
        Task<Pessoa> GetPessoa(int PessoaId);
        Task<int> AddPessoa(Pessoa pessoa);
        Task<int> UpdatePessoa(Pessoa pessoa);
        Task<int> DeletePessoa(Pessoa pessoa);
    }
}
