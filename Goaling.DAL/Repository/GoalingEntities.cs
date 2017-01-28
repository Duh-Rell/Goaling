using Goaling.DAL.Model.Bowler;

namespace Goaling.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class GoalingEntities : DbContext
    {
        public GoalingEntities() : base("name=GoalingEntities")
        {

        }

        public virtual DbSet<Bowler> Bowlers { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BowlerMap());
        }
    }
}
