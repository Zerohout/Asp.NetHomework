﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.DomainNew.ViewModel;
using WebStore.Interfaces.Services;


namespace WebStore.ServicesHosting.Controllers
{
    [Produces("application/json")]
    [Route("api/employees")]
    public class EmployeesApiController : Controller, IEmployeesData
    {
        private readonly IEmployeesData _employeesData;

        public EmployeesApiController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        /// <inheritdoc />
        /// GET api/employees
        [HttpGet]
        public IEnumerable<EmployeeView> GetAll()
        {
            return _employeesData.GetAll();
        }

        /// <inheritdoc />
        /// GET api/employees/{id}
        [HttpGet("{id}")]
        public EmployeeView GetById(int id)
        {
            return _employeesData.GetById(id);
        }

        /// <inheritdoc />
        /// PUT api/employees/{id} 
        [HttpPut("{id}")]
        public EmployeeView UpdateEmployee(int id, [FromBody]EmployeeView entity)
        {
            return _employeesData.UpdateEmployee(id, entity);
        }

        /// <inheritdoc />
        /// POST api/employees
        [HttpPost]
        public void AddNew([FromBody]EmployeeView model)
        {
            _employeesData.AddNew(model);
        }

        /// <inheritdoc />
        /// DELETE api/employees/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeesData.Delete(id);
        }
    }
}