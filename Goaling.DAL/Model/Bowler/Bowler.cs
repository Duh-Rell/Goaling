namespace Goaling.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bowler
    {
        public long BowlerId { get; set; }

        public string Name { get; set; }
    }
}
