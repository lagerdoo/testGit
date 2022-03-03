using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace control
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

         }

        void btn_img1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page1());
        }
        void btn_img2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page2());
        }
        void btn_img3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page3());
        }
        void btn_img4(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new page4());
        }
    }
}
