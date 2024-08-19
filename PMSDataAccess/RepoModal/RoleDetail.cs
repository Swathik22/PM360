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
    [Table("RoleDetails")]
    public class RoleDetail
    {
        [Key]
        public int RoleID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string RoleName { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
