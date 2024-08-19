using PMSDataAccess.Abstract;
using PMSDataAccess.RepoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccess.Repository
{
    public class PMSUserRepository : IPMSUserRepository
    {
        PMSContext _context = new PMSContext();

        //Fetching user Details from DB
        public List<UserDetail> GetUserDetails()
        {
            List<UserDetail> lstUserDetails = new List<UserDetail>();

            try 
            {
                lstUserDetails= _context.UserDetails.ToList();
            }
            catch (Exception ex) 
            { }

            return lstUserDetails;
        }

        //Inserting UserDetails to DB
        public string InsertUserDetails(UserDetail UD)
        {
            string msg=string.Empty;

            try 
            {
                _context.UserDetails.Add(UD);//dbset is updated
                _context.SaveChanges();//db is updated

                if (UD.ID > 0)
                {
                    msg = "Success";
                }
                else
                {
                    msg = "Failed";
                }
            } 
            catch (Exception ex) {

                msg = ex.Message;
            }
            return msg;
        }

    }
}
