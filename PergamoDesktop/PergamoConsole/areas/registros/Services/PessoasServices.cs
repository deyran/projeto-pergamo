using PergamoConsole.areas.registros.MVVM.Models;
using PergamoConsole.database;

using SQLite;
namespace PergamoConsole.areas.registros.Services
{
    public class PessoasServices : IPessoasServices
    {
        private SQLiteAsyncConnection _dbConnection;

        public async Task InitializeAsync()
        {
           // _dbConnection =  new SQLiteAsyncConnection(DbConstantes.strConnection);
        }

        public async Task<List<Pessoas>> GetPessoas()
        {
            return await _dbConnection.Table<Pessoas>().ToListAsync();
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