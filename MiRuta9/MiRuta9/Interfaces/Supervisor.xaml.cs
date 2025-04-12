using MiRuta9.Interfaces.Alimentador;
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
    public partial class Supervisor : ContentPage
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new primaveraAsulTR());
        }
    }
}