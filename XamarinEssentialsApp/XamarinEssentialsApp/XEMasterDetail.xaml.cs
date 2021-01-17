using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XEMasterDetail : MasterDetailPage
    {
        public XEMasterDetail()
        {
            InitializeComponent();
        }

        private void UnitConverter_Clicked(object sender, EventArgs e)
        {
            //wrapp nav page around everything
            Detail = new NavigationPage(new UnitConversion());
            IsPresented = false;
        }

        private void BatteryStatus_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new BatteryStatus());
            IsPresented = false;
        }

        private void MapsApp_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MapsApp());
            IsPresented = false;
        }
    }
}