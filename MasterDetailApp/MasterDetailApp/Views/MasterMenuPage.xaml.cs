using MasterDetailApp.MenuItems;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class MasterMenuPage : MasterDetailPage
    {
        List<ItemsMenu> ListaMenuItems = new List<ItemsMenu>();
        ViewCell lastCell, normalCell;

        public MasterMenuPage()
        {
            InitializeComponent();

            ItemsMenu item01 = new ItemsMenu()
            {
                Item = "Pedidos",
                TargetType = typeof(PedidosPage)
            };
            ListaMenuItems.Add(item01);

            ItemsMenu item02 = new ItemsMenu()
            {
                Item = "Registro de pedidos",
                TargetType = typeof(RegistroPedidosPage)
            };
            ListaMenuItems.Add(item02);

            MenuList.ItemsSource = ListaMenuItems;
            Detail = new NavigationPage(new PedidosPage());
            MenuList.ItemSelected += MenuList_ItemSelected;
        }

        private void MenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ItemsMenu page = e.SelectedItem as ItemsMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page.TargetType));
            IsPresented = false;
        }

        private void celdaMenu_Tapped(object sender, EventArgs e)
        {
            if(lastCell != null)
            {
                lastCell.View.BackgroundColor = Color.Default;
            }
            normalCell = (ViewCell)sender;
            if(normalCell.View != null)
            {
                normalCell.View.BackgroundColor = Color.White;
                lastCell = normalCell;
            }
        }
    }
}