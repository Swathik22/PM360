using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using PMSDataAccess.Repository;

namespace PMS360.Controllers
{
    public class PMSScheduleAssessmentController : Controller
    {
        IPMSAssessmentRepository assrepo=  new PMSAssessmentRepository();
        PMSContext context= new PMSContext();
        [HttpGet]
        public IActionResult ScheduleAssessment()
        {
            List<PMSAssessmentViewModel> lstassmtvm= assrepo.GetPMSAssessmentViewModels();
            List<SelectListItem> lstvm = new List<SelectListItem>();
            if (lstassmtvm.Count > 0)
            {
                foreach (PMSAssessmentViewModel assmtvm in lstassmtvm)
                {
                    SelectListItem item = new SelectListItem();
                    
                    item.Value = assmtvm.AssessmentID.ToString();
                    item.Text = assmtvm.AssessmentName.ToString();
                    lstvm.Add(item);
                }
            }

            ViewBag.AssmtVM = lstvm;

            return View();

        }
        [HttpPost]
        public IActionResult ScheduleAssessment(PMSAssessmentViewModel asmt)
        {
            
            string msg=assrepo.ActivateAssessment(asmt);
            if (msg.Equals("Success"))
            {
                return RedirectToAction("ScheduleAssessment");
            }

            return View();
            
        }
    }
}
