using HTC.Data;
using HTC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Collections.Generic;

namespace HTC.Controllers
{
    public class HCTScheduleController : Controller
    {
        // GET: HCTScheduleController
        public ActionResult Index()
        {
            MockHCTSCheduleForm newData = new MockHCTSCheduleForm();
            return View( newData.GetAll() );
        }

        // GET: HCTScheduleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HCTScheduleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HCTScheduleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HCTScheduleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HCTScheduleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HCTScheduleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HCTScheduleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
