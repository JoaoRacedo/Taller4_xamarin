using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            //InitializeComponent();

            var label = new Label { Text = "Hola, presiona el boton", Margin = new Thickness(20) };
            var boton = new Button { Text = "Boton",  Margin = new Thickness(0, 20, 15, 5) };
            boton.Clicked += ElEventoClick;

            this.Content = new StackLayout
            {
                Children =
                {
                    label,
                    boton
                }
            };
        }


        void ElEventoClick(object sender, EventArgs e) {
            DisplayAlert("Hola", "Click", "ok");
        }

    }
}
