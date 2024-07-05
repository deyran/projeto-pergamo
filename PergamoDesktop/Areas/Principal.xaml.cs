namespace PergamoDesktop.Areas;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        BdrReg.IsVisible = !BdrReg.IsVisible;
        BdrGeral.IsVisible = !BdrReg.IsVisible;
    }
}