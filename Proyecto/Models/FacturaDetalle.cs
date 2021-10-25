using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class FacturaDetalle
    {
        public int IdFacturaDetalle { get; set; }
        public long? IdArticulo { get; set; }
        public int IdFactura { get; set; }
        public int Cantidad { get; set; }
        public string CodigoArticuloMarca { get; set; }
        public string CodigoArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public decimal PrecioListaXCoeficiente { get; set; }
        public decimal Iva { get; set; }
        public DateTime? FecBaja { get; set; }

        public virtual Articulo IdArticuloNavigation { get; set; }
        public virtual Factura IdFacturaNavigation { get; set; }
    }
}
