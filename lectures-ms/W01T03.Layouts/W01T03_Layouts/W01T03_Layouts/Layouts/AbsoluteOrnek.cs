using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace W01T03_Layouts.Layouts
{
    public class AbsoluteOrnek : ContentPage
    {
        public AbsoluteOrnek()
        {
            AbsoluteLayout al = new AbsoluteLayout();

            BoxView blue = new BoxView();
            blue.BackgroundColor = Color.Blue;

            al.Children.Add(blue);

            BoxView red = new BoxView();
            red.BackgroundColor = Color.Red;
            red.Opacity = 0.75;

            al.Children.Add(red, new Rectangle(20,20,40,40));

            Content = al;
        }
    }
}