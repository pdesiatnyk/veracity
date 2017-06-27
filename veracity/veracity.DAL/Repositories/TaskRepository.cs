using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.EF;
using veracity.DAL.Entities;
using veracity.DAL.Interfaces;


namespace veracity.DAL.Repositories
{
    public class TaskRepository : IRepository<Entities.Task>
    {
        private DataContext db;

        public TaskRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Entities.Task> GetAll()
        {
            return db.Tasks;
        }

        public Entities.Task Get(int id)
        {
            return db.Tasks.Find(id);
        }

        public void Create(Entities.Task book)
        {
            db.Tasks.Add(book);
        }

        public void Update(Entities.Task book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Entities.Task> Find(Func<Entities.Task, Boolean> predicate)
        {
            return db.Tasks.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Entities.Task book = db.Tasks.Find(id);
            if (book != null)
                db.Tasks.Remove(book);
        }
    }
}
