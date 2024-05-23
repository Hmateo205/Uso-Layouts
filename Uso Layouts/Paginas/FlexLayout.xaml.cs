namespace Uso_Layouts.Paginas;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    public async void Click(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}