using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W01T04.Controls.Views;

using Xamarin.Forms;

namespace W01T04.Controls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new W01T04.Controls.Views.SpecialControlsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
