using System;
using Microsoft.EntityFrameworkCore;
using NgaoApi.Models;

namespace NgaoApi.Data
{
    public class NgaoContext : DbContext
    {
        public NgaoContext(DbContextOptions<NgaoContext> opt) : base(opt)
        {
            
        }

        public DbSet<ngao> ngao { get; set; }

       
    }
}