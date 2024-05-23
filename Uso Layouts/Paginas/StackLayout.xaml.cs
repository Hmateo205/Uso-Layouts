namespace Uso_Layouts.Paginas;

public partial class StackLayout : ContentPage
{
    public StackLayout()
    {
        InitializeComponent();
    }
    private void OnFlexLayoutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Paginas.FlexLayout());
    }
}