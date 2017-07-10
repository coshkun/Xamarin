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
    public partial class Detail : ContentPage
    {
        public Detail(MVA selected)
        {
            InitializeComponent();

            lblTitle.Text = selected.Title;
            lblDescription.Text = selected.Description;
        }
    }
}