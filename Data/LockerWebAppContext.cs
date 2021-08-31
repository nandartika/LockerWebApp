using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LockerWebApp.Models;

namespace LockerWebApp.Data
{
    public class LockerWebAppContext : DbContext
    {
        public LockerWebAppContext (DbContextOptions<LockerWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<LockerWebApp.Models.Locker> Locker { get; set; }
    }
}
