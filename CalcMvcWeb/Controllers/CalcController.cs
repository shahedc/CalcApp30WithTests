using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcMvcWeb.Models;
using CalcMvcWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalcMvcWeb.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Process(CalcViewModel model)
        {
            var cs = new CalcService();
            var result = cs.AddNumbers(model.Number1, model.Number2);
            model.Result = result;
            return View(model);
        }


        [HttpPost]
        public ActionResult Add(CalcViewModel model)
        {
            var cs = new CalcService();
            var result = cs.AddNumbers(model.Number1, model.Number2);
            model.Result = result;
            return View("Process", model);
        }

        [HttpPost]
        public ActionResult Subtract(CalcViewModel model)
        {
            var cs = new CalcService();
            var result = cs.SubtractNumbers(model.Number1, model.Number2);
            model.Result = result;
            return View("Process", model);
        }

        [HttpPost]
        public ActionResult Multiply(CalcViewModel model)
        {
            var cs = new CalcService();
            var result = cs.MultiplyNumbers(model.Number1, model.Number2);
            model.Result = result;
            return View("Process", model);
        }

        [HttpPost]
        public ActionResult Divide(CalcViewModel model)
        {
            var cs = new CalcService();
            var result = cs.SafeDivide(model.Number1, model.Number2);
            model.Result = result;
            return View("Process", model);
        }
    }
}