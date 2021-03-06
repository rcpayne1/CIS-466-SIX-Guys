﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eCommerceAPI.Entities
{
    public class SqlDbContext : DbContext

    {
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product> Product { get; set; }

        public SqlDbContext(DbContextOptions<SqlDbContext> options)
        : base(options)
        { }

    }
}
