using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.EF;
using veracity.DAL.Entities;
using veracity.DAL.Interfaces;
namespace veracity.DAL.Repositories
{
    class Site_StatisticRepository :IRepository<Site_Statistic> 
    {
        private DataContext db;
        public Site_StatisticRepository(DataContext context)
        {
            this.db = context;
        }
        public IEnumerable<Site_Statistic> GetAll()
        {
            return db.Site_Statistics;
        }
        public Site_Statistic Get(int id)
        {
            return db.Site_Statistics.Find(id);
        }
        public void Create(Site_Statistic worker)
        {
            db.Site_Statistics.Add(worker);
        }
        public void Update(Site_Statistic worker)
        {
            db.Entry(worker).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(int id)
        {
            Site_Statistic worker = db.Site_Statistics.Find(id);
            if (worker != null)
            {
                db.Site_Statistics.Remove(worker);
            }
        }

        public IEnumerable<Site_Statistic> Find(Func<Site_Statistic, Boolean> predicate)
        {
            return db.Site_Statistics.Where(predicate).ToList();
        }
    }
}
