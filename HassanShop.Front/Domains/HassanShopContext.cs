using Entities.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HassanShop.Front.Domains
{
    public class HassanShopContext: DbContext
    {
        public HassanShopContext() : base("HassanShopDB") { }

        #region DbSets
        public DbSet<Product> Products { get; set; }
        #endregion
    }
}
