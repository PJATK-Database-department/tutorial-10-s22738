using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APBD_10.Models;

namespace APBD_10.Data
{
    public class APBD_10Context : DbContext
    {
        public APBD_10Context (DbContextOptions<APBD_10Context> options)
            : base(options)
        {
        }

        public DbSet<APBD_10.Models.Movie> Movie { get; set; }
    }
}
