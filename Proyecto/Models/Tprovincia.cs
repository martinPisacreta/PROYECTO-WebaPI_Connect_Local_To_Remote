using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class Tprovincia
    {
        public Tprovincia()
        {
            ClienteDir = new HashSet<ClienteDir>();
            ProveedorDir = new HashSet<ProveedorDir>();
            Tmunicipio = new HashSet<Tmunicipio>();
        }

        public decimal CodProvincia { get; set; }
        public decimal CodPais { get; set; }
        public string TxtDesc { get; set; }

        public virtual Tpais CodPaisNavigation { get; set; }
        public virtual ICollection<ClienteDir> ClienteDir { get; set; }
        public virtual ICollection<ProveedorDir> ProveedorDir { get; set; }
        public virtual ICollection<Tmunicipio> Tmunicipio { get; set; }
    }
}
