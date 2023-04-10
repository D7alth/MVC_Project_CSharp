using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using form_scrum.Models;
using Microsoft.EntityFrameworkCore;

namespace form_scrum.Data
{
    public class dbContext : DbContext
    {
        static readonly string connectionString = "Server=localhost; User ID=root; Password=1911@1; Database=;";
        public DbSet<ContatoModel> Contatos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}