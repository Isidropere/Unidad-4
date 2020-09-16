using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Iperez_MVC_ActionLink_DiplomadoUASD.Models
{
    public class Proveedore
    {
        [Key]
        public int ID_Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
    }
}