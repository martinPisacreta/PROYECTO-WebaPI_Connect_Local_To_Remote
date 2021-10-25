using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class TtipoFactura
    {
        public TtipoFactura()
        {
            Factura = new HashSet<Factura>();
        }

        public decimal CodTipoFactura { get; set; }
        public string TxtDesc { get; set; }
        public string Letra { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
