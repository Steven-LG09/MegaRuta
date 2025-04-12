using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiRuta9.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dosquebradas : ContentPage
    {
        public Dosquebradas()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var location = Geolocation.GetLastKnownLocationAsync().Result;
            if (location != null)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new primaveraAsul());
            }
            else
            {
                await DisplayAlert("Alerta", "Active su ubicacion (Si ya la activo, espere unos segundos mientras se inicia)", "Ok");
            }

        }
    }
}