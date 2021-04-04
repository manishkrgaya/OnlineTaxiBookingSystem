using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;
using UserException;

namespace DAL
{
    public class AdminDAL
    {

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private List<Users> user = null;
        private List<EmployeeEntity> availableEmployee = null;
        private List<Booking> bookings = null;

        public int AddNewEmployee(string employeeName, string phoneNumber, string emailID, string address, string drivingLicenceNumber, string loginID, string password)
        {
            try
            {
                int res;
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_InsertIntoEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                cmd.Parameters.AddWithValue("@Designation", "Driver");
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@EmailID", emailID);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@DrivingLicenseNumber", drivingLicenceNumber);

                res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT ident_current('Employee')", con);
                    var empID = cmd1.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand("usp_InsertIntoUsersEmployee", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@LoginID", loginID);
                    cmd2.Parameters.AddWithValue("@Password", password);
                    cmd2.Parameters.AddWithValue("@EmployeeID", empID);
                    cmd2.Parameters.AddWithValue("@Role", "Employee");
                    res = cmd2.ExecuteNonQuery();
                }
                return res;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int ChangeUsersPassword(string loginID, string password)
        {
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_UpdateUsersPassword", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                cmd.Parameters.AddWithValue("@LoginID", loginID);
                cmd.Parameters.AddWithValue("@Password", password);

                int result = cmd.ExecuteNonQuery();
                return result;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {

                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int AddNewUser(string loginId, string password, string role)
        {
            int result = 0;
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_InsertUserLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                cmd.Parameters.AddWithValue("@LoginID", loginId);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);


                result = cmd.ExecuteNonQuery();
                if (cmd != null)
                {
                    cmd.Dispose();
                }

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        return -1;
                    default:
                        return -1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (con != null)
            {
                con.Close();
            }

            return result;

        }

        public List<Users> GetAllUser(string loginID, string password, string role)
        {
            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("SELECT LoginID, Password, (CASE WHEN EmployeeID IS NULL THEN 0 ELSE EmployeeID END) AS EmployeeID,(CASE WHEN CustomerID IS NULL THEN 0 ELSE CustomerID END) AS CustomerID,Role FROM USERS where LoginID='" + loginID + "'" + " and Password='" + password + "'" + " and Role='" + role + "'", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        user = new List<Users>();
                        while (reader.Read())
                        {
                            Users entity = new Users
                            {
                                LoginID = reader[0].ToString(),
                                Password = reader[1].ToString(),
                                EmployeeId = (int)reader[2],
                                CustomerID = (int)reader[3],
                                Role = reader[4].ToString(),
                            };
                            user.Add(entity);
                        }
                    }
                    reader.Close();
                }
            }
            return user;
        }

        public List<Users> GetCustomersDetails()
        {
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_GetCustomerDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    user = new List<Users>();
                    while (reader.Read())
                    {
                        Users userEntity = new Users
                        {
                            LoginID = reader[0].ToString(),
                            Password = reader[1].ToString(),
                            CustomerID = (int)reader[2],
                            Role = reader[3].ToString()
                        };
                        user.Add(userEntity);
                    }
                }

                reader.Close();
                return user;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<Users> GetEmployeesDetails()
        {
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_GetEmployeeDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    user = new List<Users>();
                    while (reader.Read())
                    {
                        Users userEntity = new Users
                        {
                            LoginID = reader[0].ToString(),
                            Password = reader[1].ToString(),
                            EmployeeId = (int)reader[2],
                            Role = reader[3].ToString(),
                        };
                        user.Add(userEntity);
                    }
                }

                reader.Close();
                return user;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<EmployeeEntity> GetAvailableEmployees()
        {
            try
            {
                int empID;
                string empName;
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_GetAvailableEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    availableEmployee = new List<EmployeeEntity>();
                    while (reader.Read())
                    {
                        empID = Convert.ToInt32(reader["EmployeeID"]);
                        empName = reader["EmployeeName"].ToString();
                        availableEmployee.Add(new EmployeeEntity
                        {
                            EmployeeID = empID,
                            EmployeeName = empName
                        });
                    }

                }
                reader.Close();
                return availableEmployee;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }

        }

        public int CreateRoster(int empID, DateTime fromDate, DateTime toDate)
        {
            try
            {
                int res;
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_CreateRoster", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@EmployeeID", empID);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                cmd.Parameters.AddWithValue("@InTime", "00:00:00");
                cmd.Parameters.AddWithValue("@OutTime", "00:00:00");

                res = cmd.ExecuteNonQuery();
                return res;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

        }

        public List<Booking> GetDailyReport()
        {
            string conStr = DataConnection.GetConnectionString();
            try
            {
                using (con = new SqlConnection(conStr))
                {
                    using (cmd = new SqlCommand("usp_GetDailyBookingReport", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            bookings = new List<Booking>();
                            while (reader.Read())
                            {
                                Booking entity = new Booking
                                {
                                    BookingID = Convert.ToInt32(reader["BookingID"]),
                                    CustomerID = Convert.ToInt32(reader["CustomerID"].ToString()),
                                    EmployeeID = Convert.ToInt32(reader["EmployeeID"].ToString()),
                                    TaxiID = Convert.ToInt32(reader["TaxiID"]),
                                    BookingDate = Convert.ToDateTime(reader["BookingDate"].ToString()),
                                    TripDate = Convert.ToDateTime(reader["TripDate"].ToString()),
                                    StartTime = Convert.ToDateTime(reader["StartTime"].ToString()),
                                    EndTime = Convert.ToDateTime(reader["EndTime"].ToString()),
                                    SourceAddress = reader["SourceAddress"].ToString(),
                                    DestinationAddress = reader["DestinationAddress"].ToString()
                                };
                                bookings.Add(entity);
                            }
                        }

                        else
                        {
                            throw new TaxiBookingException("No Booking available for the selected date ");
                        }
                        reader.Close();
                    }
                }
                return bookings;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public List<Booking> GetWeelkyOrMonthlyReport(DateTime FromDate, DateTime ToDate)
        {
            string conStr = DataConnection.GetConnectionString();
            try
            {
                using (con = new SqlConnection(conStr))
                {
                    using (cmd = new SqlCommand("usp_GetWeeklyOrMonthlyBookingReport", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FromDate", FromDate);
                        cmd.Parameters.AddWithValue("@ToDate", ToDate);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            bookings = new List<Booking>();
                            while (reader.Read())
                            {
                                Booking entity = new Booking
                                {
                                    BookingID = Convert.ToInt32(reader["BookingID"]),
                                    CustomerID = Convert.ToInt32(reader["CustomerID"].ToString()),
                                    EmployeeID = Convert.ToInt32(reader["EmployeeID"].ToString()),
                                    TaxiID = Convert.ToInt32(reader["TaxiID"]),
                                    BookingDate = Convert.ToDateTime(reader["BookingDate"].ToString()),
                                    TripDate = Convert.ToDateTime(reader["TripDate"].ToString()),
                                    StartTime = Convert.ToDateTime(reader["StartTime"].ToString()),
                                    EndTime = Convert.ToDateTime(reader["EndTime"].ToString()),
                                    SourceAddress = reader["SourceAddress"].ToString(),
                                    DestinationAddress = reader["DestinationAddress"].ToString()
                                };
                                bookings.Add(entity);
                            }
                        }
                        reader.Close();
                    }
                }
                return bookings;
            }

            catch (SqlException ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            catch (Exception ex)
            {
                throw new TaxiBookingException(ex.Message, ex);
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}