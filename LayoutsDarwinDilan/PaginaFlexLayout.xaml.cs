using Microsoft.Maui.Controls;

namespace LayoutsDarwinDilan
{
    public partial class PaginaFlexLayout : ContentPage
    {
        public PaginaFlexLayout()
        {
            InitializeComponent();
        }

        private async void OnImageTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaAbsoluteLayout());
        }
    }
}
