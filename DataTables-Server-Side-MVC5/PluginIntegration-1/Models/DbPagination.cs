using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PluginIntegration_1.Models
{
    public class DbPaginationb : DbContext
    {
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}