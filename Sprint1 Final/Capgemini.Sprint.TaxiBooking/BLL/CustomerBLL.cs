using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class CustomerBLL
    {
        public DataTable GetAllEmployee(DateTime bookingDate, int customerId)
        {
            CustomerDAL dAL = new CustomerDAL();
            var emp = dAL.GetAllEmployee(bookingDate, customerId);
            return emp;
        }

        public int AddNewCustomer(string customerName, string phoneNumber, string emailId, string address, string loginID)
        {
            try
            {
                CustomerDAL dal = new CustomerDAL();
                int result = dal.AddNewCustomer(  customerName, phoneNumber,  emailId,  address, loginID);
                return result;
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddNewBooking(int customerId, DateTime tripDate, DateTime startTime, DateTime endTime, string sourceAddress, string destinationAddress,double Fare)
        {
            try
            {
                CustomerDAL dal = new CustomerDAL();
                int result = dal.AddNewBooking(customerId, tripDate, startTime, endTime, sourceAddress, destinationAddress,Fare);
                return result;
            }
           
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Booking> CheckBookingStatus(int customerID)
        {
            CustomerDAL cdal = new CustomerDAL();
            var Bookings = cdal.CheckBookingStatus(customerID);
            return Bookings;

        }

        public List<Booking> GetBookings(DateTime StartDate, DateTime EndDate, int CustomerID)
        {
            CustomerDAL dAL = new CustomerDAL();
            var emp = dAL.GetBookings(StartDate, EndDate, CustomerID);
            return emp;
        }

        public List<Users> GetCustomersDetails()
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                var result = dal.GetCustomersDetails();
                return result;
            }

            catch (SqlException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

