using GMS_Matthew_Storti.Models;
using Microsoft.EntityFrameworkCore;

namespace GMS_Matthew_Storti.DataAccessLayer;

public class GroceryDBContext : DbContext
{
    public GroceryDBContext(DbContextOptions<GroceryDBContext> options) : base(options) { }

    public DbSet<GroceryItem> Items { get; set; }
}
