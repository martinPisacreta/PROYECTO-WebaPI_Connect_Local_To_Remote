using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class ClienteDatos
    {
        public int IdCliente { get; set; }
        public decimal CodTipoDato { get; set; }
        public string TxtDatoCliente { get; set; }
        public int SnActivo { get; set; }
        public DateTime FecUltModif { get; set; }
        public string Accion { get; set; }

        public virtual TtipoDato CodTipoDatoNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
