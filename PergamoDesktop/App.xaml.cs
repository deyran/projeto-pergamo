using PergamoDesktop.Areas.Registros.MVVM.Views;
using PergamoDesktop.Areas.Registros.Services;

namespace PergamoDesktop
{
    public partial class App : Application
    {
        public App(IPessoaService pessoaService)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PessoaView(pessoaService));
        }
    }
}