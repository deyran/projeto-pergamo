using PergamoConsole.areas.registros.MVVM.Models;
using PergamoConsole.database;

using SQLite;
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
                
                await _dbConnection.CreateTableAsync<Pessoas>();
            }
        }

        public async Task<List<Pessoas>> GetPessoas()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddPessoas(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePessoas(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoas> GetPessoa(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePessoas(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }
    }
}