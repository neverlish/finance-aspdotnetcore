using finance_aspdotnetcore.Models;
using System.Linq;

namespace finance_aspdotnetcore.Data
{
  public static class DbInitializer
  {
    public static void Initialize(StockContext context)
    {
      context.Database.EnsureCreated();
      if (context.Stocks.Any())
      {
        return;
      }

      var stocks = new StockItem[]
      {
        new StockItem{Id=1, DateYmd=20210920, Price=3},
        new StockItem{Id=2, DateYmd=20210922, Price=5},
        new StockItem{Id=3, DateYmd=20210923, Price=2},
        new StockItem{Id=4, DateYmd=20211001, Price=4},
      };

      context.Stocks.AddRange(stocks);
      context.SaveChanges();
    }
  }
}