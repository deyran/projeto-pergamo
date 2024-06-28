using SQLite;

namespace PergamoConsole.Areas.Registros.MVVM.Models
{
    [Table("REG_PESSOAS")]
    public class Pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), NotNull]
        public string? Name { get; set; }
    }
}
