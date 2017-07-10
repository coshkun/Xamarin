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
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            txtSearch.TextColor = Device.OnPlatform(Color.Black, Color.White, Color.Default);
        }

        private async void lstMVA_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lv = (ListView)sender;
            MVA selection = (MVA)e.SelectedItem;
            //DisplayAlert(selection.PublishDate.ToString() + " ",
            //    selection.Title, "OK");
            bool isOK = await DisplayAlert(selection.PublishDate.ToString() + " ",
                selection.Title, "Detay", "Vazgeç");

            if (isOK)
            {
                Navigation.PushAsync(new Detail(selection));
                //Navigation.PushModalAsync(new Detail(selection));
            }


            lv.SelectedItem = null;
        }

        private void lstMVA_Refreshing(object sender, EventArgs e)
        {
            // DisplayAlert("Refresh", "Oldu", "Tamam");
            MVAFactory.RefreshCount++;
            lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            lstMVA.IsRefreshing = false;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length >= 3)
            {
                lstMVA.BindingContext = MVAFactory.BindingWithGrouping(e.NewTextValue);
            }
            else if (string.IsNullOrEmpty(e.NewTextValue))
            {
                lstMVA.BindingContext = MVAFactory.BindingWithGrouping();
            }
        }

        private void MenuItemGuncelle_Clicked(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            int id = (int)mi.CommandParameter;
            DisplayAlert("Güncelle:", id + " nolu id güncellenecek!", "OK");
        }
    }
}