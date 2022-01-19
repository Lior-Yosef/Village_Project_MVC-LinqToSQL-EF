using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Village_Project_MVC_LinqToSQL_EF.Models
{
    public partial class VillageDataContext : DbContext
    {
        public VillageDataContext()
            : base("name=VillageDataContext")
        {
        }

        public virtual DbSet<Resident> Residents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
