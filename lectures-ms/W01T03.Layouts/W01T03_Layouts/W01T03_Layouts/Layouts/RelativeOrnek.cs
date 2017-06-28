using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using W01T03_Layouts.Views;
using Xamarin.Forms;

namespace W01T03_Layouts.Layouts
{
    public class RelativeOrnek : ContentPage
    {
        public RelativeOrnek()
        {
            RelativeLayout rl = new RelativeLayout();
            MyMasterDetailPage m = new MyMasterDetailPage();

            BoxView blueBox = new BoxView();
            blueBox.BackgroundColor = Color.DarkBlue;

            BoxView redBox = new BoxView();
            redBox.BackgroundColor = Color.DarkMagenta;

            rl.Children.Add(blueBox, Constraint.Constant(50),
                                     Constraint.Constant(50));

            //rl.Children.Add(redBox, Constraint.Constant(70),
            //                        Constraint.Constant(70));

            redBox.Opacity = 0.6;

            // rl.Children.Add(redBox, Constraint.RelativeToParent((parent) =>
            //{
            //    return parent.X + 30;
            //}), Constraint.RelativeToParent( (parent) =>
            // {
            //     return parent.Y + 30;
            // })
            // );

            rl.Children.Add(redBox, Constraint.RelativeToParent((parent) =>
            {
                return parent.X + 91;
            }), Constraint.RelativeToView(blueBox, (Parent, toView) =>
            {
                return toView.Y;
            }
            ));

            Content = rl;
        }
    }
}