using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnitConversion : ContentPage
    {
        public UnitConversion()
        {
            InitializeComponent();
        }

        private void ConvertToKilometers(object sender, EventArgs e)
        {
            if (int.TryParse(MilesToKilometers.Text, out int val))
            {
                var kilometers = UnitConverters.MilesToKilometers(val);
                KilometersLabel.TextColor = Color.Black;
                KilometersLabel.Text = $"{Math.Round(kilometers, 2)} Kilometers";
            }
            else
            {
                KilometersLabel.TextColor = Color.Red;
                KilometersLabel.Text = $"Invalid Value!";
                MilesToKilometers.Text = string.Empty;
            }
        }

        private void ConvertToCelsius(object sender, EventArgs e)
        {
            if (int.TryParse(FahrenheitToCelsius.Text, out int val))
            {
                var celsius = UnitConverters.FahrenheitToCelsius(val);
                CelsiusLabel.TextColor = Color.Black;
                CelsiusLabel.Text = $"{Math.Round(celsius, 2)} Degrees Celsius";
            }
            else
            {
                CelsiusLabel.TextColor = Color.Red;
                CelsiusLabel.Text = $"Invalid Value!";
                FahrenheitToCelsius.Text = string.Empty;

            }
        }
    }
}