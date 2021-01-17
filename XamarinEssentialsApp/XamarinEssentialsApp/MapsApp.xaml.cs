using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsApp : ContentPage
    {
        public MapsApp()
        {
            InitializeComponent();
        }

        private async void OpenMap_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLongitude.Text, out double lng))
                return;
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;

            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}