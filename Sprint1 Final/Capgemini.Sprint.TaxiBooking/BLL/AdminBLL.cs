using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;
using DAL;


namespace BLL
{
    public class AdminBLL
    {
        public int AddNewUser(string loginId, string password, string role)
        {            
                AdminDAL dal = new AdminDAL();
                int result = dal.AddNewUser(loginId, password,  role);
                return result;
           
            
        }

        public List<Users> GetAllUser(string loginID, string password, string role)
        {
            AdminDAL dAL = new AdminDAL();
            var us = dAL.GetAllUser(loginID,password,role);
            return us;
        }
    }
}
