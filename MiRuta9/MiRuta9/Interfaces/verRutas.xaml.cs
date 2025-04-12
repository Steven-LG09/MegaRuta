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
    public partial class verRutas : ContentPage
    {
        public verRutas()
        {
            InitializeComponent();

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Alimentadores());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Megabus());
        }
    }
}