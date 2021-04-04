using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;

namespace DAL
{
    public class CustomerDAL
    {

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        //private List<EmployeeEntity> emp = null;
        private List<Booking> Bookings = null;

        public int AddNewCustomer(string customerName, string phoneNumber, string emailID, string address, string loginID)
        {
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_InsertIntoCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }

                cmd.Parameters.AddWithValue("@CustomerName", customerName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@EmailID", emailID);
                cmd.Parameters.AddWithValue("@Address", address);
                
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT ident_current('Customer')", con);
                    var customerID = cmd1.ExecuteScalar();
                    SqlCommand cmd2 = new SqlCommand("usp_RegisterCustomer", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@LoginID", loginID);
                    cmd2.Parameters.AddWithValue("@CustomerID", customerID);
                    result = cmd2.ExecuteNonQuery();

                    if (cmd1 != null)
                    {
                        cmd1.Dispose();
                    }
                    if (cmd2 != null)
                    {
                        cmd2.Dispose();
                    }
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                
                if (con != null)
                {
                    con.Close();
                }

                return result;

            }
            catch (SqlException ex)
            {
                //    throw new PositionException(ex.Message, ex);
                throw ex;

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

        public DataTable GetAllEmployee(DateTime BookingDate, int CustomerId)
        {
            DataTable dt;
            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("select booking.BookingID,booking.BookingDate,emp.EmployeeName,emp.Designation,emp.PhoneNumber,emp.EmailID,emp.DrivingLicenseNumber,emp.Address from Employee emp join Booking booking on Booking.EmployeeID = emp.EmployeeID where booking.BookingDate = '" + BookingDate + "'" + " and booking.CustomerID ='" + CustomerId + "'", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtSchema = reader.GetSchemaTable();
                    dt = new DataTable();

                    List<DataColumn> listCols = new List<DataColumn>();

                    if (dtSchema != null)
                    {
                        foreach (DataRow drow in dtSchema.Rows)
                        {
                            string columnName = System.Convert.ToString(drow["ColumnName"]);
                            DataColumn column = new DataColumn(columnName, (Type)(drow["DataType"]));
                            column.Unique = (bool)drow["IsUnique"];
                            column.AllowDBNull = (bool)drow["AllowDBNull"];
                            column.AutoIncrement = (bool)drow["IsAutoIncrement"];
                            listCols.Add(column);
                            dt.Columns.Add(column);
                        }
                    }

                    while (reader.Read())
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int i = 0; i < listCols.Count; i++)
                        {
                            dataRow[((DataColumn)listCols[i])] = reader[i];
                        }
                        dt.Rows.Add(dataRow);
                    }

                    reader.Close();
                }
            }
            return dt;
        }


        public int AddNewBooking(int customerId, DateTime tripDate, DateTime startTime, DateTime endTime, string sourceAddress, string destinationAddress,double fare)
        {
            try
            {
                string conStr = DataConnection.GetConnectionString();
                con = new SqlConnection(conStr);
                cmd = new SqlCommand("usp_InsertIntoBooking", con);
                cmd.CommandType = CommandType.StoredProcedure;

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
               // cmd.Parameters.AddWithValue("@BookingDate", BookingDate);
                cmd.Parameters.AddWithValue("@TripDate", tripDate);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.Parameters.AddWithValue("@SourceAddress", sourceAddress);
                cmd.Parameters.AddWithValue("@DestinationAddress", destinationAddress);
                cmd.Parameters.AddWithValue("@Fare", fare);

                int result = cmd.ExecuteNonQuery();
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

        public List<Booking> CheckBookingStatus(int customerID)
        {
            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("select * from Booking Where @CustomerID=" + customerID, con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Bookings = new List<Booking>();
                        while (reader.Read())
                        {
                            Booking entity = new Booking
                            {
                                BookingID = (int)reader["BookingID"],
                                CustomerID = (int)reader["CustomerID"],
                                TaxiID = (int)reader["TaxiID"],
                                BookingDate = (DateTime)reader["BookingDate"],
                                TripDate = (DateTime)reader["TripDate"],
                                StartTime = (DateTime)reader["StartTime"],
                                EndTime = (DateTime)reader["EndTime"],
                                SourceAddress = reader["SourceAddress"].ToString(),
                                DestinationAddress = reader["DestinationAddress"].ToString(),
                                Fare = (double)reader["Fare"]
                            };
                            Bookings.Add(entity);
                        }
                    }
                    reader.Close();
                }
            }
            return Bookings;
        }


        public List<Booking> GetBookings(DateTime StartDate, DateTime EndDate, int CustomerID)
        {
            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("select * from Booking where customerid='" + CustomerID + "'" + " and TripDate Between '" + StartDate + "'" + " and '" + EndDate + "'", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    int Employeeid = 0;
                    int taxiid = 0;
                    if (reader.HasRows)
                    {
                        Bookings = new List<Booking>();
                        while (reader.Read())
                        {
                            if (reader["EmployeeID"] != DBNull.Value)
                                Employeeid = (int)reader["EmployeeID"];
                            else Employeeid = 0;
                            if (reader["TaxiID"] != DBNull.Value)
                                taxiid = (int)(int)reader["TaxiID"];
                            else taxiid = 0;
                            Booking entity = new Booking
                            {
                                BookingID = (int)reader["BookingID"],
                                EmployeeID = Employeeid,
                                CustomerID = (int)reader["CustomerID"],
                                TaxiID = taxiid,
                                BookingDate = (DateTime)reader["BookingDate"],
                                TripDate = (DateTime)reader["TripDate"],
                                //StartTime = (DateTime)reader["StartTime"],
                                //EndTime = (DateTime)reader["EndTime"],
                                SourceAddress = reader["SourceAddress"].ToString(),
                                DestinationAddress = reader["DestinationAddress"].ToString(),
                                //Fare = (double)reader["Fare"]
                            };
                            Bookings.Add(entity);
                        }
                    }
                    reader.Close();
                }
            }
            return Bookings;
        }





    }
}
