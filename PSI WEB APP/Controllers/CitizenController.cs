using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSI_WEB_APP.Models;
using PSI_WEB_APP.Network.Repo;

namespace PSI_WEB_APP.Controllers
{
    public class CitizenController : Controller
    {
        private UnitOfWork unit = new UnitOfWork();
        
        // GET: Citizen
        public ActionResult Index()
        {
            var data = unit.CitizenRepository.get();
            return View(data);
        }

        // GET: Citizen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Citizen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Citizen/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Citizen/Edit/5
        public ActionResult Edit(Guid id)
        {
            var item = unit.CitizenRepository.get(id);
            return View(item);
        }

        // POST: Citizen/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Citizen ct)
        {
            try
            {
                unit.CitizenRepository.update(ct);

                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Citizen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Citizen/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}