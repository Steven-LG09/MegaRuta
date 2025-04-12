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

namespace MiRuta9.Interfaces
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

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
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.810750, -75.688729),
            };
            mapa.Pins.Add(Separada);

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

            Pin pin011 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.811429, -75.704211),
            };
            mapa.Pins.Add(pin011);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(mapa.Pins[51].Position, Distance.FromMeters(3000)));

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
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.804358, -75.739029),
            };
            mapa.Pins.Add(pin156);

            Pin pin157 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.804326, -75.738991),
            };
            mapa.Pins.Add(pin157);

            Pin IntCuba2 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.804328, -75.738920),
            };
            mapa.Pins.Add(IntCuba2);

            Pin pin158 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804839, -75.738444),
            };

            Pin pin159 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.804892, -75.738451),
            };

            Pin pin160 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.805133, -75.738648),
            };

            Pin pin161 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.806833, -75.736875),
            };

            Pin pin162 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808623, -75.735678),
            };

            Pin pin163 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808730, -75.735604),
            };

            Pin pin164 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809324, -75.735271),
            };

            Pin pin165 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809524, -75.735060),
            };

            Pin pin166 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809607, -75.734858),
            };

            Pin pin167 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809651, -75.734479),
            };

            Pin pin168 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809749, -75.734231),
            };

            Pin pin173 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810150, -75.733671),
            };

            Pin pin169 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810849, -75.732595),
            };

            Pin pin170 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811214, -75.732144),
            };

            Pin pin171 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811296, -75.732131),
            };

            Pin pin172 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811442, -75.732233),
            };

            Pin pin174 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811509, -75.732406),
            };

            Pin pin175 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811382, -75.732917),
            };

            Pin pin176 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811437, -75.733055),
            };

            Pin pin177 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811818, -75.733286),
            };

            Pin pin191 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811879, -75.733404),
            };

            Pin pin178 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811881, -75.733493),
            };

            Pin pin179 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811855, -75.733635),
            };

            Pin pin180 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811758, -75.733906),
            };

            Pin pin181 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811776, -75.734063),
            };

            Pin pin182 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811986, -75.734317),
            };

            Pin pin183 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812098, -75.734308),
            };

            Pin pin184 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812550, -75.734100),
            };

            Pin pin185 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812998, -75.733666),
            };

            Pin pin186 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813078, -75.733622),
            };

            Pin pin187 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813320, -75.733575),
            };

            Pin pin188 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813448, -75.733605),
            };

            Pin pin189 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813477, -75.733685),
            };

            Pin pin190 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813436, -75.734018),
            };

            Pin pin192 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813413, -75.734161),
            };

            Pin pin193 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813333, -75.734479),
            };

            Pin pin194 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813280, -75.734533),
            };

            Pin pin195 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813211, -75.734543),
            };

            Pin pin196 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813143, -75.734508),
            };

            Pin pin197 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813149, -75.734038),
            };

            Pin pin198 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813199, -75.733874),
            };

            Pin pin199 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813443, -75.733428),
            };

            Pin pin200 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813672, -75.732323),
            };

            Pin pin201 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813842, -75.731788),
            };

            Pin pin202 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814056, -75.731409),
            };

            Pin pin203 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814636, -75.730691),
            };

            Pin pin204 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814981, -75.730194),
            };

            Pin pin205 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815200, -75.729933),
            };

            Pin pin206 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815305, -75.729721),
            };

            Pin pin207 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815364, -75.729493),
            };

            Pin pin208 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815350, -75.729175),
            };

            Pin pin209 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815220, -75.728352),
            };

            Pin pin210 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815232, -75.728195),
            };

            Pin pin211 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815423, -75.727489),
            };

            Pin pin212 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815687, -75.725458),
            };

            Pin pin213 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815845, -75.722586),
            };

            Pin pin214 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815931, -75.720847),
            };

            Pin pin215 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815948, -75.720648),
            };

            Pin pin216 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815992, -75.719870),
            };

            Pin pin217 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815927, -75.719237),
            };

            Pin pin218 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815671, -75.718137),
            };

            Pin pin219 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815543, -75.717813),
            };

            Pin pin220 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814914, -75.716710),
            };

            Pin pin221 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814831, -75.716500),
            };

            Pin pin222 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814777, -75.716226),
            };

            Pin pin223 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814667, -75.715178),
            };

            Pin pin224 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814558, -75.714925),
            };

            Pin pin225 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.814558, -75.714925),
            };

            Pin pin226 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813869, -75.713803),
            };

            Pin pin227 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813660, -75.713452),
            };

            Pin pin228 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813381, -75.712840),
            };

            Pin pin229 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813269, -75.712530),
            };

            Pin pin230 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813005, -75.710925),
            };

            Pin pin231 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812840, -75.710321),
            };

            Pin pin232 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812779, -75.710078),
            };

            Pin pin233 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812195, -75.707849),
            };

            Pin pin234 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812128, -75.707606),
            };

            Pin pin239 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811977, -75.706974),
            };

            Pin pin235 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811849, -75.705345),
            };

            Pin pin236 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811775, -75.704969),
            };

            Pin pin237 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811654, -75.704642),
            };

            Pin pin238 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811472, -75.704327),
            };

            Pin pin240 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.811342, -75.704120),
            };

            Pin pin241 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810890, -75.703405),
            };

            Pin pin242 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810776, -75.703155),
            };

            Pin pin243 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810694, -75.702878),
            };

            Pin pin244 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810554, -75.701993),
            };

            Pin pin245 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810512, -75.701741),
            };

            Pin pin246 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810218, -75.699906),
            };

            Pin pin247 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810173, -75.698692),
            };

            Pin pin248 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810144, -75.698474),
            };

            Pin pin249 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810029, -75.698214),
            };

            Pin pin250 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809843, -75.698008),
            };

            Pin pin251 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809061, -75.697523),
            };

            Pin pin252 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808924, -75.697377),
            };

            Pin pin253 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808841, -75.697179),
            };

            Pin pin254 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808791, -75.696930),
            };

            Pin pin255 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808665, -75.695895),
            };

            Pin Condina = new Pin()
            {
                Label = "",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.808669, -75.695749),
            };

            Pin pin256 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808640, -75.695671),
            };

            Pin pin257 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808422, -75.693819),
            };

            Pin pin258 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808452, -75.693556),
            };

            Pin pin259 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808543, -75.693345),
            };

            Pin pin260 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.808735, -75.693140),
            };

            Pin pin261 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809819, -75.692568),
            };

            Pin pin262 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810075, -75.692400),
            };

            Pin pin263 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810196, -75.692263),
            };

            Pin pin264 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810284, -75.692113),
            };

            Pin pin265 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810325, -75.691937),
            };

            Pin pin266 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810329, -75.691712),
            };

            Pin pin267 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810287, -75.691538),
            };

            Pin pin268 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809740, -75.690421),
            };

            Pin pin269 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809694, -75.690246),
            };

            Pin pin270 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809684, -75.690010),
            };

            Pin pin271 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809729, -75.689736),
            };

            Pin pin272 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809832, -75.689487),
            };

            Pin pin273 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.809991, -75.689281),
            };

            Pin pin274 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810663, -75.688754),
            };

            Pin pin275 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.810850, -75.688628),
            };

            Pin pin276 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812024, -75.687793),
            };

            Pin pin277 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812196, -75.687698),
            };

            Pin pin278 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812345, -75.687643),
            };

            Pin pin279 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812757, -75.687583),
            };

            Pin pin280 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.812939, -75.687565),
            };

            Pin pin281 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.813688, -75.687467),
            };

            Pin pin282 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.815386, -75.686883),
            };

            Pin pin291 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.817116, -75.686178),
            };

            Pin pin283 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.818394, -75.685750),
            };

            Pin pin284 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.818845, -75.685698),
            };

            Pin pin285 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821203, -75.684867),
            };

            Pin pin286 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821532, -75.684522),
            };

            Pin pin287 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.821943, -75.684105),
            };

            Pin pin288 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822054, -75.684010),
            };

            Pin pin289 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822253, -75.683900),
            };

            Pin pin290 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.822885, -75.683661),
            };

            Pin pin292 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.823118, -75.683574),
            };

            Pin pin293 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.823686, -75.683359),
            };

            Pin pin294 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.824258, -75.683078),
            };

            Pin pin295 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.826375, -75.681737),
            };

            Pin pin296 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.826594, -75.681603),
            };

            Pin pin297 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828255, -75.680558),
            };

            Pin pin298 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828549, -75.680316),
            };

            Pin pin299 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.828786, -75.680088),
            };

            Pin pin300 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.829201, -75.679581),
            };

            Pin pin301 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.829328, -75.679426),
            };

            Pin pin302 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830045, -75.678574),
            };

            Pin pin303 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830478, -75.678025),
            };

            Pin pin304 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.830662, -75.677697),
            };

            Pin pin305 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831085, -75.676875),
            };

            Pin pin306 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831209, -75.676656),
            };

            Pin pin307 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831348, -75.676394),
            };

            Pin pin308 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.831948, -75.675524),
            };

            Pin pin309 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.832059, -75.675335),
            };

            Pin pin310 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.832686, -75.674187),
            };

            Pin pin311 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833304, -75.673012),
            };

            Pin pin312 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833424, -75.672783),
            };

            Pin pin313 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833880, -75.671972),
            };

            Pin pin314 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834110, -75.671711),
            };

            Pin pin315 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835021, -75.670879),
            };

            Pin pin323 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836025, -75.669951),
            };

            Pin pin316 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836225, -75.669730),
            };

            Pin pin317 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836535, -75.669388),
            };

            Pin pin318 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836527, -75.669325),
            };

            Pin pin319 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836118, -75.668679),
            };

            Pin pin320 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835990, -75.668613),
            };

            Pin pin321 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835858, -75.668646),
            };

            Pin pin322 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835631, -75.668685),
            };

            Pin IntDos2 = new Pin()
            {
                Label="",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("Megabus.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "Megabus.png", WidthRequest = 50, HeightRequest = 50 }),
                Position = new Position(4.835383, -75.668367),
            };

            Pin pin324 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835071, -75.667941),
            };

            Pin pin325 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835091, -75.667875),
            };

            Pin pin326 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835312, -75.667726),
            };

            Pin pin327 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835380, -75.667755),
            };

            Polyline verde = new Xamarin.Forms.GoogleMaps.Polyline()
            {
                StrokeColor = Color.Green,
                StrokeWidth = 3,
            };

            foreach (var pin in mapa.Pins)
            {
                verde.Positions.Add(pin.Position);
            }

            mapa.Polylines.Add(verde);

            Polyline polyline = new Xamarin.Forms.GoogleMaps.Polyline()
            {
                StrokeColor = Color.IndianRed,
                StrokeWidth = 3,
            };

            polyline.Positions.Add((IntCuba2.Position));
            polyline.Positions.Add(pin158.Position);
            polyline.Positions.Add(pin159.Position);
            polyline.Positions.Add(pin160.Position);
            polyline.Positions.Add(pin161.Position);
            polyline.Positions.Add(pin162.Position);
            polyline.Positions.Add(pin020.Position);
            polyline.Positions.Add(pin163.Position);
            polyline.Positions.Add(pin164.Position);
            polyline.Positions.Add(pin165.Position);
            polyline.Positions.Add(pin166.Position);
            polyline.Positions.Add(pin167.Position);
            polyline.Positions.Add(pin168.Position);
            polyline.Positions.Add(pin173.Position);
            polyline.Positions.Add(pin169.Position);
            polyline.Positions.Add(pin170.Position);
            polyline.Positions.Add(pin171.Position);
            polyline.Positions.Add(pin172.Position);
            polyline.Positions.Add(pin174.Position);
            polyline.Positions.Add(pin175.Position);
            polyline.Positions.Add(pin176.Position);
            polyline.Positions.Add(pin177.Position);
            polyline.Positions.Add(pin191.Position);
            polyline.Positions.Add(pin178.Position);
            polyline.Positions.Add(pin179.Position);
            polyline.Positions.Add(pin180.Position);
            polyline.Positions.Add(pin181.Position);
            polyline.Positions.Add(pin182.Position);
            polyline.Positions.Add(pin183.Position);
            polyline.Positions.Add(pin184.Position);
            polyline.Positions.Add(pin185.Position);
            polyline.Positions.Add(pin186.Position);
            polyline.Positions.Add(pin187.Position);
            polyline.Positions.Add(pin188.Position);
            polyline.Positions.Add(pin189.Position);
            polyline.Positions.Add(pin190.Position);
            polyline.Positions.Add(pin019.Position);
            polyline.Positions.Add(pin192.Position);
            polyline.Positions.Add(pin193.Position);
            polyline.Positions.Add(pin194.Position);
            polyline.Positions.Add(pin195.Position);
            polyline.Positions.Add(pin196.Position);
            polyline.Positions.Add(pin197.Position);
            polyline.Positions.Add(pin198.Position);
            polyline.Positions.Add(pin199.Position);
            polyline.Positions.Add(pin200.Position);
            polyline.Positions.Add(pin201.Position);
            polyline.Positions.Add(pin202.Position);
            polyline.Positions.Add(pin203.Position);
            polyline.Positions.Add(pin204.Position);
            polyline.Positions.Add(pin205.Position);
            polyline.Positions.Add(pin206.Position);
            polyline.Positions.Add(pin207.Position);
            polyline.Positions.Add(pin208.Position);
            polyline.Positions.Add(pin209.Position);
            polyline.Positions.Add(pin210.Position);
            polyline.Positions.Add(pin211.Position);
            polyline.Positions.Add(pin018.Position);
            polyline.Positions.Add(pin212.Position);
            polyline.Positions.Add(pin017.Position);
            polyline.Positions.Add(pin213.Position);
            polyline.Positions.Add(pin214.Position);
            polyline.Positions.Add(pin016.Position);
            polyline.Positions.Add(pin215.Position);
            polyline.Positions.Add(pin216.Position);
            polyline.Positions.Add(pin217.Position);
            polyline.Positions.Add(pin218.Position);
            polyline.Positions.Add(pin219.Position);
            polyline.Positions.Add(pin220.Position);
            polyline.Positions.Add(pin221.Position);
            polyline.Positions.Add(pin222.Position);
            polyline.Positions.Add(pin015.Position);
            polyline.Positions.Add(pin223.Position);
            polyline.Positions.Add(pin224.Position);
            polyline.Positions.Add(pin225.Position);
            polyline.Positions.Add(pin226.Position);
            polyline.Positions.Add(pin014.Position);
            polyline.Positions.Add(pin227.Position);
            polyline.Positions.Add(pin228.Position);
            polyline.Positions.Add(pin229.Position);
            polyline.Positions.Add(pin230.Position);
            polyline.Positions.Add(pin231.Position);
            polyline.Positions.Add(pin013.Position);
            polyline.Positions.Add(pin232.Position);
            polyline.Positions.Add(pin233.Position);
            polyline.Positions.Add(pin012.Position);
            polyline.Positions.Add(pin234.Position);
            polyline.Positions.Add(pin239.Position);
            polyline.Positions.Add(pin235.Position);
            polyline.Positions.Add(pin236.Position);
            polyline.Positions.Add(pin237.Position);
            polyline.Positions.Add(pin238.Position);
            polyline.Positions.Add(pin011.Position);
            polyline.Positions.Add(pin240.Position);
            polyline.Positions.Add(pin241.Position);
            polyline.Positions.Add(pin242.Position);
            polyline.Positions.Add(pin243.Position);
            polyline.Positions.Add(pin244.Position);
            polyline.Positions.Add(pin010.Position);
            polyline.Positions.Add(pin245.Position);
            polyline.Positions.Add(pin246.Position);
            polyline.Positions.Add(pin247.Position);
            polyline.Positions.Add(pin248.Position);
            polyline.Positions.Add(pin249.Position);
            polyline.Positions.Add(pin250.Position);
            polyline.Positions.Add(pin251.Position);
            polyline.Positions.Add(pin252.Position);
            polyline.Positions.Add(pin253.Position);
            polyline.Positions.Add(pin254.Position);
            polyline.Positions.Add(pin255.Position);
            polyline.Positions.Add(Condina.Position);
            polyline.Positions.Add(pin256.Position);
            polyline.Positions.Add(pin257.Position);
            polyline.Positions.Add(pin258.Position);
            polyline.Positions.Add(pin259.Position);
            polyline.Positions.Add(pin260.Position);
            polyline.Positions.Add(pin261.Position);
            polyline.Positions.Add(pin262.Position);
            polyline.Positions.Add(pin263.Position);
            polyline.Positions.Add(pin264.Position);
            polyline.Positions.Add(pin265.Position);
            polyline.Positions.Add(pin266.Position);
            polyline.Positions.Add(pin267.Position);
            polyline.Positions.Add(pin268.Position);
            polyline.Positions.Add(pin269.Position);
            polyline.Positions.Add(pin270.Position);
            polyline.Positions.Add(pin271.Position);
            polyline.Positions.Add(pin272.Position);
            polyline.Positions.Add(pin273.Position);
            polyline.Positions.Add(pin274.Position);
            polyline.Positions.Add(Separada.Position);
            polyline.Positions.Add(pin275.Position);
            polyline.Positions.Add(pin276.Position);
            polyline.Positions.Add(pin277.Position);
            polyline.Positions.Add(pin278.Position);
            polyline.Positions.Add(pin279.Position);
            polyline.Positions.Add(pin07.Position);
            polyline.Positions.Add(pin280.Position);
            polyline.Positions.Add(pin281.Position);
            polyline.Positions.Add(pin282.Position);
            polyline.Positions.Add(pin291.Position);
            polyline.Positions.Add(pin283.Position);
            polyline.Positions.Add(pin284.Position);
            polyline.Positions.Add(pin285.Position);
            polyline.Positions.Add(pin286.Position);
            polyline.Positions.Add(pin287.Position);
            polyline.Positions.Add(pin288.Position);
            polyline.Positions.Add(pin289.Position);
            polyline.Positions.Add(pin290.Position);
            polyline.Positions.Add(pin06.Position);
            polyline.Positions.Add(pin292.Position);
            polyline.Positions.Add(pin293.Position);
            polyline.Positions.Add(pin294.Position);
            polyline.Positions.Add(pin295.Position);
            polyline.Positions.Add(pin05.Position);
            polyline.Positions.Add(pin296.Position);
            polyline.Positions.Add(pin297.Position);
            polyline.Positions.Add(pin298.Position);
            polyline.Positions.Add(pin299.Position);
            polyline.Positions.Add(pin300.Position);
            polyline.Positions.Add(pin04.Position);
            polyline.Positions.Add(pin301.Position);
            polyline.Positions.Add(pin302.Position);
            polyline.Positions.Add(pin303.Position);
            polyline.Positions.Add(pin304.Position);
            polyline.Positions.Add(pin305.Position);
            polyline.Positions.Add(pin03.Position);
            polyline.Positions.Add(pin306.Position);
            polyline.Positions.Add(pin307.Position);
            polyline.Positions.Add(pin308.Position);
            polyline.Positions.Add(pin309.Position);
            polyline.Positions.Add(pin310.Position);
            polyline.Positions.Add(pin311.Position);
            polyline.Positions.Add(pin02.Position);
            polyline.Positions.Add(pin312.Position);
            polyline.Positions.Add(pin313.Position);
            polyline.Positions.Add(pin314.Position);
            polyline.Positions.Add(pin315.Position);
            polyline.Positions.Add(pin323.Position);
            polyline.Positions.Add(pin316.Position);
            polyline.Positions.Add(pin317.Position);
            polyline.Positions.Add(pin318.Position);
            polyline.Positions.Add(pin319.Position);
            polyline.Positions.Add(pin320.Position);
            polyline.Positions.Add(pin321.Position);
            polyline.Positions.Add(pin322.Position);
            polyline.Positions.Add(IntDos2.Position);
            polyline.Positions.Add(pin324.Position);
            polyline.Positions.Add(pin325.Position);
            polyline.Positions.Add(pin326.Position);
            polyline.Positions.Add(pin327.Position);
            polyline.Positions.Add(pin01.Position);

            mapa.Polylines.Add(polyline);

            mapa.UiSettings.ZoomControlsEnabled = false;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            int cont = 51;
            foreach(var bus in mapa.Pins)
            {
                bus.IsVisible = true;
                await Task.Delay(1000);
                bus.IsVisible = false;
                await Task.Delay(1000);
                mapa.Pins[51].IsVisible = true;
                cont-=1;
                tiempo.Text =cont.ToString();
                if (cont <= 0)
                {
                    tiempo.Text = "0";

                }
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            for (int i = 0;i<=10;i++)
            {
                await Task.Delay(1000);
                if (i == 1)
                {
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(mapa.Pins[51].Position, Distance.FromMeters(100)));
                }
                if (i == 5)
                {
                    mapa.MoveToRegion(MapSpan.FromCenterAndRadius(mapa.Pins[40].Position, Distance.FromMeters(2100)));
                    await Task.Delay(5000);
                    i = 0;
                }
            }
        }
    }
}