using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.RepoModal
{
    public class UserLoginViewModel
    {
        [Required]
        public string UserID { get; set;}
        [Required]
        public string Password { get; set; }
        
    }
}
