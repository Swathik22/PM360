using Microsoft.EntityFrameworkCore;
using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Repository
{
    public class PMSRoleRepository: IPMSRoleRepositroy
    {
        PMSContext _context = new PMSContext();
        public List<RoleDetail> GetRoleDetails()
        {
            List<RoleDetail> lstRoleDetails = new List<RoleDetail>();

            try
            {
                lstRoleDetails = _context.RoleDetails?.ToList();
            }
            catch (Exception ex)
            { }

            return lstRoleDetails;
        }

        //Inserting UserDetails to DB
        public string InsertRoleDetails(RoleDetail RD)
        {
            string msg = string.Empty;

            try
            {
                _context.RoleDetails.Add(RD);//dbset is updated
                _context.SaveChanges();//db is updated

                if (RD.RoleID > 0)
                {
                    msg = "Success";
                }
                else
                {
                    msg = "Failed";
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return msg;
        }
    }
}
