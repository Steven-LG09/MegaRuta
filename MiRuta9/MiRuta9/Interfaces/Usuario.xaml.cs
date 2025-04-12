using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiRuta9.Interfaces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Usuario : ContentPage
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new verRutas());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Favoritas());
        }
    }
}