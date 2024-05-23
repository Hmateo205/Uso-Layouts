namespace Uso_Layouts.Paginas;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    async void OnButtonClicked(object sender, EventArgs args)
    {
        Navigation.PushAsync(new MainPage());
    }

}