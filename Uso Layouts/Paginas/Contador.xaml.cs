using System.Diagnostics.Metrics;

namespace Uso_Layouts.Paginas;

public partial class Contador : ContentPage
{
    private int _counter = 0;

    public Contador()
	{
		InitializeComponent();
	}

    private void OnIncrementCounterButtonClicked(object sender, EventArgs e)
    {
        _counter++;
        CounterLabel.Text = $"El botón contador ha sido presionado {_counter} veces";
    }

}