using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Abstract
{
    public interface IPMSUserLoginViewModelREpository
    {
        string PMSBusiness_VerifyUser(string userid, string password);

        string PMSUserPasswordChangeForFirstLogin(PMSChangePasswordViewModel pwd);
    }
}
