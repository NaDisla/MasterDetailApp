using System.Collections.Generic;

namespace MasterDetailApp.Models
{
    public class Pedidos
    {
        public string Cliente { get; set; }
        public string FechaPedido { get; set; }
        public List<DetallePedidos> ListaDetallePedidos { get; set; }
        public decimal TotalCompra { get; set; }

        public Pedidos()
        {
            TotalCompra = 0;
        }
    }
}
