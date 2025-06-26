using Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class AppDbcontext:DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public AppDbcontext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString!,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
       // public DbSet<BookWritter> Publications { get; set; }    
    }
}
