using Xamarin.Essentials; //there is code here that will let you tap into anything in the phone system
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryStatus : ContentPage
    {
        public BatteryStatus()
        {
            InitializeComponent();
            SetBackground(Battery.ChargeLevel, Battery.State == BatteryState.Charging);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            SetBackground(e.ChargeLevel, e.State == BatteryState.Charging);
        }

        private void SetBackground(double level, bool charging)
        {
            Color? color = null;
            var status = charging ? "Charging" : "Not Charging";

            if (level > 0.65f)
            {
                //set the alpha of the text based on the battery level
                color = Color.Green.MultiplyAlpha(level);
            }
            else if (level > .25f)
            {
                color = Color.Yellow.MultiplyAlpha(1d - level);
            }
            else
            {
                color = Color.Red.MultiplyAlpha(1d - level);
            }

            BackgroundColor = color.Value;
            BatteryLevelLabel.Text = status;
        }
    }
}