using MasterDetailApp.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PedidosPage : ContentPage
    {
        public static ObservableCollection<Pedidos> listaPedidos = new ObservableCollection<Pedidos>();

        public PedidosPage()
        {
            InitializeComponent();

            if (listaPedidos.Count == 0) txtTest.Text = "No hay pedidos";
            else ListaPedidos.ItemsSource = listaPedidos;
        }

        [Obsolete]
        private async void ListaPedidos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pedido = ListaPedidos.SelectedItem as Pedidos;
            await Navigation.PushAsync(new DetallePedidosPage(pedido.Cliente, pedido.ListaDetallePedidos, pedido.TotalCompra));
        }
    }
}