using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreWebApi.Aloha.DataContext.Maps;
using NetCoreWebApi.Aloha.Features.Aloha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.DataContext
{
    public class AlohaDataContext : DbContext
    {
        public AlohaDataContext(DbContextOptions<AlohaDataContext> options) : base(options)
        {

        }
        public DbSet<AlohaGroupMember> AlohaGroupMember { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("AlohaConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new AlohaGroupMemberMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
