using System.Collections.Generic;
using AkhmerovHomework1.Models;

namespace AkhmerovHomework1.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<EmployeeView> GetAll();

        EmployeeView GetById(int id);

        void AddNew(EmployeeView model);

        void Delete(int id);
    }
}
