using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ClienteEntity : DBEntity
    {
        public int? IdCliente { get; set; }
        public string Identificacion { get; set; }
        public int? IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public int? Nacionalidad { get; set; }
        public DateTime FechaDefuncion { get; set; } = DateTime.Now;
        public string Genero { get; set; }
        public string NombreApellidosPadre { get; set; }
        public string NombreApellidosMadre { get; set; }
        public string Pasaporte { get; set; }
        public string CuentaIBAN { get; set; }
        public string CorreoNotifica { get; set; }

    }
}
