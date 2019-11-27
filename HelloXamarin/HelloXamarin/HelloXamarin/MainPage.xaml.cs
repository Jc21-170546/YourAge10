using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Label1.Text = "See You!";

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Label2.Text = "See You! 2";
            Label2.BackgroundColor = Color.Aqua;
        }
    }
}
