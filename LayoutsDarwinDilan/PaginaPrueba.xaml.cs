namespace LayoutsDarwinDilan;

public partial class PaginaPrueba : ContentPage
{
	public PaginaPrueba()
	{
		InitializeComponent();
	}

    private void Boton2_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}