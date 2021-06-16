using MasterDetailApp.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePedidosPage : ContentPage
    {
        public DetallePedidosPage(string cliente, List<DetallePedidos> detail, decimal total)
        {
            InitializeComponent();

            txtCliente.Text += cliente;
            DetailPedido.ItemsSource = detail;
            txtTotalOrden.Text += total;
        }
    }
}