namespace LayoutsDarwinDilan;

public partial class PaginaGrid : ContentPage
{
    public PaginaGrid()
    {
        InitializeComponent();
    }

    private async void NuevaPesta�a_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaStackLayoutVertical());
    }
}