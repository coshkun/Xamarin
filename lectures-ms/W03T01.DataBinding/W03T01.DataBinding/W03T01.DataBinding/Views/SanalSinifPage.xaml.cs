using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W03T01.DataBinding.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W03T01.DataBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SanalSinifPage : ContentPage
    {
        public SanalSinifPage()
        {
            InitializeComponent();
            lstMVA.BindingContext = MVAFactory.MVAData;
        }
    }
}