using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Taller_Final.Modelos;

namespace Taller_Final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        List<Producto> Lista;
        public Home()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista = new List<Producto>
            {
                new Producto{ Name= "Zayn", ImageUrl="zayn.jpg"},
                  new Producto{ Name= "Bad Bunny", ImageUrl="Bad.jpg"}
            };
            this.ListaCD.ItemsSource = Lista;
        }

        private void ListaCD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                ListaCD.SelectedItem = null;
                DisplayAlert("Coleccion View","Selection","Cerrar");
            }
        }
    }
}