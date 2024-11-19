namespace TallerUsoLayouts_RomelGualoto;

public partial class GridPage : ContentPage
{
    public GridPage()
    {
        InitializeComponent();
    }

    private async void GoToStackLayout(object sender, EventArgs e)
    {
        // Navega a la página StackPage
        await Navigation.PushAsync(new StackPage());
    }
}
