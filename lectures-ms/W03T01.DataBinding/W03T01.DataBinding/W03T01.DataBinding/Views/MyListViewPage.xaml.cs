using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W03T01.DataBinding.Views
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListViewPage : ContentPage
    {
        public MyListViewPage()
        {
            InitializeComponent();
            List<User> ul = new List<User>();
            ul.Add(new User { Id = 1, Name = "Mustafa", ImageUrl = "user.png" });
            ul.Add(new User { Id = 2, Name = "Fatih", ImageUrl = "user.png" });
            ul.Add(new User { Id = 3, Name = "Elif", ImageUrl = "user.png" });
            ul.Add(new User { Id = 4, Name = "Eda", ImageUrl = "user.png" });
            ul.Add(new User { Id = 5, Name = "Coskun", ImageUrl = "user.png" });
            ul.Add(new User { Id = 6, Name = "Mennan", ImageUrl = "user.png" });
            ul.Add(new User { Id = 7, Name = "Mehmet", ImageUrl = "user.png" });
            ul.Add(new User { Id = 8, Name = "Sevde", ImageUrl = "user.png" });
            ul.Add(new User { Id = 9, Name = "Sevda", ImageUrl = "user.png" });
            ul.Add(new User { Id = 10, Name = "Seher", ImageUrl = "user.png" });
            ul.Add(new User { Id = 11, Name = "Joe", ImageUrl = "user.png" });
            ul.Add(new User { Id = 12, Name = "Jane", ImageUrl = "user.png" });

            //lstUserList.ItemsSource = ul;
            BindingContext = ul;
            //yada
            // lstUserList.BindingContext = ul;
        }

        private void lstUserList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            User selected = (User)e.SelectedItem;
            DisplayAlert("Seciminiz:", selected.Name + " olarak ayarlandı", "OK");

            ListView l = ((ListView)sender);
            l.SelectedItem = null;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button b = ((Button)sender);
            DisplayAlert("Emin misiniz?", b.CommandParameter.ToString() + ".Id silinmek üzere işaretlendi.", "Tamam");
        }
    }
}