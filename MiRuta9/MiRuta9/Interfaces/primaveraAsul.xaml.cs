using MiRuta9.Interfaces.Alimentador;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
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
	public partial class primaveraAsul : ContentPage
	{
        public primaveraAsul()
        {
            InitializeComponent();

            Pin IntDos = new Pin()
            {
                Type = PinType.Place,
                Label = "Intercambiador Dosquebradas",
                Address = "BAHIA 3",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835497, -75.668286),
            };
            mapa.Pins.Add(IntDos);

            Pin pin1 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835126, -75.667746),
            };
            mapa.Pins.Add(pin1);

            Pin pin2 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835528, -75.667458),
            };
            mapa.Pins.Add(pin2);

            Pin Pparada = new Pin()
            {
                Type = PinType.Place,
                Label = "1ra Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834863, -75.666396)
            };
            mapa.Pins.Add(Pparada);
            Pparada.Clicked += PinUno;

            Pin pin3 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834759, -75.666249),
            };
            mapa.Pins.Add(pin3);

            Pin Sparada = new Pin()
            {
                Type = PinType.Place,
                Label = "2da Parada",
                Address = "Click para Ver",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835310, -75.665255)
            };
            mapa.Pins.Add(Sparada);
            Sparada.Clicked += PinDos;

            Pin pin4 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835423, -75.665106),
            };
            mapa.Pins.Add(pin4);

            Pin pin5 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836259, -75.664808),
            };
            mapa.Pins.Add(pin5);

            Pin Tparada = new Pin()
            {
                Type = PinType.Place,
                Label = "3ra Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836049, -75.664206),
            };
            mapa.Pins.Add(Tparada);
            Tparada.Clicked += PinTres;

            Pin pin6 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835896, -75.663580),
            };
            mapa.Pins.Add(pin6);

            Pin Cparada = new Pin()
            {
                Type = PinType.Place,
                Label = "4ta Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835610, -75.663082),
            };
            mapa.Pins.Add(Cparada);
            Cparada.Clicked += PinCuatro;

            Pin pin7 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835503, -75.662754),
            };
            mapa.Pins.Add(pin7);

            Pin pin8 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835602, -75.662475),
            };
            mapa.Pins.Add(pin8);

            Pin pin9 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836038, -75.662142),
            };
            mapa.Pins.Add(pin9);

            Pin Qparada = new Pin()
            {
                Type = PinType.Place,
                Label = "5ta Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836104, -75.661925),
            };
            mapa.Pins.Add(Qparada);
            Qparada.Clicked += PinCinco;

            Pin pin10 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836116, -75.661822),
            };
            mapa.Pins.Add(pin10);

            Pin pin11 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835748, -75.661562),
            };
            mapa.Pins.Add(pin11);

            Pin SEparada = new Pin()
            {
                Type = PinType.Place,
                Label = "6ta Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835494, -75.661233),
            };
            mapa.Pins.Add(SEparada);
            SEparada.Clicked += PinSeis;

            Pin SEcparada = new Pin()
            {
                Type = PinType.Place,
                Label = "7ta Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834669, -75.660241),
            };
            mapa.Pins.Add(SEcparada);
            SEcparada.Clicked += PinSiete;

            Pin pin12 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834577, -75.660156),
            };
            mapa.Pins.Add(pin12);

            Pin pin13 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834097, -75.660561),
            };
            mapa.Pins.Add(pin13);

            Pin Oparada = new Pin()
            {
                Type = PinType.Place,
                Label = "8ta Parada",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833933, -75.660403),
            };
            mapa.Pins.Add(Oparada);

            Pin Nparada = new Pin()
            {
                Type = PinType.Place,
                Label = "9na Parada",
                IsVisible = false,
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833420, -75.659773),
            };
            mapa.Pins.Add(Nparada);

            Pin pin14 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833265, -75.659512),
            };
            mapa.Pins.Add(pin14);

            Pin Dparada = new Pin()
            {
                Type = PinType.Place,
                Label = "10ma Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833320, -75.658434),
            };
            mapa.Pins.Add(Dparada);
            Dparada.Clicked += PinDiez;

            Pin pin15 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833371, -75.657914),
            };
            mapa.Pins.Add(pin15);

            Pin Onparada = new Pin()
            {
                Type = PinType.Place,
                Label = "11va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833742, -75.657435),
            };
            mapa.Pins.Add(Onparada);
            Onparada.Clicked += PinOnce;

            Pin pin16 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834168, -75.656947),
            };
            mapa.Pins.Add(pin16);

            Pin pin17 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834226, -75.657071),
            };
            mapa.Pins.Add(pin17);

            Pin pin18 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834078, -75.657322),
            };
            mapa.Pins.Add(pin18);

            Pin Doparada = new Pin()
            {
                Type = PinType.Place,
                Label = "12va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834085, -75.657488),
            };
            mapa.Pins.Add(Doparada);
            Doparada.Clicked += PinDoce;

            Pin pin19 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834039, -75.657654),
            };
            mapa.Pins.Add(pin19);

            Pin pin20 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833782, -75.657992),
            };
            mapa.Pins.Add(pin20);

            Pin Trparada = new Pin()
            {
                Type = PinType.Place,
                Label = "13va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.833795, -75.658131),
            };
            mapa.Pins.Add(Trparada);
            Trparada.Clicked += PinTrece;

            Pin pin21 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833690, -75.658531),
            };
            mapa.Pins.Add(pin21);

            Pin pin22 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833704, -75.658752),
            };
            mapa.Pins.Add(pin22);

            Pin pin23 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.833610, -75.658914),
            };
            mapa.Pins.Add(pin23);

            Pin Caparada = new Pin()
            {
                Type = PinType.Place,
                Label = "14va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834195, -75.659612),
            };
            mapa.Pins.Add(Caparada);
            Caparada.Clicked += PinCatorce;

            Pin Quparada = new Pin()
            {
                Type = PinType.Place,
                Label = "15va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.834724, -75.660233),
            };
            mapa.Pins.Add(Quparada);
            Quparada.Clicked += PinQuince;

            Pin Diparada = new Pin()
            {
                Type = PinType.Place,
                Label = "16va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835462, -75.661119),
            };
            mapa.Pins.Add(Diparada);
            Diparada.Clicked += PinDiesyseis;

            Pin pin24 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835774, -75.661539),
            };
            mapa.Pins.Add(pin24);

            Pin pin25 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836177, -75.661824),
            };
            mapa.Pins.Add(pin25);

            Pin pin26 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836166, -75.661926),
            };
            mapa.Pins.Add(pin26);

            Pin Dieparada = new Pin()
            {
                Type = PinType.Place,
                Label = "17va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836309, -75.662108),
            };
            mapa.Pins.Add(Dieparada);
            Dieparada.Clicked += PinDiesysiete;

            Pin Diezparada = new Pin()
            {
                Type = PinType.Place,
                Label = "18va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837069, -75.663062),
            };
            mapa.Pins.Add(Diezparada);
            mapa.MoveToRegion(MapSpan.FromCenterAndRadius(Diezparada.Position, Distance.FromMeters(700)));
            Diezparada.Clicked += PinDiesyocho;

            Pin Diesparada = new Pin()
            {
                Type = PinType.Place,
                Label = "19va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837849, -75.664029),
            };
            mapa.Pins.Add(Diesparada);
            Diesparada.Clicked += PinDiesynueve;

            Pin pin27 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.837903, -75.664131),
            };
            mapa.Pins.Add(pin27);

            Pin Vparada = new Pin()
            {
                Type = PinType.Place,
                Label = "20va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837488, -75.664547),
            };
            mapa.Pins.Add(Vparada);
            Vparada.Clicked += PinVeinte;

            Pin Vpparada = new Pin()
            {
                Type = PinType.Place,
                Label = "21va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.837101, -75.664925),
            };
            mapa.Pins.Add(Vpparada);
            Vpparada.Clicked += PinVentiuno;

            Pin pin28 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.837016, -75.665010),
            };
            mapa.Pins.Add(pin28);

            Pin pin29 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.837027, -75.665213),
            };
            mapa.Pins.Add(pin29);

            Pin pin30 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836781, -75.665374),
            };
            mapa.Pins.Add(pin30);

            Pin Vsparada = new Pin()
            {
                Type = PinType.Place,
                Label = "22va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.836384, -75.664944),
            };
            mapa.Pins.Add(Vsparada);
            Vsparada.Clicked += PinVentidos;

            Pin pin31 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.836303, -75.664851),
            };
            mapa.Pins.Add(pin31);

            Pin pin32 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835432, -75.665155),
            };
            mapa.Pins.Add(pin32);

            Pin pin33 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.834793, -75.666246),
            };
            mapa.Pins.Add(pin33);

            Pin Vtparada = new Pin()
            {
                Type = PinType.Place,
                Label = "23va Parada",
                IsVisible = false,
                Address = "Click para Ver",
                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("busStop.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "busStop.png", WidthRequest = 30, HeightRequest = 30 }),
                Position = new Position(4.835235, -75.666951),
            };
            mapa.Pins.Add(Vtparada);
            Vtparada.Clicked += PinVentitres;

            Pin pin34 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835597, -75.667513),
            };
            mapa.Pins.Add(pin34);

            Pin pin35 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835204, -75.667751),
            };
            mapa.Pins.Add(pin35);

            Pin pin36 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835764, -75.668528),
            };
            mapa.Pins.Add(pin36);

            Pin pin37 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835763, -75.668580),
            };
            mapa.Pins.Add(pin37);

            Pin pin38 = new Pin()
            {
                Label = "",
                IsVisible = false,
                Position = new Position(4.835706, -75.668577),
            };
            mapa.Pins.Add(pin38);

            Pin pin39 = new Pin()
            {
                Label = "",
                IsVisible = false,
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
        private void PinUno(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8348196,-75.6663067,3a,75y,321.55h,85.06t/data=!3m7!1e1!3m5!1st5VcB-d54A37KwukFQxBqA!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3Dt5VcB-d54A37KwukFQxBqA%26cb_client%3Dsearch.gws-prod.gps%26w%3D86%26h%3D86%26yaw%3D352.40308%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinDos(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8353587,-75.6652701,3a,75y,169.87h,72.54t/data=!3m7!1e1!3m5!1srIEc0MIP_IVYhjxP6RupfA!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DrIEc0MIP_IVYhjxP6RupfA%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D147.43674%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinTres(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8361514,-75.6642999,3a,75y,136.82h,63.26t/data=!3m7!1e1!3m5!1s2XeP1fYzPJe6_Ryo0SR3fA!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3D2XeP1fYzPJe6_Ryo0SR3fA%26cb_client%3Dsearch.gws-prod.gps%26w%3D86%26h%3D86%26yaw%3D169.36778%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinCuatro(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8355797,-75.6629832,3a,75y,250.11h,62.8t/data=!3m7!1e1!3m5!1s4apNSt1z59KP-JpYp7nb3Q!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3D4apNSt1z59KP-JpYp7nb3Q%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D297.48163%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinCinco(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8361456,-75.6618121,3a,75y,248h,72.02t/data=!3m6!1e1!3m4!1scYlqs-ZrB8oFpK3G4LFOXg!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinSeis(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8355444,-75.6611911,3a,75y,209.21h,69.82t/data=!3m6!1e1!3m4!1sVCbsLN450TUPmnC9tJrmeQ!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinSiete(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8346894,-75.6601962,3a,75y,194.77h,59.21t/data=!3m7!1e1!3m5!1sog4pqnoYmy2AGRHA2ttWOw!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3Dog4pqnoYmy2AGRHA2ttWOw%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D299.2532%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinDiez(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8333813,-75.6584971,3a,75y,214.2h,59.93t/data=!3m6!1e1!3m4!1spY-VwKaPdr8BRgR6rka9Qg!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinOnce(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8338202,-75.6573882,3a,75y,96.76h,67.07t/data=!3m7!1e1!3m5!1sPGQsZYfF5TFhm_Vt-5-Ekw!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DPGQsZYfF5TFhm_Vt-5-Ekw%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D187.6201%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinDoce(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8341216,-75.6575091,3a,75y,315.18h,74.2t/data=!3m7!1e1!3m5!1srW-TJCoExSiiitMsz6693g!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DrW-TJCoExSiiitMsz6693g%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D134.75684%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinTrece(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8338033,-75.6581036,3a,75y,305.37h,66.25t/data=!3m7!1e1!3m5!1sBCY7jTvUxb4758Z0N_PiKQ!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DBCY7jTvUxb4758Z0N_PiKQ%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D244.85344%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinCatorce(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8342278,-75.6596345,3a,75y,14.17h,75.22t/data=!3m6!1e1!3m4!1syhSkOgAylRhQqeofiUTz2Q!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinQuince(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8346894,-75.6601962,3a,75y,5.89h,75.54t/data=!3m6!1e1!3m4!1sog4pqnoYmy2AGRHA2ttWOw!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinDiesyseis(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8354779,-75.6611144,3a,75y,359.77h,64.48t/data=!3m6!1e1!3m4!1suLbrEgM5DJqPjvW7Of-0ug!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinDiesysiete(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8362855,-75.6620668,3a,75y,26.86h,67.29t/data=!3m7!1e1!3m5!1sCq1DmKhE3SDA1Wn28jaZGQ!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DCq1DmKhE3SDA1Wn28jaZGQ%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D129.63268%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinDiesyocho(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8370792,-75.6630779,3a,75y,43.05h,79.66t/data=!3m6!1e1!3m4!1s3tZOMz4bNSeMP_Gj-9GUHw!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinDiesynueve(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8378327,-75.663998,3a,75y,16.48h,68.27t/data=!3m7!1e1!3m5!1ssNJK9riuct8R9IERLdzymQ!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DsNJK9riuct8R9IERLdzymQ%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D118.72379%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinVeinte(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8375042,-75.6645004,3a,75y,334.89h,73.23t/data=!3m7!1e1!3m5!1schvKwClq2eafrAQXz0SvAw!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DchvKwClq2eafrAQXz0SvAw%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D158.35315%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinVentiuno(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8371313,-75.6649078,3a,75y,264.79h,65.91t/data=!3m7!1e1!3m5!1syoICqWDORWDcJqlpvG4npg!2e0!6shttps:%2F%2Fstreetviewpixels-pa.googleapis.com%2Fv1%2Fthumbnail%3Fpanoid%3DyoICqWDORWDcJqlpvG4npg%26cb_client%3Dmaps_sv.tactile.gps%26w%3D203%26h%3D100%26yaw%3D158.02225%26pitch%3D0%26thumbfov%3D100!7i13312!8i6656?entry=ttu"));
        }
        private void PinVentidos(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8364284,-75.6649185,3a,75y,245.03h,72.13t/data=!3m6!1e1!3m4!1syWgGrdQ7l5z56wOH3jpH1Q!2e0!7i13312!8i6656?entry=ttu"));
        }
        private void PinVentitres(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.google.com/maps/@4.8351503,-75.6667895,3a,75y,68.4h,78.72t/data=!3m6!1e1!3m4!1skxx5ifJ1vVIviMgXSpO98w!2e0!7i13312!8i6656?entry=ttu"));
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
                    await Task.Delay(2000);
                    usuario.IsVisible = false;
                }
                else
                {
                    mientras = false;
                    await DisplayAlert("Alerta", "Active su ubicacion", "Ok");
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new primaveraAsulTR());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            if (mapa.Pins[0].IsVisible == true)
            {
                mapa.Pins[0].IsVisible = false;
                mapa.Pins[3].IsVisible = false;
                mapa.Pins[5].IsVisible = false;
                mapa.Pins[8].IsVisible = false;
                mapa.Pins[10].IsVisible = false;
                mapa.Pins[14].IsVisible = false;
                mapa.Pins[17].IsVisible = false;
                mapa.Pins[18].IsVisible = false;
                mapa.Pins[21].IsVisible = false;
                mapa.Pins[22].IsVisible = false;
                mapa.Pins[24].IsVisible = false;
                mapa.Pins[26].IsVisible = false;
                mapa.Pins[30].IsVisible = false;
                mapa.Pins[33].IsVisible = false;
                mapa.Pins[37].IsVisible = false;
                mapa.Pins[38].IsVisible = false;
                mapa.Pins[39].IsVisible = false;
                mapa.Pins[43].IsVisible = false;
                mapa.Pins[44].IsVisible = false;
                mapa.Pins[45].IsVisible = false;
                mapa.Pins[47].IsVisible = false;
                mapa.Pins[48].IsVisible = false;
                mapa.Pins[52].IsVisible = false;
                mapa.Pins[56].IsVisible = false;
            }
            else
            {
                mapa.Pins[0].IsVisible = true;
                mapa.Pins[3].IsVisible = true;
                mapa.Pins[5].IsVisible = true;
                mapa.Pins[8].IsVisible = true;
                mapa.Pins[10].IsVisible = true;
                mapa.Pins[14].IsVisible = true;
                mapa.Pins[17].IsVisible = true;
                mapa.Pins[18].IsVisible = true;
                mapa.Pins[21].IsVisible = true;
                mapa.Pins[22].IsVisible = true;
                mapa.Pins[24].IsVisible = true;
                mapa.Pins[26].IsVisible = true;
                mapa.Pins[30].IsVisible = true;
                mapa.Pins[33].IsVisible = true;
                mapa.Pins[37].IsVisible = true;
                mapa.Pins[38].IsVisible = true;
                mapa.Pins[39].IsVisible = true;
                mapa.Pins[43].IsVisible = true;
                mapa.Pins[44].IsVisible = true;
                mapa.Pins[45].IsVisible = true;
                mapa.Pins[47].IsVisible = true;
                mapa.Pins[48].IsVisible = true;
                mapa.Pins[52].IsVisible = true;
                mapa.Pins[56].IsVisible = true;

            }
        }
    }
}