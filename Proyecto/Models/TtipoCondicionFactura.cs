using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class TtipoCondicionFactura
    {
        public TtipoCondicionFactura()
        {
            Cliente = new HashSet<Cliente>();
            Factura = new HashSet<Factura>();
        }

        public int IdCondicionFactura { get; set; }
        public string TxtDesc { get; set; }
        public int SnActivo { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
