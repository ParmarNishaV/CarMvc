using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class GirirajDbContext : DbContext
{
    public GirirajDbContext(DbContextOptions<GirirajDbContext> options) : base(options)
    {
    }

    public DbSet<Car> cars { get; set; }
}