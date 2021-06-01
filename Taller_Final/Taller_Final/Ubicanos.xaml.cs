using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Taller_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ubicanos : ContentPage
    {
        public Ubicanos()
        {
            InitializeComponent();
            mostrarMapa(-2.155538,-79.8910639);
        }

        private void mostrarMapa(double lati,double longi)
        {
            base.OnAppearing();
            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(lati,longi), Distance.FromKilometers(0.5)
                ));

            var posi = new Position(lati,longi);
            var pin = new Pin { 
                Type = PinType.Place,
                Position = posi,
                Label = "Discomusic"
            };

            this.Mapa.Pins.Add(pin);
        }
    }
}