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
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            ai_Gosterge.IsRunning = !ai_Gosterge.IsRunning;
            if (ai_Gosterge.IsRunning)
                ai_Gosterge.IsVisible = true;
            else
                ai_Gosterge.IsVisible = false;
        }
    }
}