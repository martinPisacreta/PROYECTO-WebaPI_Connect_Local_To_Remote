﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Proyecto.Models
{
    public partial class LogTareaProgramada
    {
        public int Id { get; set; }
        public string Tabla { get; set; }
        public DateTime Fecha { get; set; }
        public string Observacion { get; set; }
    }
}
