using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    [Table("Link")]
    public class Link
    {
        public int LinkId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HiddenDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
    }

    public class MySqlContext : DbContext
    {
        public MySqlContext() : base("MysqlContext")
        {
            this.Configuration.LazyLoadingEnabled = false;            
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<MySqlContext>(null);
            this.Database.Log = Console.WriteLine;
        }

        public DbSet<Link> Links { get; set; }
    }
}
