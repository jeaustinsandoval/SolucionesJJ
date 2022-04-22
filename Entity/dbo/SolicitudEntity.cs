using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class SolicitudEntity : DBEntity

    {
        public SolicitudEntity()
        {
            Cliente ??= new ClienteEntity();
            Servicio ??= new ServicioEntity();
        }
        
        public int? IdSolicitud{ get; set; }
        public int IdCliente { get; set; }
        public virtual ClienteEntity Cliente { get; set; }
        public int IdServicio { get; set; }
        public virtual ServicioEntity Servicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaEntrega { get; set; } = DateTime.Now;
        public string UsuarioEntrega { get; set; }
        public string Observaciones { get; set; }
    }
}
