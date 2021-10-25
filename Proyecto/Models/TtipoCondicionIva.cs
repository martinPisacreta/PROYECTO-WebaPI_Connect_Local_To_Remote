using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class TtipoCondicionIva
    {
        public TtipoCondicionIva()
        {
            Cliente = new HashSet<Cliente>();
            Empresa = new HashSet<Empresa>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int IdCondicionAnteIva { get; set; }
        public string TxtDesc { get; set; }
        public string Tipo { get; set; }
        public string TxtDescResumido { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
