using PergamoDesktop.Areas;

namespace PergamoDesktop
{
    public partial class App : Application
    {
        public App()
        {
            //IPessoaService pessoaService
            InitializeComponent();

            //MainPage = new NavigationPage(new PessoaView(pessoaService));
            MainPage = new NavigationPage(new Principal());

        }
    }
}