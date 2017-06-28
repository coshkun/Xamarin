using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W02T01.Styles.Views;
using Xamarin.Forms;

namespace W02T01.Styles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ThemePage();
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
