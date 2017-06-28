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
    public partial class SpecialControlsPage : ContentPage
    {
        public SpecialControlsPage()
        {
            InitializeComponent();
        }

        private void mySwitch_OnChanged(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Durum:", "Nekadar sallarsan salla son damla, " + e.Value.ToString(), "Boşver");
        }

        private void imgProfile_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Open File Dialog", "Bunları ilerleyen derslerde değiştiricez. Acele Etmeyin :)", "Tamam");
        }
    }
}