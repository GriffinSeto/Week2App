using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week2App
{
    public partial class MainPage : ContentPage
    {
        private int clicked = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            mainLabel.Text = "Click Me Has been Clicked";

            this.clicked++;

            Button button = (Button)sender;
            button.Text = $"Clicked {this.clicked} times";
        }
    }
}
