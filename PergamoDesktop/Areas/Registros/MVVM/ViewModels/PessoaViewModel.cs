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
            PessoaAtual = new Pessoa();

            AddCommand = new Command(
                async() =>
                { 
                    await pessoaRepository.InitializeAsync();
                    await pessoaRepository.AddPessoa(PessoaAtual);
                    await Refresh(pessoaRepository);
                }
            );

            UpdateCommand = new Command(
                async() =>
                {
                    await pessoaRepository.InitializeAsync();
                    await pessoaRepository.UpdatePessoa(PessoaAtual);
                    await Refresh(pessoaRepository);
                }
            );

            DeleteCommand = new Command(
                async() =>
                {
                    await pessoaRepository.InitializeAsync();

                    var resposta = await App.Current.MainPage.DisplayAlert("Alerta", "Confirma exclusão?", "Sim", "Não");
                    if(resposta)
                    {
                        await pessoaRepository.DeletePessoa(PessoaAtual);
                    }

                    await Refresh(pessoaRepository);
                }
            );

            DisplayCommand = new Command(
                async() =>
                {
                    await pessoaRepository.InitializeAsync();
                    await Refresh(pessoaRepository);
                }
            );           
        }

        private async Task Refresh(IPessoaService pessoaRepository)
        {
            Pessoas = await pessoaRepository.GetPessoas();
        }
    }
}
