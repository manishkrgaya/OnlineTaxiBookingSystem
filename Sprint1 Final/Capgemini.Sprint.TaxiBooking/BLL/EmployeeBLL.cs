using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;
using DAL;
using UserException;

namespace BLL
{
    public class EmployeeBLL
    {
        public string BookingID;
        public string TripDate;
        EmployeeDAL edal = new EmployeeDAL();

        public int AddNewEmployee(string employeeName,string phoneNumber, string emailID, string address, string drivingLicenceNumber, string loginID, string password)
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                int result = dal.AddNewEmployee(employeeName,phoneNumber, emailID, address, drivingLicenceNumber, loginID, password);
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

        public int ChangeUsersPassword(string loginID, string password)
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                int result = dal.ChangeUsersPassword(loginID, password);
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

        public List<Users> GetEmployeesDetails()
        {
            try
            {
                AdminDAL dal = new AdminDAL();
                var result = dal.GetEmployeesDetails();
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

        public List<Booking> GetAllBookingStatus(DateTime TripDate)
        {
            var bookingss = edal.GetAllBookingStatus(TripDate);
            return bookingss;
        }


        public List<Booking> GetAllBookingAvailableDetails()
        {
            var bookingss = edal.GetAllBookingAvailableDetails();
            return bookingss;
        }

        public List<Taxi> GetTaxiDetails()
        {
            var taxiess = edal.GetTaxiDetails();
            return taxiess;
        }

        public int UpdateBooking(int EmployeeID, int TaxiID, int BookingID)
        {
            try
            {
                int result = edal.UpdateBooking(EmployeeID, TaxiID, BookingID);
                return result;
            }
            catch (TaxiBookingException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EmployeeRoaster> GetAllEmployeeRoasterDetails(int EmployeeID)
        {
            try
            {
                var roasterss = edal.GetAllEmployeeRoasterDetails(EmployeeID);

                return roasterss;
            }
            catch (TaxiBookingException ex)
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
