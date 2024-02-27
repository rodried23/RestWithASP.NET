using Microsoft.EntityFrameworkCore;
using Poc_API_Relatorios_TBFG.Model;
using System;

namespace Poc_API_Relatorios_TBFG.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Categorias> Categorias {  get; set; }

        public DbSet<Produtos> Produtos { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString: "Server=localhost,1433;DataBase=CatalogoDB;User ID=sa;Password=Ccbl@#GreeN;TrustServerCertificate=True");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
