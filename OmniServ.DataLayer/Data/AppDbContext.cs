using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OmniServ.DataLayer.Entities;

namespace OmniServ.DataLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Asset> Assets { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<RentalOrder> RentalOrders { get; set; } = null!;
        public DbSet<ServiceAppointment> ServiceAppointments { get; set; } = null!;
    }
}
