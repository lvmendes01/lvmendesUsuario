using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lvmendes.Entidades
{
    public class EFDataContext : DbContext
    {
        public DbSet<Sistema> Sistemas { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Autorizacoes> Autorizacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=den1.mssql7.gear.host;Initial Catalog=usuarioapi;Persist Security Info=True;User ID=usuarioapi;Password=Gq25T!9Y6-iL");
        }


    }
}
