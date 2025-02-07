using FoodStore.Models;
using FoodStoreApp1_2025.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace FoodStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
             DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
    }
}
