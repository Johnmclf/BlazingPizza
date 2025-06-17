using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace BlazingPizza.Data;
public class PizzaStoreContext :DbContext
{
     public PizzaStoreContext(DbContextOptions options) : base(options)
     {
     }
     public DbSet<PizzaSpecial> Specials { get; set; }
 }