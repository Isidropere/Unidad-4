namespace Iperez_MVC_ActionLink_DiplomadoUASD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Iperez_MVC_ActionLink_DiplomadoUASD.ContextDB.ContextDbConexion>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ContextDbConexion";
        }

        protected override void Seed(Iperez_MVC_ActionLink_DiplomadoUASD.ContextDB.ContextDbConexion context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
