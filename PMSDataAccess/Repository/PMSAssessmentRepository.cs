using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Repository
{    
    public class PMSAssessmentRepository: IPMSAssessmentRepository
    {
        PMSContext context=new PMSContext();
        public string InsertAssessmentDetails(AssessmentDetail asmt)
        {
            string msg = string.Empty;
            try
            {
                context.AssessmentDetails.Add(asmt);
                context.SaveChanges();
                if (asmt.AssessmentID > 0)
                {
                    msg = "Success";
                }
                else
                {
                    msg = "Failed";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public List<PMSAssessmentViewModel> GetPMSAssessmentViewModels()
        {
            List<PMSAssessmentViewModel> lstassmtVM= new List<PMSAssessmentViewModel>();
            List<AssessmentDetail> lstasmtDetails= new List<AssessmentDetail>();
            
            try 
            {
                lstasmtDetails = context.AssessmentDetails.ToList();
                lstassmtVM= lstasmtDetails.Select(x => new PMSAssessmentViewModel()
                                                {
                                                    AssessmentID = x.AssessmentID,
                                                    AssessmentName = x.AssessmentName,
                                                    IsActive = x.IsActive,

                                                }).ToList();
               
            }
            catch(Exception ex) 
            {
                
            }



            return lstassmtVM;
        }

        public string ActivateAssessment(PMSAssessmentViewModel activasmt)
        {
            string msg = string.Empty;
            try
            {
                AssessmentDetail oldassmt = context.AssessmentDetails.FirstOrDefault(ass => ass.AssessmentID == activasmt.AssessmentID);
                oldassmt.IsActive = activasmt.IsActive;
                //Updating all other Assessments to 0
                context.AssessmentDetails.Where(ass => ass.AssessmentID != activasmt.AssessmentID).ToList().ForEach(ass => ass.IsActive = false);
                context.SaveChanges();
                msg = "Success";
            }
            catch (Exception ex)
            {
                msg = "Failed";
            }
            
            return msg;
        }
    }
}
