using CommunityToolkit.Mvvm.ComponentModel;
using PergamoDesktop.Areas.Registros.MVVM.Models;
using PergamoDesktop.Areas.Registros.Services;
using System.Windows.Input;

namespace PergamoDesktop.Areas.Registros.MVVM.ViewModels
{
    public partial class PessoaViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<Pessoa> _pessoas;

        [ObservableProperty]
        private Pessoa _pessoaAtual;

        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DisplayCommand { get; set; }

        public PessoaViewModel(IPessoaService pessoaRepository)
        {
            _pessoaAtual = new Pessoa();
        }
    }
}
