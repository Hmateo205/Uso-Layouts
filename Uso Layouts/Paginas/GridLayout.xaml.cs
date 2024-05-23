using System.Diagnostics.Metrics;

namespace Uso_Layouts.Paginas;

public partial class GridLayout : ContentPage
{

    public GridLayout()
    {
        InitializeComponent();
    }

    private void OnStackLayoutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Paginas.StackLayout());

    }
}