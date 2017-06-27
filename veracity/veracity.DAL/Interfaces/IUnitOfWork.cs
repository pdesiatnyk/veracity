using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veracity.DAL.Entities;

namespace veracity.DAL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Employee> Employees { get; }
        IRepository<Entities.Task> Tasks { get; }
        IRepository<Achievement> Achievements { get; }
        IRepository<Site_Statistic> Site_Statistics { get; }
        IRepository<Department> Departments { get; }
        void Save();
    }
}
