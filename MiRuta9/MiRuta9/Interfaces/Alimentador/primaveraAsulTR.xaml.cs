using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace MiRuta9.Interfaces.Alimentador
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class primaveraAsulTR : ContentPage
    {
        public primaveraAsulTR()
        {
            InitializeComponent();

            Pin IntDos = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Dosquebradas",
                IsVisible = false,
                Address = "BAHIA 3 Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835497, -75.668286),
            };
            mapa.Pins.Add(IntDos);
            IntDos.Clicked += PinUno;

            Pin pin01 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835497, -75.668286),
            };
            mapa.Pins.Add(pin01);

            Pin pin1 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835126, -75.667746),
            };
            mapa.Pins.Add(pin1);

            Pin pin2 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835528, -75.667458),
            };
            mapa.Pins.Add(pin2);

            Pin Pparada = new Pin()
            {
                Type = PinType.Place,
                Label = "1ra Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834863, -75.666396),
            };
            mapa.Pins.Add(Pparada);
            Pparada.Clicked += PinDos;

            Pin pin02 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834863, -75.666396),
            };
            mapa.Pins.Add(pin02);

            Pin pin3 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834759, -75.666249),
            };
            mapa.Pins.Add(pin3);

            Pin Sparada = new Pin()
            {
                Type = PinType.Place,
                Label = "2da Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835310, -75.665255),
            };
            mapa.Pins.Add(Sparada);
            Sparada.Clicked += PinTres;

            Pin pin03 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835310, -75.665255),
            };
            mapa.Pins.Add(pin03);

            Pin pin4 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835423, -75.665106),
            };
            mapa.Pins.Add(pin4);

            Pin pin5 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836259, -75.664808),
            };
            mapa.Pins.Add(pin5);

            Pin Tparada = new Pin()
            {
                Type = PinType.Place,
                Label = "3ra Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836049, -75.664206),
            };
            mapa.Pins.Add(Tparada);
            Tparada.Clicked += PinCuatro;

            Pin pin04 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836049, -75.664206),
            };
            mapa.Pins.Add(pin04);

            Pin pin6 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835896, -75.663580),
            };
            mapa.Pins.Add(pin6);

            Pin Cparada = new Pin()
            {
                Type = PinType.Place,
                Label = "4ta Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835610, -75.663082),
            };
            mapa.Pins.Add(Cparada);
            Cparada.Clicked += PinCinco;

            Pin pin05 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835610, -75.663082),
            };
            mapa.Pins.Add(pin05);

            Pin pin7 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835503, -75.662754),
            };
            mapa.Pins.Add(pin7);

            Pin pin8 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835602, -75.662475),
            };
            mapa.Pins.Add(pin8);

            Pin pin9 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836038, -75.662142),
            };
            mapa.Pins.Add(pin9);

            Pin Qparada = new Pin()
            {
                Type = PinType.Place,
                Label = "5ta Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836104, -75.661925),
            };
            mapa.Pins.Add(Qparada);
            Qparada.Clicked += PinSeis;

            Pin pin06 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836104, -75.661925),
            };
            mapa.Pins.Add(pin06);

            Pin pin10 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836116, -75.661822),
            };
            mapa.Pins.Add(pin10);

            Pin pin11 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835748, -75.661562),
            };
            mapa.Pins.Add(pin11);

            Pin SEparada = new Pin()
            {
                Type = PinType.Place,
                Label = "6ta Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835494, -75.661233),
            };
            mapa.Pins.Add(SEparada);
            SEparada.Clicked += PinSiete;

            Pin pin07 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835494, -75.661233),
            };
            mapa.Pins.Add(pin07);

            Pin SEcparada = new Pin()
            {
                Type = PinType.Place,
                Label = "7ta Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834669, -75.660241),
            };
            mapa.Pins.Add(SEcparada);
            SEcparada.Clicked += PinOcho;

            Pin pin08 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834669, -75.660241),
            };
            mapa.Pins.Add(pin08);

            Pin pin12 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834577, -75.660156),
            };
            mapa.Pins.Add(pin12);

            Pin pin13 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834097, -75.660561),
            };
            mapa.Pins.Add(pin13);

            Pin Oparada = new Pin()
            {
                Type = PinType.Place,
                Label = "8va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833933, -75.660403),
            };
            mapa.Pins.Add(Oparada);
            Oparada.Clicked += PinNueve;

            Pin pin09 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833933, -75.660403),
            };
            mapa.Pins.Add(pin09);

            Pin Nparada = new Pin()
            {
                Type = PinType.Place,
                Label = "9na Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833420, -75.659773),
            };
            mapa.Pins.Add(Nparada);
            Nparada.Clicked += PinDiez;

            Pin pin010 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833420, -75.659773),
            };
            mapa.Pins.Add(pin010);

            Pin pin14 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833265, -75.659512),
            };
            mapa.Pins.Add(pin14);

            Pin Dparada = new Pin()
            {
                Type = PinType.Place,
                Label = "10ma Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833320, -75.658434),

            };
            mapa.Pins.Add(Dparada);
            Dparada.Clicked += PinOnce;

            Pin pin011 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833320, -75.658434),
            };
            mapa.Pins.Add(pin011);

            Pin pin15 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833371, -75.657914),
            };
            mapa.Pins.Add(pin15);

            Pin Onparada = new Pin()
            {
                Type = PinType.Place,
                Label = "11va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833742, -75.657435),
            };
            mapa.Pins.Add(Onparada);
            Onparada.Clicked += PinDoce;

            Pin pin012 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833742, -75.657435),
            };
            mapa.Pins.Add(pin012);

            Pin pin16 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834168, -75.656947),
            };
            mapa.Pins.Add(pin16);

            Pin pin17 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834226, -75.657071),
            };
            mapa.Pins.Add(pin17);

            Pin pin18 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834078, -75.657322),
            };
            mapa.Pins.Add(pin18);

            Pin Doparada = new Pin()
            {
                Type = PinType.Place,
                Label = "12va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834085, -75.657488),
            };
            mapa.Pins.Add(Doparada);
            Doparada.Clicked += PinTrece;

            Pin pin013 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834085, -75.657488),
            };
            mapa.Pins.Add(pin013);

            Pin pin19 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834039, -75.657654),
            };
            mapa.Pins.Add(pin19);

            Pin pin20 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833782, -75.657992),
            };
            mapa.Pins.Add(pin20);

            Pin Trparada = new Pin()
            {
                Type = PinType.Place,
                Label = "13va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833795, -75.658131),
            };
            mapa.Pins.Add(Trparada);
            Trparada.Clicked += PinCatorce;

            Pin pin014 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833795, -75.658131),
            };
            mapa.Pins.Add(pin014);

            Pin pin21 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833690, -75.658531),
            };
            mapa.Pins.Add(pin21);

            Pin pin22 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833704, -75.658752),
            };
            mapa.Pins.Add(pin22);

            Pin pin23 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833610, -75.658914),
            };
            mapa.Pins.Add(pin23);

            Pin Caparada = new Pin()
            {
                Type = PinType.Place,
                Label = "14va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834195, -75.659612),
            };
            mapa.Pins.Add(Caparada);
            Caparada.Clicked += PinQuince;

            Pin pin015 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834195, -75.659612),
            };
            mapa.Pins.Add(pin015);

            Pin Quparada = new Pin()
            {
                Type = PinType.Place,
                Label = "15va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834724, -75.660233),
            };
            mapa.Pins.Add(Quparada);
            Quparada.Clicked += Pin016;

            Pin pin016 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834724, -75.660233),
            };
            mapa.Pins.Add(pin016);

            Pin Diparada = new Pin()
            {
                Type = PinType.Place,
                Label = "16va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835462, -75.661119),
            };
            mapa.Pins.Add(Diparada);
            Diparada.Clicked += Pin017;

            Pin pin017 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835462, -75.661119),
            };
            mapa.Pins.Add(pin017);

            Pin pin24 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835774, -75.661539),
            };
            mapa.Pins.Add(pin24);

            Pin pin25 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836177, -75.661824),
            };
            mapa.Pins.Add(pin25);

            Pin pin26 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836166, -75.661926),
            };
            mapa.Pins.Add(pin26);

            Pin Dieparada = new Pin()
            {
                Type = PinType.Place,
                Label = "17va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836309, -75.662108),
            };
            mapa.Pins.Add(Dieparada);
            Dieparada.Clicked += Pin018;

            Pin pin018 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836309, -75.662108),
            };
            mapa.Pins.Add(pin018);

            Pin Diezparada = new Pin()
            {
                Type = PinType.Place,
                Label = "18va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837069, -75.663062),
            };
            mapa.Pins.Add(Diezparada);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(Diezparada.Position, Distance.FromMeters(700)));
            Diezparada.Clicked += Pin019;

            Pin pin019 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837069, -75.663062),
            };
            mapa.Pins.Add(pin019);

            Pin Diesparada = new Pin()
            {
                Type = PinType.Place,
                Label = "19va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837849, -75.664029),
            };
            mapa.Pins.Add(Diesparada);
            Diesparada.Clicked += Pin020;

            Pin pin020 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837849, -75.664029),
            };
            mapa.Pins.Add(pin020);

            Pin pin27 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837903, -75.664131),
            };
            mapa.Pins.Add(pin27);

            Pin Vparada = new Pin()
            {
                Type = PinType.Place,
                Label = "20va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837488, -75.664547),
            };
            mapa.Pins.Add(Vparada);
            Vparada.Clicked += Pin021;

            Pin pin021 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837488, -75.664547),
            };
            mapa.Pins.Add(pin021);

            Pin Vpparada = new Pin()
            {
                Type = PinType.Place,
                Label = "21va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837101, -75.664925),
            };
            mapa.Pins.Add(Vpparada);
            Vpparada.Clicked += Pin022;

            Pin pin022 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837101, -75.664925),
            };
            mapa.Pins.Add(pin022);

            Pin pin28 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837016, -75.665010),
            };
            mapa.Pins.Add(pin28);

            Pin pin29 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.837027, -75.665213),
            };
            mapa.Pins.Add(pin29);

            Pin pin30 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836781, -75.665374),
            };
            mapa.Pins.Add(pin30);

            Pin Vsparada = new Pin()
            {
                Type = PinType.Place,
                Label = "22va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836384, -75.664944),

            };
            mapa.Pins.Add(Vsparada);
            Vsparada.Clicked += Pin023;

            Pin pin023 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836384, -75.664944),
            };
            mapa.Pins.Add(pin023);

            Pin pin31 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836303, -75.664851),
            };
            mapa.Pins.Add(pin31);

            Pin pin32 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835432, -75.665155),
            };
            mapa.Pins.Add(pin32);

            Pin pin33 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834793, -75.666246),
            };
            mapa.Pins.Add(pin33);

            Pin Vtparada = new Pin()
            {
                Type = PinType.Place,
                Label = "23va Parada",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835235, -75.666951),
            };
            mapa.Pins.Add(Vtparada);
            Vtparada.Clicked += Pin024;

            Pin pin024 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835235, -75.666951),
            };
            mapa.Pins.Add(pin024);

            Pin pin34 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835597, -75.667513),
            };
            mapa.Pins.Add(pin34);

            Pin pin35 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835204, -75.667751),
            };
            mapa.Pins.Add(pin35);

            Pin pin36 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835764, -75.668528),
            };
            mapa.Pins.Add(pin36);

            Pin pin37 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835763, -75.668580),
            };
            mapa.Pins.Add(pin37);

            Pin pin38 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835706, -75.668577),
            };
            mapa.Pins.Add(pin38);

            Pin pin39 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Alimentador.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Alimentador.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835497, -75.668286),
            };
            mapa.Pins.Add(pin39);

            Polyline polyline = new Xamarin.Forms.GoogleMaps.Polyline()
            {
                StrokeColor = Color.Yellow,
                StrokeWidth = 3,
            };

            foreach (var pin in mapa.Pins)
            {
                polyline.Positions.Add(pin.Position);
            }
            mapa.Polylines.Add(polyline);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Xamarin.Forms.GoogleMaps.Position(polyline.Positions[0].Latitude, polyline.Positions[0].Longitude), Xamarin.Forms.GoogleMaps.Distance.FromMiles(0.50f)));

            var status = Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>().Result;
            if (status != PermissionStatus.Granted)
            {
                var request = Permissions.RequestAsync<Permissions.LocationWhenInUse>().Result;
                if (request != PermissionStatus.Granted)
                {
                    return;
                }
            }
            mapa.UiSettings.ZoomControlsEnabled = false;
        }

        private async void PinUno(object sender, EventArgs e)
        {
            await DisplayAlert("Intercambiador Dosquebradas", "El bus llega en aproximadamente 0 minutos", "Ok");
        }
        private async void PinDos(object sender, EventArgs e)
        {
            await DisplayAlert("1ra Parada", "El bus llega en aproximadamente 1 minuto", "Ok");
        }
        private async void PinTres(object sender, EventArgs e)
        {
            await DisplayAlert("2da Parada", "El bus llega en aproximadamente 2 minutos", "Ok");
        }
        private async void PinCuatro(object sender, EventArgs e)
        {
            await DisplayAlert("3ra Parada", "El bus llega en aproximadamente 2 minutos", "Ok");
        }
        private async void PinCinco(object sender, EventArgs e)
        {
            await DisplayAlert("4ta Parada", "El bus llega en aproximadamente 3 minutos", "Ok");
        }
        private async void PinSeis(object sender, EventArgs e)
        {
            await DisplayAlert("5ta Parada", "El bus llega en aproximadamente 4 minutos", "Ok");
        }
        private async void PinSiete(object sender, EventArgs e)
        {
            await DisplayAlert("6ta Parada", "El bus llega en aproximadamente 4 minutos", "Ok");
        }
        private async void PinOcho(object sender, EventArgs e)
        {
            await DisplayAlert("7ma Parada", "El bus llega en aproximadamente 5 minutos", "Ok");
        }
        private async void PinNueve(object sender, EventArgs e)
        {
            await DisplayAlert("8va Parada", "El bus llega en aproximadamente 5 minutos", "Ok");
        }
        private async void PinDiez(object sender, EventArgs e)
        {
            await DisplayAlert("9na Parada", "El bus llega en aproximadamente 6 minutos", "Ok");
        }
        private async void PinOnce(object sender, EventArgs e)
        {
            await DisplayAlert("10ma Parada", "El bus llega en aproximadamente 7 minutos", "Ok");
        }
        private async void PinDoce(object sender, EventArgs e)
        {
            await DisplayAlert("11va Parada", "El bus llega en aproximadamente 7 minutos", "Ok");
        }
        private async void PinTrece(object sender, EventArgs e)
        {
            await DisplayAlert("12va Parada", "El bus llega en aproximadamente 8 minutos", "Ok");
        }
        private async void PinCatorce(object sender, EventArgs e)
        {
            await DisplayAlert("13va Parada", "El bus llega en aproximadamente 8 minutos", "Ok");
        }
        private async void PinQuince(object sender, EventArgs e)
        {
            await DisplayAlert("14va Parada", "El bus llega en aproximadamente 9 minutos", "Ok");
        }
        private async void Pin016(object sender, EventArgs e)
        {
            await DisplayAlert("15va Parada", "El bus llega en aproximadamente 10 minutos", "Ok");
        }
        private async void Pin017(object sender, EventArgs e)
        {
            await DisplayAlert("16va Parada", "El bus llega en aproximadamente 10 minutos", "Ok");
        }
        private async void Pin018(object sender, EventArgs e)
        {
            await DisplayAlert("17va Parada", "El bus llega en aproximadamente 11 minutos", "Ok");
        }
        private async void Pin019(object sender, EventArgs e)
        {
            await DisplayAlert("18va Parada", "El bus llega en aproximadamente 11 minutos", "Ok");
        }
        private async void Pin020(object sender, EventArgs e)
        {
            await DisplayAlert("19va Parada", "El bus llega en aproximadamente 12 minutos", "Ok");
        }
        private async void Pin021(object sender, EventArgs e)
        {
            await DisplayAlert("20va Parada", "El bus llega en aproximadamente 13 minutos", "Ok");
        }
        private async void Pin022(object sender, EventArgs e)
        {
            await DisplayAlert("21va Parada", "El bus llega en aproximadamente 13 minutos", "Ok");
        }
        private async void Pin023(object sender, EventArgs e)
        {
            await DisplayAlert("22va Parada", "El bus llega en aproximadamente 14 minutos", "Ok");
        }
        private async void Pin024(object sender, EventArgs e)
        {
            await DisplayAlert("23va Parada", "El bus llega en aproximadamente 14 minutos", "Ok");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            bool mientras = true;
            while (mientras)
            {
                var location = Geolocation.GetLastKnownLocationAsync().Result;

                if (location != null)
                {
                    Pin usuario = new Pin()
                    {
                        Position = new Position(location.Latitude, location.Longitude),
                        Label = "Mi Ubicacion",
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("person.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "person.png", WidthRequest = 50, HeightRequest = 50 }),
                        Type = PinType.Generic
                    };
                    mapa.Pins.Add(usuario);

                    usuario.IsVisible = true;

                    foreach (var bus in mapa.Pins)
                    {
                        bus.IsVisible = true;
                        await Task.Delay(750);
                        bus.IsVisible = false;
                        await Task.Delay(750);
                    }
                    usuario.IsVisible = false;
                }
                else
                {
                    mientras = false;
                    await DisplayAlert("Alerta", "Active su ubicacion", "Ok");
                }
            }
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            if (mapa.Pins[0].IsVisible == true)
            {
                mapa.Pins[0].IsVisible = false;
                mapa.Pins[4].IsVisible = false;
                mapa.Pins[7].IsVisible = false;
                mapa.Pins[11].IsVisible = false;
                mapa.Pins[14].IsVisible = false;
                mapa.Pins[19].IsVisible = false;
                mapa.Pins[23].IsVisible = false;
                mapa.Pins[25].IsVisible = false;
                mapa.Pins[29].IsVisible = false;
                mapa.Pins[31].IsVisible = false;
                mapa.Pins[34].IsVisible = false;
                mapa.Pins[37].IsVisible = false;
                mapa.Pins[42].IsVisible = false;
                mapa.Pins[46].IsVisible = false;
                mapa.Pins[51].IsVisible = false;
                mapa.Pins[53].IsVisible = false;
                mapa.Pins[55].IsVisible = false;
                mapa.Pins[60].IsVisible = false;
                mapa.Pins[62].IsVisible = false;
                mapa.Pins[64].IsVisible = false;
                mapa.Pins[67].IsVisible = false;
                mapa.Pins[69].IsVisible = false;
                mapa.Pins[74].IsVisible = false;
                mapa.Pins[79].IsVisible = false;
            }
            else
            {
                mapa.Pins[0].IsVisible = true;
                mapa.Pins[4].IsVisible = true;
                mapa.Pins[7].IsVisible = true;
                mapa.Pins[11].IsVisible = true;
                mapa.Pins[14].IsVisible = true;
                mapa.Pins[19].IsVisible = true;
                mapa.Pins[23].IsVisible = true;
                mapa.Pins[25].IsVisible = true;
                mapa.Pins[29].IsVisible = true;
                mapa.Pins[31].IsVisible = true;
                mapa.Pins[34].IsVisible = true;
                mapa.Pins[37].IsVisible = true;
                mapa.Pins[42].IsVisible = true;
                mapa.Pins[46].IsVisible = true;
                mapa.Pins[51].IsVisible = true;
                mapa.Pins[53].IsVisible = true;
                mapa.Pins[55].IsVisible = true;
                mapa.Pins[60].IsVisible = true;
                mapa.Pins[62].IsVisible = true;
                mapa.Pins[64].IsVisible = true;
                mapa.Pins[67].IsVisible = true;
                mapa.Pins[69].IsVisible = true;
                mapa.Pins[74].IsVisible = true;
                mapa.Pins[79].IsVisible = true;
            }
        }
    }
}