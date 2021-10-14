using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finance_aspdotnetcore.Models;

namespace finance_aspdotnetcore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StockController : ControllerBase
  {
    private readonly StockContext _context;

    public StockController(StockContext context)
    {
      _context = context;
    }
  }
}
