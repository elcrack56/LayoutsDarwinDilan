namespace LayoutsDarwinDilan;

public partial class PaginaStackLayoutVertical : ContentPage
{
    public PaginaStackLayoutVertical()
    {
        InitializeComponent();

    }

    private async void NuevaPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaAbsoluteLayout());
    }
}