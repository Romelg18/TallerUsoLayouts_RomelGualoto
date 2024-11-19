namespace TallerUsoLayouts_RomelGualoto;

public partial class StackPage : ContentPage
{
    public StackPage()
    {
        InitializeComponent();
    }

    private async void GoToFlexLayout(object sender, EventArgs e)
    {
        // Navega a la página FlexPage
        await Navigation.PushAsync(new FlexPage());
    }
}
