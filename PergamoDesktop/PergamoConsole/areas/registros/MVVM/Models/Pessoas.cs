using SQLite;

namespace PergamoConsole.areas.registros.MVVM.Models
{
    [Table("REG_PESSOAS")]
    public class Pessoas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        
        [MaxLength(100), NotNull]
        public string Nome { get; set; }    
    }
}