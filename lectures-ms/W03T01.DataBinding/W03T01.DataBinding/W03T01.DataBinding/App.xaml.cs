using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W03T01.DataBinding.Views;
using Xamarin.Forms;

namespace W03T01.DataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //PushAsyc ile hata veren standart yazım biçimi:
            //MainPage = new SanalSinifPage();
            MainPage = new NavigationPage(new SanalSinifPage());
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
