using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class Tcalle
    {
        public Tcalle()
        {
            ClienteDir = new HashSet<ClienteDir>();
            ProveedorDir = new HashSet<ProveedorDir>();
        }

        public decimal CodCalle { get; set; }
        public string TxtDesc { get; set; }

        public virtual ICollection<ClienteDir> ClienteDir { get; set; }
        public virtual ICollection<ProveedorDir> ProveedorDir { get; set; }
    }
}
