using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class ArticuloTmp
    {
        public string CodigoArticuloMarca { get; set; }
        public string CodigoArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public double? PrecioLista { get; set; }
        public double? PrecioFinal { get; set; }
        public double? IdTablaFamilia { get; set; }
        public double? SnOferta { get; set; }
        public string PathImg { get; set; }
        public long? IdArticulo { get; set; }
        public int? Stock { get; set; }
        public long? IdOrden { get; set; }
    }
}
