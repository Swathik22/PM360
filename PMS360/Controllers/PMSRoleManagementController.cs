using Microsoft.AspNetCore.Mvc;
using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using PMSDataAccess.Repository;
using System.Collections.Generic;

namespace PMS360.Controllers
{
    public class PMSRoleManagementController : Controller
    {
        IPMSRoleRepositroy objRoleRepo = new PMSRoleRepository();
        public IActionResult Index()
        {
            
            List<RoleDetail> lstroleDet = objRoleRepo.GetRoleDetails();
            return View(lstroleDet);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(RoleDetail RD) 
        {
            string msg=objRoleRepo.InsertRoleDetails(RD);
            if (msg.Equals("Success"))
            {
                
                return RedirectToAction("Index");

            }
            return View();
        }
    }
}
