using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using UserException;
using TaxiEntities;

namespace BLL
{
    public class RoasterBLL
    {
        public List<EmployeeEntity> GetAvailableEmployees()
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                var result = dal.GetAvailableEmployees();
                return result;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CreateRoster(int empID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                int result = dal.CreateRoster(empID, fromDate, toDate);
                return result;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
