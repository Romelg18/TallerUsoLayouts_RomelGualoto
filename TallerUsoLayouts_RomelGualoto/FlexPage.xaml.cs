namespace TallerUsoLayouts_RomelGualoto;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }

    private async void ImageTapped(object sender, EventArgs e)
    {
        // Navega a la p�gina AbsolutePage
        await Navigation.PushAsync(new AbsolutePage());
    }
}
