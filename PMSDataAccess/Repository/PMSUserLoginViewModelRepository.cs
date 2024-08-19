using Microsoft.EntityFrameworkCore;
using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Repository
{
    public class PMSUserLoginViewModelRepository
    {
        PMSContext context = new PMSContext();

        public string PMSBusiness_VerifyUser(string userid, string password)
        {
            string msg = string.Empty;

            try
            {
                bool iuseridpresent = context.UserDetails.Any(user => user.UserID == userid);

                if (iuseridpresent)
                {
                    UserDetail currentuser = context.UserDetails.FirstOrDefault(user => user.UserID == userid);

                    if (currentuser.Password == password)
                    {
                        if (currentuser.PasswordChangeDate == null)
                        {

                            msg = "FirstLogin";
                        }
                        else
                        {
                            msg = "Success";
                        }
                    }
                    else
                    {
                        msg = "Wrong";
                    }

                }
                else
                {
                    msg = "User ID Not Found";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return msg;
        }

        public string PMSUserPasswordChangeForFirstLogin(PMSChangePasswordViewModel cpwd)
        {
            string msg = string.Empty;
            var olddata = context.UserDetails.FirstOrDefault(user => user.UserID == cpwd.UserID);
            
            if (olddata != null)
            {
                try
                {                   
                    olddata.Password= cpwd.NewPassword;
                    olddata.PasswordChangeDate= DateTime.Now;
                    context.SaveChanges();
                    msg = "Password Change Successfully";
                }
                catch (Exception ex)
                {
                    msg = "Password Not Updated";
                }

            }
                return msg;
        }
    }
}
