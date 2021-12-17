using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Context
{
    public class WebDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
