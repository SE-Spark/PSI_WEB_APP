﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSI_WEB_APP.Network.Repo;

namespace PSI_WEB_APP.Controllers
{
    public class OfficerController : Controller
    {
        private UnitOfWork unit = new UnitOfWork();
        public IActionResult Index()
        {
            return View(unit.OfficerRepository.get());
        }
        public ActionResult GetData()
        {
            return Json(new { data = unit.OfficerRepository.get() });
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Edit(object id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(IFormCollection collection)
        {
            return View();
        }
        public IActionResult Delete(object id)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            return View();
        }
    }
}