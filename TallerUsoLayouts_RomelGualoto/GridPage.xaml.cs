namespace TallerUsoLayouts_RomelGualoto;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
    }

    private async void GoToStackLayout(object sender, EventArgs e)
    {
        // Navega a la p�gina StackPage
        await Navigation.PushAsync(new StackPage());
    }
}
