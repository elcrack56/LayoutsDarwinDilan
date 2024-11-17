namespace LayoutsDarwinDilan
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void NuevaPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaGrid());
        }
    }

}
