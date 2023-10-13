using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PurseWeb.Models;

namespace PurseWeb.Data
{
    public class PurseWebContext :DbContext
    {
        public PurseWebContext(DbContextOptions<PurseWebContext> options)
            : base(options)
        {

        }
        public DbSet<PurseWeb.Models.Purse> Purse { get; set; }
    }
}
