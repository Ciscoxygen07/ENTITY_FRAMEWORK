
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Pizza> Pizzas{get; set;}
   public Context (DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
   {
    
   } 
}