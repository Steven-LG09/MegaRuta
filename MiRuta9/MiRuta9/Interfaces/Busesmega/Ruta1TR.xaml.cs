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
using Xamarin.Forms.Xaml;

namespace MiRuta9.Interfaces.Busesmega
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ruta1TR : ContentPage
    {
        public Ruta1TR()
        {
            InitializeComponent();

            Pin IntDos = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Dosquebradas",
                IsVisible = false,
                Address = "Salida Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835786, -75.668316),
            };
            mapa.Pins.Add(IntDos);
            IntDos.Clicked += PinUno;

            Pin pin01 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835786, -75.668316),
            };
            mapa.Pins.Add(pin01);

            Pin pin1 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836092, -75.668585),
            };
            mapa.Pins.Add(pin1);

            Pin pin2 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.836599, -75.669380),
            };
            mapa.Pins.Add(pin2);

            Pin pin3 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835959, -75.670084),
            };
            mapa.Pins.Add(pin3);

            Pin pin4 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835069, -75.670921),
            };
            mapa.Pins.Add(pin4);

            Pin pin5 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834819, -75.671359),
            };
            mapa.Pins.Add(pin5);

            Pin pin6 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.834734, -75.671456),
            };
            mapa.Pins.Add(pin6);

            Pin pin7 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833695, -75.672419),
            };
            mapa.Pins.Add(pin7);

            Pin pin8 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833431, -75.672907),
            };
            mapa.Pins.Add(pin8);

            Pin Pparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Cam",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833382, -75.672917),
            };
            mapa.Pins.Add(Pparada);
            Pparada.Clicked += PinDos;

            Pin pin02 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833382, -75.672917),
            };
            mapa.Pins.Add(pin02);

            Pin pin9 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833406, -75.672960),
            };
            mapa.Pins.Add(pin9);

            Pin pin10 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.833125, -75.673478),
            };
            mapa.Pins.Add(pin10);

            Pin pin11 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.832712, -75.674268),
            };
            mapa.Pins.Add(pin11);

            Pin pin12 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.832063, -75.675451),
            };
            mapa.Pins.Add(pin12);

            Pin pin13 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.831340, -75.676518),
            };
            mapa.Pins.Add(pin13);

            Pin pin14 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.831224, -75.676765),
            };
            mapa.Pins.Add(pin14);

            Pin Sparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Fundadores",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.831161, -75.676785),
            };
            mapa.Pins.Add(Sparada);
            Sparada.Clicked += PinTres;

            Pin pin03 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.831161, -75.676785),
            };
            mapa.Pins.Add(pin03);

            Pin pin15 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.831181, -75.676832),
            };
            mapa.Pins.Add(pin15);

            Pin pin16 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.830568, -75.677992),
            };
            mapa.Pins.Add(pin16);

            Pin pin17 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.830518, -75.678067),
            };
            mapa.Pins.Add(pin17);

            Pin pin18 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.829325, -75.679523),
            };
            mapa.Pins.Add(pin18);

            Pin Tparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Milan",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.829263, -75.679537),
            };
            mapa.Pins.Add(Tparada);
            Tparada.Clicked += PinCuatro;

            Pin pin04 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.829263, -75.679537),
            };
            mapa.Pins.Add(pin04);

            Pin pin19 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.829265, -75.679601),
            };
            mapa.Pins.Add(pin19);

            Pin pin20 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.828803, -75.680161),
            };
            mapa.Pins.Add(pin20);

            Pin pin21 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.828548, -75.680400),
            };
            mapa.Pins.Add(pin21);

            Pin pin22 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.827960, -75.680821),
            };
            mapa.Pins.Add(pin22);

            Pin pin23 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.826544, -75.681706),
            };
            mapa.Pins.Add(pin23);

            Pin Cparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Santa Monica",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.826491, -75.681699),
            };
            mapa.Pins.Add(Cparada);
            Cparada.Clicked += PinCinco;

            Pin pin05 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.826491, -75.681699),
            };
            mapa.Pins.Add(pin05);

            Pin pin24 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.826455, -75.681768),
            };
            mapa.Pins.Add(pin24);

            Pin pin25 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.824315, -75.683113),
            };
            mapa.Pins.Add(pin25);

            Pin pin26 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.823898, -75.683327),
            };
            mapa.Pins.Add(pin26);

            Pin pin27 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.823658, -75.683431),
            };
            mapa.Pins.Add(pin27);

            Pin pin28 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.823085, -75.683651),
            };
            mapa.Pins.Add(pin28);

            Pin Qparada = new Pin()
            {
                Type = PinType.Place,
                Label = "La Popa",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.822999, -75.683641),
            };
            mapa.Pins.Add(Qparada);
            Qparada.Clicked += PinSeis;

            Pin pin06 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.822999, -75.683641),
            };
            mapa.Pins.Add(pin06);

            Pin pin29 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.822974, -75.683692),
            };
            mapa.Pins.Add(pin29);

            Pin pin30 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.822262, -75.683968),
            };
            mapa.Pins.Add(pin30);

            Pin pin31 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.822054, -75.684135),
            };
            mapa.Pins.Add(pin31);

            Pin pin32 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.821682, -75.684691),
            };
            mapa.Pins.Add(pin32);

            Pin pin33 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.821460, -75.684837),
            };
            mapa.Pins.Add(pin33);

            Pin pin34 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.818893, -75.685723),
            };
            mapa.Pins.Add(pin34);

            Pin pin35 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.818378, -75.685805),
            };
            mapa.Pins.Add(pin35);

            Pin pin36 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.817346, -75.686145),
            };
            mapa.Pins.Add(pin36);

            Pin pin37 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815872, -75.686708),
            };
            mapa.Pins.Add(pin37);

            Pin pin38 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815355, -75.686936),
            };
            mapa.Pins.Add(pin38);

            Pin pin39 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813673, -75.687528),
            };
            mapa.Pins.Add(pin39);

            Pin pin40 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812909, -75.687632),
            };
            mapa.Pins.Add(pin40);

            Pin SEparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Villavicencio",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.812829, -75.687603),
            };
            mapa.Pins.Add(SEparada);
            SEparada.Clicked += PinSiete;

            Pin pin07 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812829, -75.687603),
            };
            mapa.Pins.Add(pin07);

            Pin pin41 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812787, -75.687644),
            };
            mapa.Pins.Add(pin41);

            Pin pin42 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812443, -75.687676),
            };
            mapa.Pins.Add(pin42);

            Pin pin43 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812108, -75.687801),
            };
            mapa.Pins.Add(pin43);

            Pin pin44 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810854, -75.688707),
            };
            mapa.Pins.Add(pin44);

            Pin Separada = new Pin()
            {
                Type = PinType.Place,
                Label = "Ferrocarril",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.810750, -75.688729),
            };
            mapa.Pins.Add(Separada);
            Separada.Clicked += PinOcho;

            Pin pin08 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810750, -75.688729),
            };
            mapa.Pins.Add(pin08);

            Pin pin45 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810736, -75.688792),
            };
            mapa.Pins.Add(pin45);

            Pin pin46 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810070, -75.689272),
            };
            mapa.Pins.Add(pin46);

            Pin pin47 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809830, -75.689628),
            };
            mapa.Pins.Add(pin47);

            Pin pin48 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809747, -75.689952),
            };
            mapa.Pins.Add(pin48);

            Pin pin49 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809780, -75.690358),
            };
            mapa.Pins.Add(pin49);

            Pin pin50 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810351, -75.691505),
            };
            mapa.Pins.Add(pin50);

            Pin pin51 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810412, -75.691803),
            };
            mapa.Pins.Add(pin51);

            Pin pin52 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810356, -75.692118),
            };
            mapa.Pins.Add(pin52);

            Pin pin53 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810189, -75.692374),
            };
            mapa.Pins.Add(pin53);

            Pin pin54 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809936, -75.692564),
            };
            mapa.Pins.Add(pin54);

            Pin pin55 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809795, -75.692646),
            };
            mapa.Pins.Add(pin55);

            Pin pin56 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809435, -75.692993),
            };
            mapa.Pins.Add(pin56);

            Pin pin57 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809481, -75.693858),
            };
            mapa.Pins.Add(pin57);

            Pin pin58 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809448, -75.694011),
            };
            mapa.Pins.Add(pin58);

            Pin pin59 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809627, -75.695604),
            };
            mapa.Pins.Add(pin59);

            Pin Oparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Parque Olaya",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.809592, -75.695676),
            };
            mapa.Pins.Add(Oparada);
            Oparada.Clicked += PinNueve;

            Pin pin09 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809592, -75.695676),
            };
            mapa.Pins.Add(pin09);

            Pin pin60 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809644, -75.695741),
            };
            mapa.Pins.Add(pin60);

            Pin pin61 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809828, -75.697262),
            };
            mapa.Pins.Add(pin61);

            Pin pin62 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809880, -75.697464),
            };
            mapa.Pins.Add(pin62);

            Pin pin63 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810167, -75.698328),
            };
            mapa.Pins.Add(pin63);

            Pin pin64 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810213, -75.698565),
            };
            mapa.Pins.Add(pin64);

            Pin pin65 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810258, -75.699806),
            };
            mapa.Pins.Add(pin65);

            Pin pin66 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810586, -75.701785),
            };
            mapa.Pins.Add(pin66);

            Pin Nparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Centenario",
                IsVisible = false,  
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.810550, -75.701872),
            };
            mapa.Pins.Add(Nparada);
            Nparada.Clicked += PinDiez;

            Pin pin010 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810550, -75.701872),
            };
            mapa.Pins.Add(pin010);

            Pin pin67 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810614, -75.701957),
            };
            mapa.Pins.Add(pin67);

            Pin pin68 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810782, -75.702963),
            };
            mapa.Pins.Add(pin68);

            Pin pin69 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810908, -75.703302),
            };
            mapa.Pins.Add(pin69);

            Pin pin70 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811419, -75.704120),
            };
            mapa.Pins.Add(pin70);

            Pin Dparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Francisco Pereira",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.811429, -75.704211),
            };
            mapa.Pins.Add(Dparada);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(Dparada.Position, Distance.FromMeters(4200)));
            Dparada.Clicked += PinOnce;

            Pin pin011 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811429, -75.704211),
            };
            mapa.Pins.Add(pin011);

            Pin pin71 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811510, -75.704266),
            };
            mapa.Pins.Add(pin71);

            Pin pin72 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811659, -75.704510),
            };
            mapa.Pins.Add(pin72);

            Pin pin73 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811813, -75.704867),
            };
            mapa.Pins.Add(pin73);

            Pin pin74 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811915, -75.705335),
            };
            mapa.Pins.Add(pin74);

            Pin pin75 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811988, -75.706512),
            };
            mapa.Pins.Add(pin75);

            Pin pin76 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812042, -75.706946),
            };
            mapa.Pins.Add(pin76);

            Pin pin77 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812206, -75.707632),
            };
            mapa.Pins.Add(pin77);

            Pin oparada = new Pin()
            {
                Type = PinType.Place,
                Label = "El cafetero",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.812182, -75.707723),
            };
            mapa.Pins.Add(oparada);
            oparada.Clicked += PinDoce;

            Pin pin012 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812182, -75.707723),
            };
            mapa.Pins.Add(pin012);

            Pin pin78 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812254, -75.707806),
            };
            mapa.Pins.Add(pin78);

            Pin pin79 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812860, -75.710113),
            };
            mapa.Pins.Add(pin79);

            Pin dparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Consota",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.812835, -75.710206),
            };
            mapa.Pins.Add(dparada);
            dparada.Clicked += PinTrece;

            Pin pin013 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812835, -75.710206),
            };
            mapa.Pins.Add(pin013);

            Pin pin80 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812899, -75.710282),
            };
            mapa.Pins.Add(pin80);

            Pin pin81 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813069, -75.710904),
            };
            mapa.Pins.Add(pin81);

            Pin pin82 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813276, -75.712288),
            };
            mapa.Pins.Add(pin82);

            Pin pin83 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813391, -75.712690),
            };
            mapa.Pins.Add(pin83);

            Pin pin84 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813542, -75.713089),
            };
            mapa.Pins.Add(pin84);

            Pin pin85 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813808, -75.713572),
            };
            mapa.Pins.Add(pin85);

            Pin tparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Ukumari",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.813826, -75.713687),
            };
            mapa.Pins.Add(tparada);
            tparada.Clicked += PinCatorce;

            Pin pin014 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813826, -75.713687),
            };
            mapa.Pins.Add(pin014);

            Pin pin86 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813916, -75.713749),
            };
            mapa.Pins.Add(pin86);

            Pin pin87 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814562, -75.714793),
            };
            mapa.Pins.Add(pin87);

            Pin pin88 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814721, -75.715110),
            };
            mapa.Pins.Add(pin88);

            Pin pin89 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814781, -75.715325),
            };
            mapa.Pins.Add(pin89);

            Pin pin90 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814810, -75.715598),
            };
            mapa.Pins.Add(pin90);

            Pin cparada = new Pin()
            {
                Type = PinType.Place,
                Label = "El Jardin",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.814768, -75.715703),
            };
            mapa.Pins.Add(cparada);
            cparada.Clicked += PinQuince;

            Pin pin015 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814768, -75.715703),
            };
            mapa.Pins.Add(pin015);

            Pin pin91 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814817, -75.715790),
            };
            mapa.Pins.Add(pin91);

            Pin pin92 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814851, -75.716298),
            };
            mapa.Pins.Add(pin92);

            Pin pin93 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814923, -75.716575),
            };
            mapa.Pins.Add(pin93);

            Pin pin94 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815673, -75.717978),
            };
            mapa.Pins.Add(pin94);

            Pin pin95 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815976, -75.719254),
            };
            mapa.Pins.Add(pin95);

            Pin pin96 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.816048, -75.719816),
            };
            mapa.Pins.Add(pin96);

            Pin pin97 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.816052, -75.720044),
            };
            mapa.Pins.Add(pin97);

            Pin pin98 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.816017, -75.720658),
            };
            mapa.Pins.Add(pin98);

            Pin qparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Maraya",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.815959, -75.720766),
            };
            mapa.Pins.Add(qparada);
            qparada.Clicked += Pin0016;

            Pin pin016 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815959, -75.720766),
            };
            mapa.Pins.Add(pin016);

            Pin pin99 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.816004, -75.720872),
            };
            mapa.Pins.Add(pin99);

            Pin pin100 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815815, -75.724293),
            };
            mapa.Pins.Add(pin100);

            Pin dParada = new Pin()
            {
                Type = PinType.Place,
                Label = "Batallon",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.815761, -75.724378),
            };
            mapa.Pins.Add(dParada);
            dParada.Clicked += Pin0017;

            Pin pin017 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815761, -75.724378),
            };
            mapa.Pins.Add(pin017);

            Pin pin101 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815802, -75.724466),
            };
            mapa.Pins.Add(pin101);

            Pin pin102 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815748, -75.725413),
            };
            mapa.Pins.Add(pin102);

            Pin pin103 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815671, -75.726159),
            };
            mapa.Pins.Add(pin103);

            Pin pin104 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815610, -75.726578),
            };
            mapa.Pins.Add(pin104);

            Pin diparada = new Pin()
            {
                Type = PinType.Place,
                Label = "Aeropuerto",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.815548, -75.726668),
            };
            mapa.Pins.Add(diparada);
            diparada.Clicked += Pin0018;

            Pin pin018 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815548, -75.726668),
            };
            mapa.Pins.Add(pin018);

            Pin pin105 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815577, -75.726780),
            };
            mapa.Pins.Add(pin105);

            Pin pin106 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815473, -75.727517),
            };
            mapa.Pins.Add(pin106);

            Pin pin107 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815512, -75.727965),
            };
            mapa.Pins.Add(pin107);

            Pin pin108 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815495, -75.728171),
            };
            mapa.Pins.Add(pin108);

            Pin pin109 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815396, -75.728478),
            };
            mapa.Pins.Add(pin109);

            Pin pin110 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815387, -75.729056),
            };
            mapa.Pins.Add(pin110);

            Pin pin111 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815431, -75.729427),
            };
            mapa.Pins.Add(pin111);

            Pin pin112 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815385, -75.729680),
            };
            mapa.Pins.Add(pin112);

            Pin pin113 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.815242, -75.729976),
            };
            mapa.Pins.Add(pin113);

            Pin pin114 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814929, -75.730342),
            };
            mapa.Pins.Add(pin114);

            Pin pin115 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814673, -75.730731),
            };
            mapa.Pins.Add(pin115);

            Pin pin116 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.814010, -75.731609),
            };
            mapa.Pins.Add(pin116);

            Pin pin117 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813894, -75.731858),
            };
            mapa.Pins.Add(pin117);

            Pin pin118 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813694, -75.732499),
            };
            mapa.Pins.Add(pin118);

            Pin pin119 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813630, -75.732905),
            };
            mapa.Pins.Add(pin119);

            Pin pin120 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813434, -75.734025),
            };
            mapa.Pins.Add(pin120);

            Pin dioparada = new Pin()
            {
                Type = PinType.Place,
                Label = "El Viajero",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.813378, -75.734073),
            };
            mapa.Pins.Add(dioparada);
            dioparada.Clicked += Pin0019;

            Pin pin019 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813378, -75.734073),
            };
            mapa.Pins.Add(pin019);

            Pin pin121 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813413, -75.734161),
            };
            mapa.Pins.Add(pin121);

            Pin pin122 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813333, -75.734479),
            };
            mapa.Pins.Add(pin122);

            Pin pin139 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813280, -75.734533),
            };
            mapa.Pins.Add(pin139);

            Pin pin123 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813211, -75.734543),
            };
            mapa.Pins.Add(pin123);

            Pin pin140 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.813143, -75.734508),
            };
            mapa.Pins.Add(pin140);

            Pin pin124 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812996, -75.734215),
            };
            mapa.Pins.Add(pin124);

            Pin pin125 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812560, -75.734123),
            };
            mapa.Pins.Add(pin125);

            Pin pin126 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.812087, -75.734354),
            };
            mapa.Pins.Add(pin126);

            Pin pin127 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811966, -75.734358),
            };
            mapa.Pins.Add(pin127);

            Pin pin128 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811838, -75.734226),
            };
            mapa.Pins.Add(pin128);

            Pin pin129 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811721, -75.734014),
            };
            mapa.Pins.Add(pin129);

            Pin pin130 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811718, -75.733880),
            };
            mapa.Pins.Add(pin130);

            Pin pin131 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811840, -75.733560),
            };
            mapa.Pins.Add(pin131);

            Pin pin132 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811842, -75.733434),
            };
            mapa.Pins.Add(pin132);

            Pin pin133 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811762, -75.733300),
            };
            mapa.Pins.Add(pin133);

            Pin pin134 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811409, -75.733079),
            };
            mapa.Pins.Add(pin134);

            Pin pin135 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811336, -75.732931),
            };
            mapa.Pins.Add(pin135);

            Pin pin136 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811403, -75.732563),
            };
            mapa.Pins.Add(pin136);

            Pin pin137 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811370, -75.732415),
            };
            mapa.Pins.Add(pin137);

            Pin pin138 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811265, -75.732342),
            };
            mapa.Pins.Add(pin138);

            Pin pin141 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811131, -75.732315),
            };
            mapa.Pins.Add(pin141);

            Pin pin142 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810867, -75.732623),
            };
            mapa.Pins.Add(pin142);

            Pin pin143 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.810163, -75.733707),
            };
            mapa.Pins.Add(pin143);

            Pin pin144 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809766, -75.734261),
            };
            mapa.Pins.Add(pin144);

            Pin pin145 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809694, -75.734426),
            };
            mapa.Pins.Add(pin145);

            Pin pin146 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809626, -75.734893),
            };
            mapa.Pins.Add(pin146);

            Pin pin147 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809523, -75.735114),
            };
            mapa.Pins.Add(pin147);

            Pin pin148 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.809341, -75.735290),
            };
            mapa.Pins.Add(pin148);

            Pin pin149 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.808788, -75.735649),
            };
            mapa.Pins.Add(pin149);

            Pin dinparada = new Pin()
            {
                Type = PinType.Place,
                Label = "San Fernando",
                IsVisible = false,
                Address = "Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.808677, -75.735677),
            };
            mapa.Pins.Add(dinparada);
            dinparada.Clicked += Pin0020;

            Pin pin020 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.808677, -75.735677),
            };
            mapa.Pins.Add(pin020);

            Pin pin150 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.808671, -75.735726),
            };
            mapa.Pins.Add(pin150);

            Pin pin154 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.808209, -75.736006),
            };
            mapa.Pins.Add(pin154);

            Pin pin151 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.806834, -75.736925),
            };
            mapa.Pins.Add(pin151);

            Pin pin152 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.806737, -75.737013),
            };
            mapa.Pins.Add(pin152);

            Pin pin153 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.805114, -75.738725),
            };
            mapa.Pins.Add(pin153);

            Pin pin155 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.804676, -75.738743),
            };
            mapa.Pins.Add(pin155);

            Pin IntCuba = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Cuba",
                IsVisible = false,
                Address = "Llegada Click para ver el tiempo",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.804397, -75.739043),
            };
            mapa.Pins.Add(IntCuba);
            IntCuba.Clicked += Pin0021;

            Pin pin021 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.804397, -75.739043),
            };
            mapa.Pins.Add(pin021);

            Pin pin156 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804358, -75.739029),
            };
            mapa.Pins.Add(pin156);

            Pin pin157 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804326, -75.738991),
            };
            mapa.Pins.Add(pin157);

            Pin IntCuba2 = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Cuba",
                IsVisible = false,
                Address = "Salida",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.804328, -75.738920),
            };
            mapa.Pins.Add(IntCuba2);

            Polyline polyline = new Xamarin.Forms.GoogleMaps.Polyline()
            {
                StrokeColor = Color.Green,
                StrokeWidth = 3,
            };

            foreach (var pin in mapa.Pins)
            {
                polyline.Positions.Add(pin.Position);
            }
            mapa.Polylines.Add(polyline);

            Pin pin158 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804839, -75.738444),
            };
            mapa.Pins.Add(pin158);

            Pin pin159 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804892, -75.738451),
            };
            mapa.Pins.Add(pin159);

            Pin pin160 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.805133, -75.738648),
            };
            mapa.Pins.Add(pin160);

            Pin pin161 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.806833, -75.736875),
            };
            mapa.Pins.Add(pin161);

            Pin pin162 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808623, -75.735678),
            };
            mapa.Pins.Add(pin162);

            Pin pin163 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808730, -75.735604),
            };
            mapa.Pins.Add(pin163);

            Pin pin164 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809324, -75.735271),
            };
            mapa.Pins.Add(pin164);

            Pin pin165 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809524, -75.735060),
            };
            mapa.Pins.Add(pin165);

            Pin pin166 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809607, -75.734858),
            };
            mapa.Pins.Add(pin166);

            Pin pin167 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809651, -75.734479),
            };
            mapa.Pins.Add(pin167);

            Pin pin168 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809749, -75.734231),
            };
            mapa.Pins.Add(pin168);

            Pin pin173 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810150, -75.733671),
            };
            mapa.Pins.Add(pin173);


            Pin pin169 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810849, -75.732595),
            };
            mapa.Pins.Add(pin169);

            Pin pin170 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811214, -75.732144),
            };
            mapa.Pins.Add(pin170);

            Pin pin171 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811296, -75.732131),
            };
            mapa.Pins.Add(pin171);

            Pin pin172 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811442, -75.732233),
            };
            mapa.Pins.Add(pin172);

            Pin pin174 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811509, -75.732406),
            };
            mapa.Pins.Add(pin174);

            Pin pin175 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811382, -75.732917),
            };
            mapa.Pins.Add(pin175);

            Pin pin176 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811437, -75.733055),
            };
            mapa.Pins.Add(pin176);

            Pin pin177 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811818, -75.733286),
            };
            mapa.Pins.Add(pin177);

            Pin pin191 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811879, -75.733404),
            };
            mapa.Pins.Add(pin191);

            Pin pin178 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811881, -75.733493),
            };
            mapa.Pins.Add(pin178);

            Pin pin179 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811855, -75.733635),
            };
            mapa.Pins.Add(pin179);

            Pin pin180 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811758, -75.733906),
            };
            mapa.Pins.Add(pin180);

            Pin pin181 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811776, -75.734063),
            };
            mapa.Pins.Add(pin181);

            Pin pin182 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811986, -75.734317),
            };
            mapa.Pins.Add(pin182);

            Pin pin183 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812098, -75.734308),
            };
            mapa.Pins.Add(pin183);

            Pin pin184 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812550, -75.734100),
            };
            mapa.Pins.Add(pin184);

            Pin pin185 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812998, -75.733666),
            };
            mapa.Pins.Add(pin185);

            Pin pin186 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813078, -75.733622),
            };
            mapa.Pins.Add(pin186);

            Pin pin187 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813320, -75.733575),
            };
            mapa.Pins.Add(pin187);

            Pin pin188 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813448, -75.733605),
            };
            mapa.Pins.Add(pin188);

            Pin pin189 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813477, -75.733685),
            };
            mapa.Pins.Add(pin189);

            Pin pin190 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813436, -75.734018),
            };
            mapa.Pins.Add(pin190);

            Pin pin192 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813413, -75.734161),
            };
            mapa.Pins.Add(pin192);

            Pin pin193 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813333, -75.734479),
            };
            mapa.Pins.Add(pin193);

            Pin pin194 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813280, -75.734533),
            };
            mapa.Pins.Add(pin194);

            Pin pin195 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813211, -75.734543),
            };
            mapa.Pins.Add(pin195);

            Pin pin196 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813143, -75.734508),
            };
            mapa.Pins.Add(pin196);

            Pin pin197 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813149, -75.734038),
            };
            mapa.Pins.Add(pin197);

            Pin pin198 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813199, -75.733874),
            };
            mapa.Pins.Add(pin198);

            Pin pin199 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813443, -75.733428),
            };
            mapa.Pins.Add(pin199);

            Pin pin200 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813672, -75.732323),
            };
            mapa.Pins.Add(pin200);

            Pin pin201 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813842, -75.731788),
            };
            mapa.Pins.Add(pin201);

            Pin pin202 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814056, -75.731409),
            };
            mapa.Pins.Add(pin202);

            Pin pin203 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814636, -75.730691),
            };
            mapa.Pins.Add(pin203);

            Pin pin204 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814981, -75.730194),
            };
            mapa.Pins.Add(pin204);

            Pin pin205 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815200, -75.729933),
            };
            mapa.Pins.Add(pin205);

            Pin pin206 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815305, -75.729721),
            };
            mapa.Pins.Add(pin206);

            Pin pin207 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815364, -75.729493),
            };
            mapa.Pins.Add(pin207);

            Pin pin208 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815350, -75.729175),
            };
            mapa.Pins.Add(pin208);

            Pin pin209 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815220, -75.728352),
            };
            mapa.Pins.Add(pin209);

            Pin pin210 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815232, -75.728195),
            };
            mapa.Pins.Add(pin210);

            Pin pin211 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815423, -75.727489),
            };
            mapa.Pins.Add(pin211);

            Pin pin212 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815687, -75.725458),
            };
            mapa.Pins.Add(pin212);

            Pin pin213 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815845, -75.722586),
            };
            mapa.Pins.Add(pin213);

            Pin pin214 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815931, -75.720847),
            };
            mapa.Pins.Add(pin214);

            Pin pin215 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815948, -75.720648),
            };
            mapa.Pins.Add(pin215);

            Pin pin216 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815992, -75.719870),
            };
            mapa.Pins.Add(pin216);

            Pin pin217 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815927, -75.719237),
            };
            mapa.Pins.Add(pin217);

            Pin pin218 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815671, -75.718137),
            };
            mapa.Pins.Add(pin218);

            Pin pin219 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815543, -75.717813),
            };
            mapa.Pins.Add(pin219);

            Pin pin220 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814914, -75.716710),
            };
            mapa.Pins.Add(pin220);

            Pin pin221 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814831, -75.716500),
            };
            mapa.Pins.Add(pin221);

            Pin pin222 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814777, -75.716226),
            };
            mapa.Pins.Add(pin222);

            Pin pin223 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814667, -75.715178),
            };
            mapa.Pins.Add(pin223);

            Pin pin224 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814558, -75.714925),
            };
            mapa.Pins.Add(pin224);

            Pin pin225 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814558, -75.714925),
            };
            mapa.Pins.Add(pin225);

            Pin pin226 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813869, -75.713803),
            };
            mapa.Pins.Add(pin226);

            Pin pin227 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813660, -75.713452),
            };
            mapa.Pins.Add(pin227);

            Pin pin228 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813381, -75.712840),
            };
            mapa.Pins.Add(pin228);

            Pin pin229 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813269, -75.712530),
            };
            mapa.Pins.Add(pin229);

            Pin pin230 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813005, -75.710925),
            };
            mapa.Pins.Add(pin230);

            Pin pin231 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812840, -75.710321),
            };
            mapa.Pins.Add(pin231);

            Pin pin232 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812779, -75.710078),
            };
            mapa.Pins.Add(pin232);

            Pin pin233 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812195, -75.707849),
            };
            mapa.Pins.Add(pin233);

            Pin pin234 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812128, -75.707606),
            };
            mapa.Pins.Add(pin234);

            Pin pin239 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811977, -75.706974),
            };
            mapa.Pins.Add(pin239);

            Pin pin235 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811849, -75.705345),
            };
            mapa.Pins.Add(pin235);

            Pin pin236 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811775, -75.704969),
            };
            mapa.Pins.Add(pin236);

            Pin pin237 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811654, -75.704642),
            };
            mapa.Pins.Add(pin237);

            Pin pin238 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811472, -75.704327),
            };
            mapa.Pins.Add(pin238);

            Pin pin240 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811342, -75.704120),
            };
            mapa.Pins.Add(pin240);

            Pin pin241 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810890, -75.703405),
            };
            mapa.Pins.Add(pin241);

            Pin pin242 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810776, -75.703155),
            };
            mapa.Pins.Add(pin242);

            Pin pin243 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810694, -75.702878),
            };
            mapa.Pins.Add(pin243);

            Pin pin244 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810554, -75.701993),
            };
            mapa.Pins.Add(pin244);

            Pin pin245 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810512, -75.701741),
            };
            mapa.Pins.Add(pin245);

            Pin pin246 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810218, -75.699906),
            };
            mapa.Pins.Add(pin246);

            Pin pin247 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810173, -75.698692),
            };
            mapa.Pins.Add(pin247);

            Pin pin248 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810144, -75.698474),
            };
            mapa.Pins.Add(pin248);

            Pin pin249 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810029, -75.698214),
            };
            mapa.Pins.Add(pin249);

            Pin pin250 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809843, -75.698008),
            };
            mapa.Pins.Add(pin250);

            Pin pin251 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809061, -75.697523),
            };
            mapa.Pins.Add(pin251);

            Pin pin252 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808924, -75.697377),
            };
            mapa.Pins.Add(pin252);

            Pin pin253 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808841, -75.697179),
            };
            mapa.Pins.Add(pin253);

            Pin pin254 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808791, -75.696930),
            };
            mapa.Pins.Add(pin254);

            Pin pin255 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808665, -75.695895),
            };
            mapa.Pins.Add(pin255);

            Pin Condina = new Pin()
            {
                Type = PinType.Place,
                Label = "Condina",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.808669, -75.695749),
            };
            mapa.Pins.Add(Condina);
            Condina.Clicked += PinVeinte;

            Pin pin256 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808640, -75.695671),
            };
            mapa.Pins.Add(pin256);

            Pin pin257 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808422, -75.693819),
            };
            mapa.Pins.Add(pin257);

            Pin pin258 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808452, -75.693556),
            };
            mapa.Pins.Add(pin258);

            Pin pin259 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808543, -75.693345),
            };
            mapa.Pins.Add(pin256);

            Pin pin260 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808735, -75.693140),
            };
            mapa.Pins.Add(pin260);

            Pin pin261 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809819, -75.692568),
            };
            mapa.Pins.Add(pin261);

            Pin pin262 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810075, -75.692400),
            };
            mapa.Pins.Add(pin262);

            Pin pin263 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810196, -75.692263),
            };
            mapa.Pins.Add(pin263);

            Pin pin264 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810284, -75.692113),
            };
            mapa.Pins.Add(pin264);

            Pin pin265 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810325, -75.691937),
            };
            mapa.Pins.Add(pin265);

            Pin pin266 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810329, -75.691712),
            };
            mapa.Pins.Add(pin266);

            Pin pin267 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810287, -75.691538),
            };
            mapa.Pins.Add(pin267);

            Pin pin268 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809740, -75.690421),
            };
            mapa.Pins.Add(pin268);

            Pin pin269 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809694, -75.690246),
            };
            mapa.Pins.Add(pin269);

            Pin pin270 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809684, -75.690010),
            };
            mapa.Pins.Add(pin270);

            Pin pin271 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809729, -75.689736),
            };
            mapa.Pins.Add(pin271);

            Pin pin272 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809832, -75.689487),
            };
            mapa.Pins.Add(pin272);

            Pin pin273 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809991, -75.689281),
            };
            mapa.Pins.Add(pin273);

            Pin pin274 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810663, -75.688754),
            };
            mapa.Pins.Add(pin274);

            Pin pin275 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810850, -75.688628),
            };
            mapa.Pins.Add(pin275);

            Pin pin276 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812024, -75.687793),
            };
            mapa.Pins.Add(pin276);

            Pin pin277 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812196, -75.687698),
            };
            mapa.Pins.Add(pin277);

            Pin pin278 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812345, -75.687643),
            };
            mapa.Pins.Add(pin278);

            Pin pin279 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812757, -75.687583),
            };
            mapa.Pins.Add(pin279);

            Pin pin280 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812939, -75.687565),
            };
            mapa.Pins.Add(pin280);

            Pin pin281 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813688, -75.687467),
            };
            mapa.Pins.Add(pin281);

            Pin pin282 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815386, -75.686883),
            };
            mapa.Pins.Add(pin282);

            Pin pin291 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.817116, -75.686178),
            };
            mapa.Pins.Add(pin291);

            Pin pin283 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.818394, -75.685750),
            };
            mapa.Pins.Add(pin283);

            Pin pin284 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.818845, -75.685698),
            };
            mapa.Pins.Add(pin284);

            Pin pin285 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821203, -75.684867),
            };
            mapa.Pins.Add(pin285);

            Pin pin286 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821532, -75.684522),
            };
            mapa.Pins.Add(pin286);

            Pin pin287 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821943, -75.684105),
            };
            mapa.Pins.Add(pin287);

            Pin pin288 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822054, -75.684010),
            };
            mapa.Pins.Add(pin288);

            Pin pin289 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822253, -75.683900),
            };
            mapa.Pins.Add(pin289);

            Pin pin290 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822885, -75.683661),
            };
            mapa.Pins.Add(pin290);

            Pin pin292 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.823118, -75.683574),
            };
            mapa.Pins.Add(pin292);

            Pin pin293 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.823686, -75.683359),
            };
            mapa.Pins.Add(pin293);

            Pin pin294 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.824258, -75.683078),
            };
            mapa.Pins.Add(pin294);

            Pin pin295 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.826375, -75.681737),
            };
            mapa.Pins.Add(pin295);

            Pin pin296 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.826594, -75.681603),
            };
            mapa.Pins.Add(pin296);

            Pin pin297 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828255, -75.680558),
            };
            mapa.Pins.Add(pin297);

            Pin pin298 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828549, -75.680316),
            };
            mapa.Pins.Add(pin298);

            Pin pin299 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828786, -75.680088),
            };
            mapa.Pins.Add(pin299);

            Pin pin300 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.829201, -75.679581),
            };
            mapa.Pins.Add(pin300);

            Pin pin301 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.829328, -75.679426),
            };
            mapa.Pins.Add(pin301);

            Pin pin302 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830045, -75.678574),
            };
            mapa.Pins.Add(pin302);

            Pin pin303 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830478, -75.678025),
            };
            mapa.Pins.Add(pin303);

            Pin pin304 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830662, -75.677697),
            };
            mapa.Pins.Add(pin304);

            Pin pin305 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831085, -75.676875),
            };
            mapa.Pins.Add(pin305);

            Pin pin306 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831209, -75.676656),
            };
            mapa.Pins.Add(pin306);

            Pin pin307 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831348, -75.676394),
            };
            mapa.Pins.Add(pin307);

            Pin pin308 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831948, -75.675524),
            };
            mapa.Pins.Add(pin308);

            Pin pin309 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.832059, -75.675335),
            };
            mapa.Pins.Add(pin309);

            Pin pin310 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.832686, -75.674187),
            };
            mapa.Pins.Add(pin310);

            Pin pin311 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833304, -75.673012),
            };
            mapa.Pins.Add(pin311);

            Pin pin312 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833424, -75.672783),
            };
            mapa.Pins.Add(pin312);

            Pin pin313 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833880, -75.671972),
            };
            mapa.Pins.Add(pin313);

            Pin pin314 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834110, -75.671711),
            };
            mapa.Pins.Add(pin314);

            Pin pin315 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835021, -75.670879),
            };
            mapa.Pins.Add(pin315);

            Pin pin323 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836025, -75.669951),
            };
            mapa.Pins.Add(pin323);

            Pin pin316 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836225, -75.669730),
            };
            mapa.Pins.Add(pin316);

            Pin pin317 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836535, -75.669388),
            };
            mapa.Pins.Add(pin317);

            Pin pin318 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836527, -75.669325),
            };
            mapa.Pins.Add(pin318);

            Pin pin319 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836118, -75.668679),
            };
            mapa.Pins.Add(pin319);

            Pin pin320 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835990, -75.668613),
            };
            mapa.Pins.Add(pin320);

            Pin pin321 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835858, -75.668646),
            };
            mapa.Pins.Add(pin321);

            Pin pin322 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835631, -75.668685),
            };
            mapa.Pins.Add(pin322);

            Pin IntDos2 = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Dosquebradas",
                IsVisible = false,
                Address = "Llegada",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835383, -75.668367),
            };
            mapa.Pins.Add(IntDos2);

            Pin pin324 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835071, -75.667941),
            };
            mapa.Pins.Add(pin324);

            Pin pin325 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835091, -75.667875),
            };
            mapa.Pins.Add(pin325);

            Pin pin326 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835312, -75.667726),
            };
            mapa.Pins.Add(pin326);

            Pin pin327 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835380, -75.667755),
            };
            mapa.Pins.Add(pin327);

            Polyline polyline2 = new Xamarin.Forms.GoogleMaps.Polyline()
            {
                StrokeColor = Color.IndianRed,
                StrokeWidth = 3,
            };
            polyline2.Positions.Add((IntCuba2.Position));
            polyline2.Positions.Add(pin158.Position);
            polyline2.Positions.Add(pin159.Position);
            polyline2.Positions.Add(pin160.Position);
            polyline2.Positions.Add(pin161.Position);
            polyline2.Positions.Add(pin162.Position);
            polyline2.Positions.Add(dinparada.Position);
            polyline2.Positions.Add(pin163.Position);
            polyline2.Positions.Add(pin164.Position);
            polyline2.Positions.Add(pin165.Position);
            polyline2.Positions.Add(pin166.Position);
            polyline2.Positions.Add(pin167.Position);
            polyline2.Positions.Add(pin168.Position);
            polyline2.Positions.Add(pin173.Position);
            polyline2.Positions.Add(pin169.Position);
            polyline2.Positions.Add(pin170.Position);
            polyline2.Positions.Add(pin171.Position);
            polyline2.Positions.Add(pin172.Position);
            polyline2.Positions.Add(pin174.Position);
            polyline2.Positions.Add(pin175.Position);
            polyline2.Positions.Add(pin176.Position);
            polyline2.Positions.Add(pin177.Position);
            polyline2.Positions.Add(pin191.Position);
            polyline2.Positions.Add(pin178.Position);
            polyline2.Positions.Add(pin179.Position);
            polyline2.Positions.Add(pin180.Position);
            polyline2.Positions.Add(pin181.Position);
            polyline2.Positions.Add(pin182.Position);
            polyline2.Positions.Add(pin183.Position);
            polyline2.Positions.Add(pin184.Position);
            polyline2.Positions.Add(pin185.Position);
            polyline2.Positions.Add(pin186.Position);
            polyline2.Positions.Add(pin187.Position);
            polyline2.Positions.Add(pin188.Position);
            polyline2.Positions.Add(pin189.Position);
            polyline2.Positions.Add(pin190.Position);
            polyline2.Positions.Add(dioparada.Position);
            polyline2.Positions.Add(pin192.Position);
            polyline2.Positions.Add(pin193.Position);
            polyline2.Positions.Add(pin194.Position);
            polyline2.Positions.Add(pin195.Position);
            polyline2.Positions.Add(pin196.Position);
            polyline2.Positions.Add(pin197.Position);
            polyline2.Positions.Add(pin198.Position);
            polyline2.Positions.Add(pin199.Position);
            polyline2.Positions.Add(pin200.Position);
            polyline2.Positions.Add(pin201.Position);
            polyline2.Positions.Add(pin202.Position);
            polyline2.Positions.Add(pin203.Position);
            polyline2.Positions.Add(pin204.Position);
            polyline2.Positions.Add(pin205.Position);
            polyline2.Positions.Add(pin206.Position);
            polyline2.Positions.Add(pin207.Position);
            polyline2.Positions.Add(pin208.Position);
            polyline2.Positions.Add(pin209.Position);
            polyline2.Positions.Add(pin210.Position);
            polyline2.Positions.Add(pin211.Position);
            polyline2.Positions.Add(diparada.Position);
            polyline2.Positions.Add(pin212.Position);
            polyline2.Positions.Add(dParada.Position);
            polyline2.Positions.Add(pin213.Position);
            polyline2.Positions.Add(pin214.Position);
            polyline2.Positions.Add(qparada.Position);
            polyline2.Positions.Add(pin215.Position);
            polyline2.Positions.Add(pin216.Position);
            polyline2.Positions.Add(pin217.Position);
            polyline2.Positions.Add(pin218.Position);
            polyline2.Positions.Add(pin219.Position);
            polyline2.Positions.Add(pin220.Position);
            polyline2.Positions.Add(pin221.Position);
            polyline2.Positions.Add(pin222.Position);
            polyline2.Positions.Add(cparada.Position);
            polyline2.Positions.Add(pin223.Position);
            polyline2.Positions.Add(pin224.Position);
            polyline2.Positions.Add(pin225.Position);
            polyline2.Positions.Add(pin226.Position);
            polyline2.Positions.Add(tparada.Position);
            polyline2.Positions.Add(pin227.Position);
            polyline2.Positions.Add(pin228.Position);
            polyline2.Positions.Add(pin229.Position);
            polyline2.Positions.Add(pin230.Position);
            polyline2.Positions.Add(pin231.Position);
            polyline2.Positions.Add(dparada.Position);
            polyline2.Positions.Add(pin232.Position);
            polyline2.Positions.Add(pin233.Position);
            polyline2.Positions.Add(oparada.Position);
            polyline2.Positions.Add(pin234.Position);
            polyline2.Positions.Add(pin239.Position);
            polyline2.Positions.Add(pin235.Position);
            polyline2.Positions.Add(pin236.Position);
            polyline2.Positions.Add(pin237.Position);
            polyline2.Positions.Add(pin238.Position);
            polyline2.Positions.Add(Dparada.Position);
            polyline2.Positions.Add(pin240.Position);
            polyline2.Positions.Add(pin241.Position);
            polyline2.Positions.Add(pin242.Position);
            polyline2.Positions.Add(pin243.Position);
            polyline2.Positions.Add(pin244.Position);
            polyline2.Positions.Add(Nparada.Position);
            polyline2.Positions.Add(pin245.Position);
            polyline2.Positions.Add(pin246.Position);
            polyline2.Positions.Add(pin247.Position);
            polyline2.Positions.Add(pin248.Position);
            polyline2.Positions.Add(pin249.Position);
            polyline2.Positions.Add(pin250.Position);
            polyline2.Positions.Add(pin251.Position);
            polyline2.Positions.Add(pin252.Position);
            polyline2.Positions.Add(pin253.Position);
            polyline2.Positions.Add(pin254.Position);
            polyline2.Positions.Add(pin255.Position);
            polyline2.Positions.Add(Condina.Position);
            polyline2.Positions.Add(pin256.Position);
            polyline2.Positions.Add(pin257.Position);
            polyline2.Positions.Add(pin258.Position);
            polyline2.Positions.Add(pin259.Position);
            polyline2.Positions.Add(pin260.Position);
            polyline2.Positions.Add(pin261.Position);
            polyline2.Positions.Add(pin262.Position);
            polyline2.Positions.Add(pin263.Position);
            polyline2.Positions.Add(pin264.Position);
            polyline2.Positions.Add(pin265.Position);
            polyline2.Positions.Add(pin266.Position);
            polyline2.Positions.Add(pin267.Position);
            polyline2.Positions.Add(pin268.Position);
            polyline2.Positions.Add(pin269.Position);
            polyline2.Positions.Add(pin270.Position);
            polyline2.Positions.Add(pin271.Position);
            polyline2.Positions.Add(pin272.Position);
            polyline2.Positions.Add(pin273.Position);
            polyline2.Positions.Add(pin274.Position);
            polyline2.Positions.Add(Separada.Position);
            polyline2.Positions.Add(pin275.Position);
            polyline2.Positions.Add(pin276.Position);
            polyline2.Positions.Add(pin277.Position);
            polyline2.Positions.Add(pin278.Position);
            polyline2.Positions.Add(pin279.Position);
            polyline2.Positions.Add(SEparada.Position);
            polyline2.Positions.Add(pin280.Position);
            polyline2.Positions.Add(pin281.Position);
            polyline2.Positions.Add(pin282.Position);
            polyline2.Positions.Add(pin291.Position);
            polyline2.Positions.Add(pin283.Position);
            polyline2.Positions.Add(pin284.Position);
            polyline2.Positions.Add(pin285.Position);
            polyline2.Positions.Add(pin286.Position);
            polyline2.Positions.Add(pin287.Position);
            polyline2.Positions.Add(pin288.Position);
            polyline2.Positions.Add(pin289.Position);
            polyline2.Positions.Add(pin290.Position);
            polyline2.Positions.Add(Qparada.Position);
            polyline2.Positions.Add(pin292.Position);
            polyline2.Positions.Add(pin293.Position);
            polyline2.Positions.Add(pin294.Position);
            polyline2.Positions.Add(pin295.Position);
            polyline2.Positions.Add(Cparada.Position);
            polyline2.Positions.Add(pin296.Position);
            polyline2.Positions.Add(pin297.Position);
            polyline2.Positions.Add(pin298.Position);
            polyline2.Positions.Add(pin299.Position);
            polyline2.Positions.Add(pin300.Position);
            polyline2.Positions.Add(Tparada.Position);
            polyline2.Positions.Add(pin301.Position);
            polyline2.Positions.Add(pin302.Position);
            polyline2.Positions.Add(pin303.Position);
            polyline2.Positions.Add(pin304.Position);
            polyline2.Positions.Add(pin305.Position);
            polyline2.Positions.Add(Sparada.Position);
            polyline2.Positions.Add(pin306.Position);
            polyline2.Positions.Add(pin307.Position);
            polyline2.Positions.Add(pin308.Position);
            polyline2.Positions.Add(pin309.Position);
            polyline2.Positions.Add(pin310.Position);
            polyline2.Positions.Add(pin311.Position);
            polyline2.Positions.Add(Pparada.Position);
            polyline2.Positions.Add(pin312.Position);
            polyline2.Positions.Add(pin313.Position);
            polyline2.Positions.Add(pin314.Position);
            polyline2.Positions.Add(pin315.Position);
            polyline2.Positions.Add(pin323.Position);
            polyline2.Positions.Add(pin316.Position);
            polyline2.Positions.Add(pin317.Position);
            polyline2.Positions.Add(pin318.Position);
            polyline2.Positions.Add(pin319.Position);
            polyline2.Positions.Add(pin320.Position);
            polyline2.Positions.Add(pin321.Position);
            polyline2.Positions.Add(pin322.Position);
            polyline2.Positions.Add(IntDos2.Position);
            polyline2.Positions.Add(pin324.Position);
            polyline2.Positions.Add(pin325.Position);
            polyline2.Positions.Add(pin326.Position);
            polyline2.Positions.Add(pin327.Position);
            polyline2.Positions.Add(IntDos.Position);

            mapa.Polylines.Add(polyline2);

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
            await DisplayAlert("Intercambiador Dosquebradas", "El bus llega en aproximadamente 1 minuto", "Ok");
        }
        private async void PinDos(object sender, EventArgs e)
        {
            await DisplayAlert("Cam", "El bus llega en aproximadamente 3 minutos", "Ok");
        }
        private async void PinTres(object sender, EventArgs e)
        {
            await DisplayAlert("Fundadores", "El bus llega en aproximadamente 6 minutos", "Ok");
        }
        private async void PinCuatro(object sender, EventArgs e)
        {
            await DisplayAlert("Milan", "El bus llega en  aproximadamente 9 minutos", "Ok");
        }
        private async void PinCinco(object sender, EventArgs e)
        {
            await DisplayAlert("Santa Monica", "El bus llega en aproximadamente 12 minutos", "Ok");
        }
        private async void PinSeis(object sender, EventArgs e)
        {
            await DisplayAlert("La Popa", "El bus llega en aproximadamente 15 minutos", "Ok");
        }
        private async void PinSiete(object sender, EventArgs e)
        {
            await DisplayAlert("Villavicencio", "El bus llega en aproximadamente 18 minutos", "Ok");
        }
        private async void PinOcho(object sender, EventArgs e)
        {
            await DisplayAlert("Ferrocarril", "El bus llega en aproximadamente 21 minutos", "Ok");
        }
        private async void PinNueve(object sender, EventArgs e)
        {
            await DisplayAlert("Parque Olaya", "El bus llega en aproximadamente 24 minutos", "Ok");
        }
        private async void PinDiez(object sender, EventArgs e)
        {
            await DisplayAlert("Centenario", "El bus llega en aproximadamente 27 minutos", "Ok");
        }
        private async void PinOnce(object sender, EventArgs e)
        {
            await DisplayAlert("Francisco Pereira", "El bus llega en aproximadamente 30 minutos", "Ok");
        }
        private async void PinDoce(object sender, EventArgs e)
        {
            await DisplayAlert("El Cafetero", "El bus llega en aproximadamente 33 minutos", "Ok");
        }
        private async void PinTrece(object sender, EventArgs e)
        {
            await DisplayAlert("Consota", "El bus llega en aproximadamente 36 minutos", "Ok");
        }
        private async void PinCatorce(object sender, EventArgs e)
        {
            await DisplayAlert("Ukumari", "El bus llega en aproximadamente 39 minutos", "Ok");
        }
        private async void PinQuince(object sender, EventArgs e)
        {
            await DisplayAlert("El Jardin", "El bus llega en aproximadamente 42 minutos", "Ok");
        }
        private async void Pin0016(object sender, EventArgs e)
        {
            await DisplayAlert("Maraya", "El bus llega en aproximadamente 45 minutos", "Ok");
        }
        private async void Pin0017(object sender, EventArgs e)
        {
            await DisplayAlert("Batallon", "El bus llega en aproximadamente 48 minutos", "Ok");
        }
        private async void Pin0018(object sender, EventArgs e)
        {
            await DisplayAlert("Aeropuerto", "El bus llega en aproximadamente 51 minutos", "Ok");
        }
        private async void Pin0019(object sender, EventArgs e)
        {
            await DisplayAlert("El Viajero", "El bus llega en aproximadamente 54 minutos", "Ok");
        }
        private async void Pin0020(object sender, EventArgs e)
        {
            await DisplayAlert("San Fernando", "El bus llega en  aproximadamente 57 minutos", "Ok");
        }
        private async void Pin0021(object sender, EventArgs e)
        {
            await DisplayAlert("Intercambiador Cuba", "El bus llega en aproximadamente 60 minutos", "Ok");
        }

        private async void PinVeinte(object sender, EventArgs e)
        {
            await DisplayAlert("Condina", "", "Ok");
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
                        await Task.Delay(650);
                        bus.IsVisible = false;
                        await Task.Delay(650);
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

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new Page1());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            if (mapa.Pins[0].IsVisible == true)
            {
                mapa.Pins[0].IsVisible = false;
                mapa.Pins[10].IsVisible = false;
                mapa.Pins[18].IsVisible = false;
                mapa.Pins[24].IsVisible = false;
                mapa.Pins[31].IsVisible = false;
                mapa.Pins[38].IsVisible = false;
                mapa.Pins[52].IsVisible = false;
                mapa.Pins[58].IsVisible = false;
                mapa.Pins[75].IsVisible = false;
                mapa.Pins[84].IsVisible = false;
                mapa.Pins[90].IsVisible = false;
                mapa.Pins[99].IsVisible = false;
                mapa.Pins[103].IsVisible = false;
                mapa.Pins[111].IsVisible = false;
                mapa.Pins[118].IsVisible = false;
                mapa.Pins[128].IsVisible = false;
                mapa.Pins[132].IsVisible = false;
                mapa.Pins[138].IsVisible = false;
                mapa.Pins[156].IsVisible = false;
                mapa.Pins[187].IsVisible = false;
                mapa.Pins[195].IsVisible = false;
            }
            else
            {
                mapa.Pins[0].IsVisible = true;
                mapa.Pins[10].IsVisible = true;
                mapa.Pins[18].IsVisible = true;
                mapa.Pins[24].IsVisible = true;
                mapa.Pins[31].IsVisible = true;
                mapa.Pins[38].IsVisible = true;
                mapa.Pins[52].IsVisible = true;
                mapa.Pins[58].IsVisible = true;
                mapa.Pins[75].IsVisible = true;
                mapa.Pins[84].IsVisible = true;
                mapa.Pins[90].IsVisible = true;
                mapa.Pins[99].IsVisible = true;
                mapa.Pins[103].IsVisible = true;
                mapa.Pins[111].IsVisible = true;
                mapa.Pins[118].IsVisible = true;
                mapa.Pins[128].IsVisible = true;
                mapa.Pins[132].IsVisible = true;
                mapa.Pins[138].IsVisible = true;
                mapa.Pins[156].IsVisible = true;
                mapa.Pins[187].IsVisible = true;
                mapa.Pins[195].IsVisible = true;
            }
        }
    }
}