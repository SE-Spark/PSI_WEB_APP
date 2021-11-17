using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSI_WEB_APP.Models;
using PSI_WEB_APP.Network.Mappers;
using PSI_WEB_APP.Network.Repo;

namespace PSI_WEB_APP.Controllers
{
    public class CitizenController : Controller
    {
        private UnitOfWork unit = new UnitOfWork();

        // GET: Citizen
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            var data = unit.CitizenRepository.get();
            CitizenMapper mapper = new CitizenMapper();
            var citizens=mapper.MapToDomainList(data);
            return Json(new { data = citizens });
        }
        [HttpGet]
        public ActionResult AddorEdit(String id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return View(new Citizen());
            }
            else
            {
                var data = unit.CitizenRepository.get(Guid.Parse(id));
                CitizenMapper mapper = new CitizenMapper();
                var citizen = mapper.MapToDomain(data);
                return View(citizen);
            }
        }
        [HttpPost]
        public ActionResult AddorEdit(Citizen ct)
        {
            CitizenMapper mapper = new CitizenMapper();
            var input = mapper.MapToDto(ct);
            if (input.Id == Guid.Parse("00000000-0000-0000-0000-000000000000"))
            {
                //insert
                var output= unit.CitizenRepository.insert(input);
                if(output==1)
                    return Json(new { success = true, message = "Added Successfully" }, new Newtonsoft.Json.JsonSerializerSettings());
                return Json(new { success = false, message = "process failed" },new Newtonsoft.Json.JsonSerializerSettings());
            }
            else
            {
                //update
                var output = unit.CitizenRepository.update(input.Id,input);
                if (output == 1)
                    return Json(new { success = true, message = "Updated Successfully" }, new Newtonsoft.Json.JsonSerializerSettings());
                return Json(new { success = false, message = "process failed" }, new Newtonsoft.Json.JsonSerializerSettings());
            }

        }
        [HttpPost]
        public ActionResult Delete(String id)
        {
            unit.CitizenRepository.delete(Guid.Parse(id));
            return Json(new { success = true, message = "Deleted Successfully" }, new Newtonsoft.Json.JsonSerializerSettings());
        }
     
        // POST: Citizen/Delete/5
        
    }
}