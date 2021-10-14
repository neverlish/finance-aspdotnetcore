using Microsoft.EntityFrameworkCore;

namespace finance_aspdotnetcore.Models
{
  public class StockContext : DbContext
  {
    public StockContext(DbContextOptions<StockContext> options)
      : base(options)
    {
    }

    public DbSet<StockItem> Stocks { get; set; }
  }
}