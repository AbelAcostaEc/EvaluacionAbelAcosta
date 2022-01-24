using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
   public class EvaluacionDB : DbContext
    {
        //Declaración entidades del modelo DB
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //configuracipon de la conexion
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Linea concexion SQL SERVER
            string conSQLServer = "server = ABEL-ASAA\\SQLEXPRESS; Initial Catalog = Evaluacion; trusted_connection=true;";

            //Conexion con sql server
            options.UseSqlServer(conSQLServer);

        }


        //configuracion modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Relaciones 1 a muchos
            //cardinalidad Country City
            model.Entity<City>()
                .HasOne(city => city.Country)
                .WithMany(country => country.Cities)
                .HasForeignKey(city => city.CountryId);

            //cardinalidad City Address
            model.Entity<Address>()
                .HasOne(address => address.City)
                .WithMany(city => city.addresses)
                .HasForeignKey(address => address.CityId);

        }
    }
}
