namespace LayoutsDarwinDilan;

public partial class PaginaGrid : ContentPage
{
	public PaginaGrid()
	{
		InitializeComponent();
	}

    private void NuevaPesta�a_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}