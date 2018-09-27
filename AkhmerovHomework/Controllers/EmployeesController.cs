using AkhmerovHomework.Domain.Model;
using AkhmerovHomework.Infrastructure.Interfaces;
using AkhmerovHomework.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AkhmerovHomeWork.Controllers
{
    [Route("users")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            var employee = _employeesData.GetById(id);

            if (ReferenceEquals(employee, null))
                return NotFound();

            return View(employee);
        }

        [Route("edit/{id?}")]
        [Authorize(Roles = Constants.Roles.Administrator)]
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
        [Authorize(Roles = Constants.Roles.Administrator)]
        public IActionResult Edit(EmployeeView model)
        {
            if (model.Age < 18 && model.Age > 75)
            {
                ModelState.AddModelError("Age", "Ошибка возраста!");
            }

            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    var dbItem = _employeesData.GetById(model.Id);

                    if (ReferenceEquals(dbItem, null))
                        return NotFound();

                    dbItem.FirstName = model.FirstName;
                    dbItem.SurName = model.SurName;
                    dbItem.Age = model.Age;
                    dbItem.Patronymic = model.Patronymic;
                    dbItem.Position = dbItem.Position;
                }
                else
                {
                    _employeesData.AddNew(model);
                }
                _employeesData.Commit();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [Route("delete/{id}")]
        [Authorize(Roles = Constants.Roles.Administrator)]
        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}