using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Taller_Final
{
  

    [Obsolete, DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Mymenu();
        }
        public void Mymenu()
        {
            Detail = new NavigationPage(new Home());
            List<Menu> Menu = new List<Menu>
            {
            new Menu{ Page = new Home(), MenuTitle ="Home"},
            new Menu{ Page = new Cuenta(), MenuTitle ="Cuenta"},
            new Menu{ Page = new Contactanos(), MenuTitle ="Contactanos"},
            new Menu{ Page = new Ubicanos(), MenuTitle ="Ubicanos"},
            };
            ListMenu.ItemsSource = Menu;
        }
        public void ListaMenu_SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if(menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }
          
        }

        public class Menu
        {
            public string MenuTitle { get; set; }
            public Page Page { get; set; }
        }
    }
}
