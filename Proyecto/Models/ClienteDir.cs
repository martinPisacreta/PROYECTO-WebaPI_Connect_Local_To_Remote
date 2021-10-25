using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class ClienteDir
    {
        public int IdCliente { get; set; }
        public decimal CodTipoDir { get; set; }
        public int CodClaseDir { get; set; }
        public decimal? CodTipoCalle { get; set; }
        public decimal? CodCalle { get; set; }
        public string TxtNumero { get; set; }
        public string TxtApto { get; set; }
        public string TxtPiso { get; set; }
        public string TxtDireccion { get; set; }
        public string TxtCodPostal { get; set; }
        public decimal CodPais { get; set; }
        public decimal? CodProvincia { get; set; }
        public decimal CodMunicipio { get; set; }
        public int SnActivo { get; set; }
        public DateTime? FecUltModif { get; set; }
        public string Accion { get; set; }

        public virtual Tcalle CodCalleNavigation { get; set; }
        public virtual Tmunicipio CodMunicipioNavigation { get; set; }
        public virtual Tpais CodPaisNavigation { get; set; }
        public virtual Tprovincia CodProvinciaNavigation { get; set; }
        public virtual TtipoCalle CodTipoCalleNavigation { get; set; }
        public virtual TtipoDir CodTipoDirNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
