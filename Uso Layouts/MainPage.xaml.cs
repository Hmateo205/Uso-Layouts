﻿using System;
using Microsoft.Maui.Controls;
using Uso_Layouts.Paginas;

namespace Uso_Layouts
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBoton1Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Contador());
        }

        private void OnBoton2Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.GridLayout());
        }

        private void OnBoton3Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.StackLayout());
        }

        private void OnBoton4Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.FlexLayout());
        }

        private void OnBoton5Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.AbsoluteLayout());
        }

    }
}
