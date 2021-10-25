using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class TtipoCliente
    {
        public TtipoCliente()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdTipoCliente { get; set; }
        public string TxtDesc { get; set; }
        public int SnActivo { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
