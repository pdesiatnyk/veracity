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
    class AchievementRepository : IRepository<Achievement>
    {
        private DataContext db;
    public AchievementRepository(DataContext context)
    {
        this.db = context;
    }
    public IEnumerable<Achievement> GetAll()
    {
        return db.Achievements;
    }
    public Achievement Get(int id)
    {
        return db.Achievements.Find(id);
    }
    public void Create(Achievement worker)
    {
        db.Achievements.Add(worker);
    }
    public void Update(Achievement worker)
    {
        db.Entry(worker).State = System.Data.Entity.EntityState.Modified;
    }
    public void Delete(int id)
    {
        Achievement worker = db.Achievements.Find(id);
        if (worker != null)
        {
            db.Achievements.Remove(worker);
        }
    }

    public IEnumerable<Achievement> Find(Func<Achievement, Boolean> predicate)
    {
        return db.Achievements.Where(predicate).ToList();
    }

}
}
