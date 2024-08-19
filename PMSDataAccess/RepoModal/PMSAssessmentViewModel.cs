using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.RepoModal
{
    public class PMSAssessmentViewModel
    {
        public int AssessmentID { get; set; }       
        public string AssessmentName { get; set; }
        public bool IsActive { get; set; }
    }
}
