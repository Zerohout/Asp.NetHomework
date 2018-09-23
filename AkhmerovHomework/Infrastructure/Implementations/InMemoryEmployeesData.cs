using System.Collections.Generic;
using System.Linq;
using AkhmerovHomework.Infrastructure.Interfaces;
using AkhmerovHomework.Models;

namespace AkhmerovHomework.Infrastructure.Implementations
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>(3)
            {
                new EmployeeView
                {
                    Id = 1,
                    FirstName = "Тест",
                    SurName = "Тестов",
                    Patronymic = "Тестович",
                    Age = 21,
                    Position = "Тестовая"
                },
                new EmployeeView
                {
                    Id = 2,
                    FirstName = "Проверка",
                    SurName = "Проверкова",
                    Patronymic = "Проверковна",
                    Age = 20,
                    Position = "Проверочная"
                },
                new EmployeeView
                {
                    Id = 3,
                    FirstName = "Мужчина",
                    SurName = "Мужчинин",
                    Patronymic = "Мужчинский",
                    Age = 26,
                    Position = "Мужская"
                },
                new EmployeeView
                {
                    Id = 4,
                    FirstName = "Девушка",
                    SurName = "Девушкова",
                    Patronymic = "Девушковна",
                    Age = 25,
                    Position = "Девичья"
                }
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
