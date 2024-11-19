namespace LayoutsDarwinDilan;

public partial class PaginaAbsoluteLayout : ContentPage
{
    public PaginaAbsoluteLayout()
    {
        InitializeComponent();
    }
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaGrid());
    }
}