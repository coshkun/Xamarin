using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W04T01.Database.Helper;
using Xamarin.Forms;
using W04T01.Database.Views;

namespace W04T01.Database
{
    public partial class App : Application
    {
        public static string DbName { get; set; } = "W04T01Database.db3";

        public App()
        {
            InitializeComponent();
            //MainPage = new W04T01.Database.MainPage();
            //string device = DependencyService.Get<IDeviceHelper>().GetDeviceName();
            //MainPage = new FirstPage(device);
            MainPage = new ListPage();
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
