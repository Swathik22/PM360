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
    public class AssessmentDetail
    {
        [Key]
        public int AssessmentID { get; set; }
        [Required]  
        public string AssessmentName { get; set; }

        public DateTime AssmtDate { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
