using SQLite;
using PergamoConsole.areas.registros.MVVM.Models;

namespace PergamoConsole.areas.registros.Services
{
    public class PessoasServices : IPessoasServices
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
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData),
                        "dbPergamo.db3"
                );

                _dbConnection = new SQLiteAsyncConnection(dbPath);
                
                await _dbConnection.CreateTableAsync<Pessoa>();
            }
        }

        public async Task<List<Pessoa>> GetPessoas()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddPessoas(Pessoa pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePessoas(Pessoa pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoa> GetPessoa(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePessoas(Pessoa pessoas)
        {
            throw new NotImplementedException();
        }
    }
}