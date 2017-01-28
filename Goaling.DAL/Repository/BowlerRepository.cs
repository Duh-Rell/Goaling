using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goaling.DAL.Repository
{
    public interface IBowlerRepository : IRepository<Bowler>
    {
        List<Bowler> RetrieveAll();
    }

    public class BowlerRepository : BaseRepository<Bowler>, IBowlerRepository
    {
        private GoalingEntities db;

        public BowlerRepository(GoalingEntities db) : base(db, db.Bowlers)
        {
            this.db = db;
        }

        public List<Bowler> RetrieveAll()
        {
            IQueryable<Bowler> query = from b in db.Bowlers
                select b;

            return query.ToList();
        }

        public override void Update(Bowler bowler)
        {
            db.Bowlers.Attach(bowler);
            var entry = db.Entry(bowler);
            entry.Property(p => p.Name).IsModified = true;
            db.SaveChanges();
        }
    }
}

