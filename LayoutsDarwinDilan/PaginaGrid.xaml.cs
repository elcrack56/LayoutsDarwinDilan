namespace LayoutsDarwinDilan;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}

    private void NuevaPestaña_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}