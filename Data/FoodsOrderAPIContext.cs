using FoodsOrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsOrderAPI.Data
{
    public class FoodsOrderAPIContext : DbContext
    {
        public FoodsOrderAPIContext(DbContextOptions<FoodsOrderAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FoodItem> FoodItems { get; set; }
    }
}
