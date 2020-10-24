using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsShoppingCar.Models;
using Microsoft.EntityFrameworkCore;

namespace CmsShoppingCar.Infrastructure
{
    public class CmsShoppingCarContext : DbContext
    {
        public CmsShoppingCarContext(DbContextOptions<CmsShoppingCarContext> options) 
            : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
    }
}
