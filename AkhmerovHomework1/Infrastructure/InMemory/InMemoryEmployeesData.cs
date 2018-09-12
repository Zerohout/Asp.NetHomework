using AkhmerovHomework1.Infrastructure.Interfaces;
using AkhmerovHomework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AkhmerovHomework1.Infrastructure.InMemory
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;

        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>(4)
            {
                new EmployeeView
                {
                    Id = 1,
                    FirstName = "Тест",
                    LastName = "Тестов",
                    Patronymic = "Тестович",
                    Age = 21,
                    Birthday = new DateTime(1997,03,12),
                    StartWorking = new DateTime(2018,08,10)
                },
                new EmployeeView
                {
                    Id = 2,
                    FirstName = "Проверка",
                    LastName = "Проверкова",
                    Patronymic = "Проверковна",
                    Age = 20,
                    Birthday = new DateTime(1998,05,25),
                    StartWorking = new DateTime(2018,08,27)
                },
                new EmployeeView
                {
                    Id = 3,
                    FirstName = "Мужчина",
                    LastName = "Мужчинин",
                    Patronymic = "Мужчинский",
                    Age = 26,
                    Birthday = new DateTime(1992,08,09),
                    StartWorking = new DateTime(2017,01,17)
                },
                new EmployeeView
                {
                    Id = 4,
                    FirstName = "Девушка",
                    LastName = "Девушкова",
                    Patronymic = "Девушковна",
                    Age = 25,
                    Birthday = new DateTime(1993,09,01),
                    StartWorking = new DateTime(2017,02,24)
                }
            };
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(t => t.Id.Equals(id));
        }

        public void AddNew(EmployeeView model)
        {
            model.Id = _employees.Max(t => t.Id) + 1;
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
