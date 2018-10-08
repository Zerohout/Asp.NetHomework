using System.Collections.Generic;
using System.Linq;
using WebStore.DomainNew.Models;
using WebStore.Interfaces;

namespace WebStore.Infrastructure.Implementations.InMemory
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>(3)
            {
                new EmployeeView(){Id = 1, FirstName = "Тест", SurName = "Тестович", Patronymic = "Тестов", Age = 22, Position = "Директор"},
                new EmployeeView(){Id = 2, FirstName = "Проверка", SurName = "Проверочка", Patronymic = "Проверковна", Age = 30, Position = "Программист"},
                new EmployeeView(){Id = 3, FirstName = "Человек", SurName = "Человеков", Patronymic = "Человекович", Age = 50, Position = "Зав. склада"}
            };
        }
        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }

        public void Commit()
        {
            //ничего не делаем
        }

        public void AddNew(EmployeeView model)
        {
            model.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(model);
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
