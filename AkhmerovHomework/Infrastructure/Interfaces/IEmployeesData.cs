using System.Collections.Generic;
using AkhmerovHomework.Models;

namespace AkhmerovHomework.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<EmployeeView> GetAll();

        EmployeeView GetById(int id);

        void Commit();

        void AddNew(EmployeeView model);

        void Delete(int id);
    }
}
