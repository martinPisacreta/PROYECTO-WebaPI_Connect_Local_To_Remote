using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Marca = new HashSet<Marca>();
            ProveedorDatos = new HashSet<ProveedorDatos>();
            ProveedorDir = new HashSet<ProveedorDir>();
        }

        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public int SnActivo { get; set; }
        public DateTime FecUltModif { get; set; }
        public string Accion { get; set; }
        public string PathImg { get; set; }
        public int? IdCondicionAnteIva { get; set; }
        public int? IdCondicionPago { get; set; }

        public virtual TtipoCondicionIva IdCondicionAnteIvaNavigation { get; set; }
        public virtual TtipoCondicionPago IdCondicionPagoNavigation { get; set; }
        public virtual ICollection<Marca> Marca { get; set; }
        public virtual ICollection<ProveedorDatos> ProveedorDatos { get; set; }
        public virtual ICollection<ProveedorDir> ProveedorDir { get; set; }
    }
}
