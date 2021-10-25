using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class TtipoDato
    {
        public TtipoDato()
        {
            ClienteDatos = new HashSet<ClienteDatos>();
            ProveedorDatos = new HashSet<ProveedorDatos>();
        }

        public decimal CodTipoDato { get; set; }
        public string TxtDesc { get; set; }

        public virtual ICollection<ClienteDatos> ClienteDatos { get; set; }
        public virtual ICollection<ProveedorDatos> ProveedorDatos { get; set; }
    }
}
