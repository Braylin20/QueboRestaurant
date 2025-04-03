using Microsoft.EntityFrameworkCore;
using QueboRestaurant.Domain.models;
namespace QueboRestaurant.API.Dal;

public class QueboRestaurantContext : DbContext
{
    public QueboRestaurantContext(DbContextOptions<QueboRestaurantContext> options):base(options){}

    public DbSet<AcountingAccounts> AcountingAccounts { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Clients> Clients { get; set; }
    public DbSet<Expenses> Expenses { get; set; }
    public DbSet<PaymentMethods> PaymentMethods { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Purchases> Purchases { get; set; }
    public DbSet<Reconciliations> Reconciliations { get; set; }
    public DbSet<Sales> Sales { get; set; }
    public DbSet<Tables> Tables { get; set; }


}
