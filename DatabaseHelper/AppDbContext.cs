﻿using Microsoft.EntityFrameworkCore;
using PruebaApi.Models;

namespace PruebaApi.DatabaseHelper
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) { }
        public DbSet<Tarea> Tareas { get; set; }  
    }
}
