using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Abstract
{
    public interface IPMSRoleRepositroy
    {
        List<RoleDetail> GetRoleDetails();

        string InsertRoleDetails(RoleDetail RD);
    }
}
