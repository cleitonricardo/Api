using DataAccess.Mappings;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=database-2.cy0hh8z3zelr.us-east-1.rds.amazonaws.com;Initial Catalog=kmRodado;Persist Security Info=False;User ID=admin;Password=crss1218;");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TemplateMappings());

        }

        public DbSet<Template> Template { get; set; }

    }
}
