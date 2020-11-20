using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestTesoroUsuario.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuarios>
    {

        public DbSet<Usuarios> UsuariosApps { get; set; }

        public DbSet<Coordenadas_Tesoro> Coordenadas { get; set; }

        public DbSet<TesoroUser> Tesoros { get; protected set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Usuarios>(entityTypeBuilder =>
            {
                entityTypeBuilder.ToTable("USUARIOS");
                entityTypeBuilder.Property(u => u.Id_Usuario).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Nombre_Usuario).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.Color_Usuario).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }

    public class Usuarios: IdentityUser
    {
        public Guid Id_Usuario { get; set; }

        public string Nombre_Usuario { get; set; }

        public string Color_Usuario { get; set; }
    } 

    public class TesoroUser
    {
        public Guid Id_Usuario { get; set; }
        
        public Guid Id { get; set; }

        public string NombreTesoro { get; set; }

        public string DescripcionTesoro { get; set; }

        public DateTime FechaTesoro { get; set; }

        public string LugarTesoro { get; set; }

        public Coordenadas_Tesoro Latitud_Longitud { get; set; }

        public string ValorTesoro { get; set; }

        public string PesoTesoro { get; set; }

        public string UrlTesoro { get; set; }
    }    

    public class Coordenadas_Tesoro
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid Uid {get; set;}
        public float Lat {get; set;}
        public float Lng {get; set;}
    }
}
