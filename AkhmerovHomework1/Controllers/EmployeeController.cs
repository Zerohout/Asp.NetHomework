using AkhmerovHomework1.Infrastructure.Interfaces;
using AkhmerovHomework1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkhmerovHomework1.Controllers
{
    [Route("employees")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeeController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index() => View(_employeesData.GetAll());


        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);


            if (ReferenceEquals(employee, null))
            {
                return NotFound();
            }

            return View(employee);
        }

        [Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            EmployeeView model;

            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                {
                    return NotFound();
                }
            }
            else
            {
                model = new EmployeeView();
            }

            return View(model);
        }

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Id > 0)
            {
                var dbItem = _employeesData.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                {
                    return NotFound();
                }

                dbItem.FirstName = model.FirstName;
                dbItem.LastName = model.LastName;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Age = model.Age;
                dbItem.Birthday = model.Birthday;
                dbItem.StartWorking = model.StartWorking;

            }
            else
            {
                _employeesData.AddNew(model);
            }

            return RedirectToAction(nameof(Index));
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}