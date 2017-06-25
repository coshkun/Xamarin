using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W01T03_Layouts.MasterSayfalar;
using Xamarin.Forms;

namespace W01T03_Layouts.Views
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            Padding = new Thickness(0, Device.OS == TargetPlatform.iOS ? 20 :
                                      (Device.OS == TargetPlatform.Android ? 35 : 0), 0, 0);
            Master = new MyMenu();
            Detail = new MyDetail();
        }
    }
}