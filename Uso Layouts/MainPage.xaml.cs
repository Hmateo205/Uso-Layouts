using System;
using Microsoft.Maui.Controls;

namespace Uso_Layouts
{
    public partial class MainPage : ContentPage
    {
        private int _counter = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterButtonClicked(object sender, EventArgs e)
        {
            _counter++;
            CounterLabel.Text = $"El botón contador ha sido presionado {_counter} veces";
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Incrementa el contador si es necesario o navega a una nueva página de Grid Layout
            _counter++;
            CounterLabel.Text = $"El botón contador ha sido presionado {_counter} veces";
            // Navegar a una nueva página de Grid Layout si está disponible
        }
    }
}
