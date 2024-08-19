using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using PMSDataAccess.Repository;

namespace PMS360.Controllers
{
    public class PMSUserManagementController : Controller
    {
        IPMSUserRepository objuserRepo = new PMSUserRepository();
        PMSContext _context = new PMSContext();
        public IActionResult Index()
        {
            
            List <UserDetail> lstuserDet=objuserRepo.GetUserDetails();
            return View(lstuserDet);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var roles = _context.RoleDetails.Select(r => new RoleDetail
            {
                RoleID = r.RoleID,
                RoleName = r.RoleName,
            }).ToList();
             ViewBag.roleids= new SelectList(roles, "RoleID", "RoleName");
            return View( );
        }

        [HttpPost]
        public IActionResult Create(UserDetail ud) 
        {
            Random rand = new Random();
            ud.Password = (rand.Next(10000, 99999)).ToString();
            string msg = objuserRepo.InsertUserDetails(ud);
            if ( msg.Equals("Success") )
            {
                return RedirectToAction("Index");
               
            }
            
            return View();
        }



    }
} 
