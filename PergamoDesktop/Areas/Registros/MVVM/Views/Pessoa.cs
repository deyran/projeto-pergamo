using SQLite;

namespace PergamoDesktop.Areas.Registros.MVVM.Views
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
