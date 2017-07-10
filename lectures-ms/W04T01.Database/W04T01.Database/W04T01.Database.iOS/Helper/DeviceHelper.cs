using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using W04T01.Database.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(W04T01.Database.iOS.Helper.DeviceHelper))]
namespace W04T01.Database.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "W04T01.Database.IOS ortamında çalıştırıldı.";
        }
    }
}