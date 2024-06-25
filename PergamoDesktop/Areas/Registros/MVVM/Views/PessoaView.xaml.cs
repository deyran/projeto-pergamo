using PergamoDesktop.Areas.Registros.MVVM.ViewModels;
using PergamoDesktop.Areas.Registros.Services;

namespace PergamoDesktop.Areas.Registros.MVVM.Views;

public partial class PessoaView : ContentPage
{
	public PessoaView(IPessoaService pessoaService)
	{	
		InitializeComponent();

		BindingContext = new PessoaViewModel(pessoaService);
	}
}