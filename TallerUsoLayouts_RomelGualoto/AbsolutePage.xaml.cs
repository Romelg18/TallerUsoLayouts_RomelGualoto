namespace TallerUsoLayouts_RomelGualoto;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
    }

    private async void GoToGridLayout(object sender, EventArgs e)
    {
        // Navega a la p�gina GridPage
        await Navigation.PushAsync(new GridPage());
    }
}
