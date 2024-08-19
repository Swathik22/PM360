using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Abstract
{
    public interface IPMSAssessmentRepository
    {
        string InsertAssessmentDetails(AssessmentDetail asmt);

        string ActivateAssessment(PMSAssessmentViewModel activasmt);
        List<PMSAssessmentViewModel> GetPMSAssessmentViewModels();
    }
}
