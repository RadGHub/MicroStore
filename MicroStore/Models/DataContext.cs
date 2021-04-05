﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace MicroStore.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
