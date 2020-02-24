using System;
using System.Collections.Generic;
using System.Text;

namespace ERPSedisa.Trabajos.Entidades
{
    public class Trabajos
    {
        public int IdTrabajo { get; set; }
        public int IdTipotrabajo { get; set; }
        public string Trabajo { get; set; }
        public int IdEstado { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Aud_UsuarioRegistro { get; set; }
        public DateTime Aud_FechaRegistro { get; set; }
        public int Aud_UsuarioModifica { get; set; }
        public DateTime Aud_FechaModifica { get; set; }
        public int Bit_Activo { get; set; }
    }
}
