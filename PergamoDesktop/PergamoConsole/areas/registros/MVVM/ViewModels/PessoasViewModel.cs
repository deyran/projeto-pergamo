using CommunityToolkit.Mvvm.ComponentModel;
using PergamoConsole.areas.registros.MVVM.Models;
using PergamoConsole.areas.registros.Services;
using System.Windows.Input;

namespace PergamoConsole.areas.registros.MVVM.ViewModels
{
    public partial class PessoasViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Pessoas>? _pessoas;

        [ObservableProperty]
        private Pessoas? _pessoaAtual;

        public PessoasViewModel(IPessoasServices pessoaRepository)
        {
            _pessoaAtual = new Pessoas();

            AddCommand = new Command();
        }

        public ICommand AddCommand { get; set; }
        /*public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DisplayCommand { get; set; }*/

    }
}