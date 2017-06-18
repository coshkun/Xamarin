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
            Master = new MyMenu();
            Detail = new MyDetail();
        }
    }
}