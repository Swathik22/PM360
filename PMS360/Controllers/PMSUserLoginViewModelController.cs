using Microsoft.AspNetCore.Mvc;
using PMSDataAccess.RepoModal;
using PMSDataAccess.Repository;

namespace PMS360.Controllers
{
    public class PMSUserLoginViewModelController : Controller
    {
        PMSUserLoginViewModelRepository userlogin=new PMSUserLoginViewModelRepository();
        PMSContext _context= new PMSContext();
        [HttpGet]
        public IActionResult VerifyUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VerifyUser(string userid, string password)
        {
            string msg=userlogin.PMSBusiness_VerifyUser(userid, password);
            if (msg.Trim().ToLower().Equals("wrong"))
            {
                ViewBag.Info = "Wrong";
            }
            else
            {
                //HttpContext.Session.SetString("userid", userid);
                if (msg == "FirstLogin")
                {
                    TempData["UserID"] = userid; //storing user id in tempdata
                    return RedirectToAction("PasswordChange");
                }
                else if (msg == "success")
                {
                    return RedirectToAction("Index", "PMSUserManagement");
                }
                ViewBag.Info = msg;
            }
            return View();

        }
        [HttpGet]
        public IActionResult PasswordChange()
        {

            return View();
        }
        [HttpPost]
        public IActionResult PasswordChange(PMSChangePasswordViewModel cp)
        {
            string msg=userlogin.PMSUserPasswordChangeForFirstLogin(cp);
            if (msg.Trim().ToLower().Equals("passwordchangesuccessfully"))
            {
                return RedirectToAction("UserHomepage");
            }
            else
            {
                return RedirectToAction("VerifyUser");
            }
                return View();
        }

    }
}
