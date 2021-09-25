using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

    namespace Veterinaria.App.Persistencia 
    { 
        public class AppContext : DbContext 
        { 
            public DbSet<Persona> personas {get;set;}
            public DbSet<Veterinario> veterinario {get;set;}
            public DbSet<Propietario> propietario {get;set;}
            public DbSet<Mascota> mascota {get;set;}
            public DbSet<Visita> visita {get;set;}
            public DbSet<EstadodeSalud> estadosalud {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
          optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaData");
        }
    }

        }
    }
