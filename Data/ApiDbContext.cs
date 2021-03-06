using Microsoft.EntityFrameworkCore;
using MusicAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }

        public DbSet<Song> Songs { get; set; }
    }
}
