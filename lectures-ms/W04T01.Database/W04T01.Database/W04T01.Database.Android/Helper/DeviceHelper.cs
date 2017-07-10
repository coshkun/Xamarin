using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using W04T01.Database.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(W04T01.Database.Droid.Helper.DeviceHelper))]
namespace W04T01.Database.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "W04T01.Database.Droid ortamı çalıştırıldı.";
        }
    }
}