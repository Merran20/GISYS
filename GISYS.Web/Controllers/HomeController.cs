using GISYS.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using GISYS.Web.Interfaces;

namespace GISYS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeInformation _employeeInformation;

        public HomeController(IEmployeeInformation employeeInformation)
        {
            _employeeInformation = employeeInformation;
        }

        public async Task<ActionResult> ListOfEmployees()
        {
            ViewBag.Result = await _employeeInformation.GetAllEmployees();

            return View();
        }

        public async Task<ActionResult> EmployeeDetails(int id)
        {
            ViewBag.Result = await _employeeInformation.GetSelectedEmployee(id); 

            return View();
        }




    }
}
