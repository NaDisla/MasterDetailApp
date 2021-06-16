using MasterDetailApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [Obsolete]
    public partial class RegistroPedidosPage : ContentPage
    {
        public static ObservableCollection<DetallePedidos> detallePedidos = new ObservableCollection<DetallePedidos>();

        public RegistroPedidosPage()
        {
            InitializeComponent();
        }
        private void btnAddPedidoDetail_Clicked(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos()
            {
                Cliente = txtCliente.Text,
                FechaPedido = DateTime.Now.ToShortDateString(),
                ListaDetallePedidos = new List<DetallePedidos>(detallePedidos)
            };
            foreach (var item in detallePedidos)
            {
                pedido.TotalCompra += item.Total;
            }
            PedidosPage.listaPedidos.Add(pedido);
            txtProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtCliente.Text = "";
            txtCantidad.Text = "";
            detallePedidos.Clear();
        }

        private void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            DetallePedidos detPedido = new DetallePedidos()
            {
                Producto = txtProducto.Text,
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text),
                Total = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioUnitario.Text)
            };

            detallePedidos.Add(detPedido);
            ListaDetailPedidos.ItemsSource = detallePedidos;
        }

        private void ListaDetailPedidos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}