using Iperez_MVC_ActionLink_DiplomadoUASD.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Iperez_MVC_ActionLink_DiplomadoUASD.ContextDB 
{
    public class CargaDatosDB: System.Data.Entity.DropCreateDatabaseIfModelChanges<ContextDbConexion>
    {

        protected override void Seed(ContextDbConexion context)
        {
            var Clientes = new List<Cliente>
            { 
                new Cliente{Nombre="Julio", Apellido ="Martes", Cedula="001125512", Telefono="809-560-7896"},
                new Cliente{Nombre="Antonio", Apellido ="Dominguez", Cedula="00158992", Telefono="809-560-3600"},
                new Cliente{Nombre="Juana", Apellido ="Rodriguez", Cedula="0012566932", Telefono="809-561-2526"},
                new Cliente{Nombre="Manuel", Apellido ="Santos", Cedula="0011256695", Telefono="809-562-3636"},
                new Cliente{Nombre="Maria", Apellido ="Perez", Cedula="0015899542", Telefono="809-458-9636"},

            };
            Clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

            var Proveedor = new List<Proveedore>
            {
                new Proveedore{Nombre="Elias", Apellido ="Martes", Cedula="001125512", Telefono="809-560-7896"},
                new Proveedore{Nombre="Jose", Apellido ="Dominguez", Cedula="00158992", Telefono="809-560-3600"},
                new Proveedore{Nombre="Pedro", Apellido ="Rodriguez", Cedula="0012566932", Telefono="809-561-2526"},
                new Proveedore{Nombre="Mirian", Apellido ="Santos", Cedula="0011256695", Telefono="809-562-3636"},
                new Proveedore{Nombre="Misael", Apellido ="Perez", Cedula="0015899542", Telefono="809-458-9636"},
            };
            Proveedor.ForEach(s=>context.Proveedores.Add(s));
            context.SaveChanges();
        }
    }
}