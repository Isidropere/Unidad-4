using Iperez_MVC_ActionLink_DiplomadoUASD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Iperez_MVC_ActionLink_DiplomadoUASD.ContextDB
{
    public class ContextDbConexion:DbContext
    {
        //clase constructor para la conexion a la base de datos 
        public ContextDbConexion()
            : base("ContextDbConexion") //nombre de la conxion
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedore> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}