using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W04T01.Database.Helper;
using W04T01.Database.Model;
using Xamarin.Forms;

namespace W04T01.Database.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            List<Student> ogrenciler;
            using (SQLiteManager mgr = new SQLiteManager())
            {
                ogrenciler = mgr.GetAll();
            }
            lstView.BindingContext = ogrenciler;
        }
    }
}
