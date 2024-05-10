

using DersdeTask.Models;
using Microsoft.EntityFrameworkCore;


namespace DersdeTask.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

   public DbSet<Product> Products { get; set; }

}
