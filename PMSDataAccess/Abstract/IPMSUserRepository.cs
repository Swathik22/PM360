using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Abstract
{
    public interface IPMSUserRepository
    {
        List<UserDetail> GetUserDetails();
        string InsertUserDetails(UserDetail ud);
    }
}
