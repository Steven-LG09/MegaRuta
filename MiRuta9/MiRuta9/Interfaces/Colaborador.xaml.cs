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
    public partial class Colaborador : ContentPage
    {
        public Colaborador()
        {
            InitializeComponent();
        }

        string user;
        string password;
        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            user = text;
        }

        private void Entry_Completed_1(object sender, EventArgs e)
        {
            string text1 = ((Entry)sender).Text;
            password = text1;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            switch (user)
            {
                case "super0":
                    if (password == "1234")
                    {
                        await Application.Current.MainPage.Navigation.PushModalAsync(new Supervisor());
                    }
                    break;
                case "condu0":
                    if (password == "1234")
                    {
                        await Application.Current.MainPage.Navigation.PushModalAsync(new Conductor());
                    }
                    break;
                default:
                    verificador.IsVisible = true;
                    verificador.Text = "Datos Incorrectos";
                    break;
            }
        }
    }
}