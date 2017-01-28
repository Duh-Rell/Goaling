using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goaling.DAL.Model.Bowler
{
    public class BowlerMap : EntityTypeConfiguration<DAL.Bowler>
    {
        public BowlerMap()
        {
            this.ToTable("Bowler");

            this.HasKey(x => x.BowlerId);
            this.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);
            
            this.Property(x => x.BowlerId).HasColumnName("BowlerId");
            this.Property(x => x.Name).HasColumnName("Name");
        }
    }
}
