using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteDatos = new HashSet<ClienteDatos>();
            ClienteDir = new HashSet<ClienteDir>();
            Factura = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string NombreFantasia { get; set; }
        public string RazonSocial { get; set; }
        public int SnActivo { get; set; }
        public DateTime FecUltModif { get; set; }
        public string Accion { get; set; }
        public int? IdCondicionAnteIva { get; set; }
        public int? IdCondicionPago { get; set; }
        public int IdCondicionFactura { get; set; }
        public int IdTipoCliente { get; set; }

        public virtual TtipoCondicionIva IdCondicionAnteIvaNavigation { get; set; }
        public virtual TtipoCondicionFactura IdCondicionFacturaNavigation { get; set; }
        public virtual TtipoCondicionPago IdCondicionPagoNavigation { get; set; }
        public virtual TtipoCliente IdTipoClienteNavigation { get; set; }
        public virtual ICollection<ClienteDatos> ClienteDatos { get; set; }
        public virtual ICollection<ClienteDir> ClienteDir { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
