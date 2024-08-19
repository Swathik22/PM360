using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.RepoModal
{
    [Table("UserDetails")]
    public class UserDetail
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string UserID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string EmpID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        public int RoleID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool IsActive { get; set; }
        public DateTime? PasswordChangeDate { get; set; }


    }
}
