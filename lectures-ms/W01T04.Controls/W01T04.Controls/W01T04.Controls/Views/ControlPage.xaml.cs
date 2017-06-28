using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W01T04.Controls.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlPage : ContentPage
    {
        public ControlPage()
        {
            InitializeComponent();
            myDatePicker.MinimumDate = DateTime.Now.AddYears(-1);
            myDatePicker.MaximumDate = DateTime.Now.AddYears(1);
            myDatePicker.Date = DateTime.Now;
            myDatePicker.Format = "yyyy-MM-dd";

            Label hdr = new Label
            {
                Text = "WebView",
                FontSize=50,
                FontAttributes=FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
            };
            WebView view = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url ="http://www.bing.com"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children = { hdr, view }
            };
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            ai_Gosterge.IsRunning = !ai_Gosterge.IsRunning;
            if (ai_Gosterge.IsRunning)
                ai_Gosterge.IsVisible = true;
            else
                ai_Gosterge.IsVisible = false;
        }

        private void myDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pkr = (Picker)sender;
            string selection = pkr.Items[pkr.SelectedIndex];
            DisplayAlert("Seciminiz:", selection + " olarak değiştirildi.", "Tamam", "Boşver");
        }

        private void btnArttir_Clicked(object sender, EventArgs e)
        {

            if (myProgress.Progress <= 1)
                myProgress.ProgressTo(myProgress.Progress + .25, 1250, Easing.SpringIn);
        }

        private void btnAzalt_Clicked(object sender, EventArgs e)
        {
            if (myProgress.Progress >= 0)
                myProgress.ProgressTo(myProgress.Progress - .25, 1250, Easing.SpringIn);
        }

        private void myStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblStepper.Text = e.NewValue.ToString();
        }

        // Asenkron Alert Response Yakalama
        private async void mySwitch_Toggled(object sender, ToggledEventArgs e)
        {
            //if(mySwitch.IsToggled)
            //    DisplayAlert("Abonelik Durumu:" + e.Value.ToString(), "Bülten aboneliğiniz onaylandı", "Tamam");
            //else
            //    DisplayAlert("Abonelik Durumu:" + e.Value.ToString(), "Bülten aboneliğiniz kaldırıldı", "Tamam");
            bool isOK = await DisplayAlert("Abonelik Durumu:" + e.Value.ToString(), "Bülten aboneliğiniz değiştirildi.", "Tamam", "Boşver");
            if (isOK == true)
                lblSwitch.TextColor = Color.Black;
            else
                lblSwitch.TextColor = Color.Gray;
        }
    }
}