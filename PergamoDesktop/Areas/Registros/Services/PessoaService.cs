using PergamoDesktop.Areas.Registros.MVVM.Models;
using SQLite;

namespace PergamoDesktop.Areas.Registros.Services
{
    public class PessoaService : IPessoaService
    {
        private SQLiteAsyncConnection? _dbConnection;
                
        public async Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {              
                //var dbPath = Path.Combine();
                                 
                _dbConnection = new SQLiteAsyncConnection(Path.Combine(@"C:\git-projects\projeto-pergamo\dbPergamo.db3"));
                await _dbConnection.CreateTableAsync<Pessoa>();
            }
        }


        public async Task<int> AddPessoa(Pessoa pessoa)
        {
            return await _dbConnection.InsertAsync(pessoa);
        }

        public async Task<int> DeletePessoa(Pessoa pessoa)
        {
            return await _dbConnection.DeleteAsync(pessoa);
        }

        public async Task<Pessoa> GetPessoa(int PessoaId)
        {
            return await _dbConnection.Table<Pessoa>().FirstOrDefaultAsync(x => x.Id == PessoaId);
        }

        public async Task<List<Pessoa>> GetPessoas()
        {
            return await _dbConnection.Table<Pessoa>().Take(20).ToListAsync();
        }

        public async Task<int> UpdatePessoa(Pessoa pessoa)
        {
            return await _dbConnection.UpdateAsync(pessoa);
        }
    }
}
