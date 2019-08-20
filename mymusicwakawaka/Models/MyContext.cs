using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mymusicwakawaka.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Music> Musics { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Singer> Singers { get; set; }
    }
}
