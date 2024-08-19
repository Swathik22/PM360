using Microsoft.AspNetCore.Mvc;
using PMSDataAccess.Abstract;
using PMSDataAccess.Migrations;
using PMSDataAccess.RepoModal;
using PMSDataAccess.Repository;

namespace PMS360.Controllers
{
    public class PMSAssessmentController : Controller
    {
        IPMSAssessmentRepository _AsstRep=new PMSAssessmentRepository();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AssessmentPage() 
        { 
         
            return View();
        }
        [HttpPost]
        public IActionResult AssessmentPage(AssessmentDetail assmtdetail)
        {
           string msg= _AsstRep.InsertAssessmentDetails(assmtdetail);
            if (msg.Trim().Equals("Success"))
            {
                ViewBag.Status = "Assessment Added Successfully";
                return RedirectToAction("AssessmentPage");
            }
            return View();
        }
    }
}
