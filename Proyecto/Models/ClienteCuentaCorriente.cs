using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class ClienteCuentaCorriente
    {
        public int IdClienteCuentaCorriente { get; set; }
        public int IdCliente { get; set; }
        public int? IdFactura { get; set; }
        public DateTime? FechaFacturaVieja { get; set; }
        public long? NroFacturaVieja { get; set; }
        public decimal? CodTipoFacturaVieja { get; set; }
        public decimal? ImpFactura { get; set; }
        public decimal? Pago1 { get; set; }
        public decimal? Pago2 { get; set; }
        public decimal? Pago3 { get; set; }
        public decimal? Pago4 { get; set; }
        public DateTime? Pago1Fecha { get; set; }
        public DateTime? Pago2Fecha { get; set; }
        public DateTime? Pago3Fecha { get; set; }
        public DateTime? Pago4Fecha { get; set; }
        public string Observacion { get; set; }
    }
}
