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
    public class EmployeeDAL
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private List<Booking> bookings = null;
        private List<EmployeeRoaster> roasters = null;

        public List<EmployeeRoaster> GetAllEmployeeRoaster()
        {
            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("Select * from EmployeeRoster", con))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        roasters = new List<EmployeeRoaster>();
                        while (reader.Read())
                        {
                            EmployeeRoaster roasterentity = new EmployeeRoaster
                            {
                                RosterID = (int)reader["BookingID"],
                                EmployeeID = (int)reader["CustomerID"],
                                FromDate = (DateTime)reader["BookingDate"],
                                ToDate = (DateTime)reader["TripDate"],
                                InTime = (DateTime)reader["StartTime"],
                                OutTime = (DateTime)reader["EndTime"],

                            };
                            roasters.Add(roasterentity);
                        }
                    }
                    reader.Close();
                }
            }
            return roasters;

        }

        public List<Taxi> taxies { get; private set; }

        public List<Booking> ubooking { get; private set; }
        public List<Booking> bookingss { get; private set; }

        public List<Booking> GetAllBookingStatus(DateTime TripDate)
        {
            string conStr = DataConnection.GetConnectionString();
            try
            {
                using (con = new SqlConnection(conStr))
                {
                    using (cmd = new SqlCommand("usp_GetBookingStatus", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TripDate", TripDate);

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
        /// <summary>
        /// this methos will return booking table to show booking details(3.1)
        /// </summary>
        /// <returns></returns>
        public List<Booking> GetAllBookingAvailableDetails()
        {

            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("usp_AvailableBooking ", con))
                    cmd.CommandType = CommandType.StoredProcedure;

                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        bookingss = new List<Booking>();
                        while (reader.Read())
                        {
                            Booking entity1 = new Booking
                            {
                                BookingID = Convert.ToInt32(reader["BookingID"]),


                                EmployeeID = Convert.ToInt32(reader["EmployeeID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["EmployeeID"])),
                                TaxiID = Convert.ToInt32(reader["TaxiID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TaxiID"])),
                                CustomerID = Convert.ToInt32(reader["CustomerID"]),

                                BookingDate = Convert.ToDateTime(reader["BookingDate"]),
                                TripDate = Convert.ToDateTime(reader["TripDate"].ToString()),
                                StartTime = Convert.ToDateTime(reader["StartTime"].ToString()),
                                EndTime = Convert.ToDateTime(reader["EndTime"].ToString()),
                                SourceAddress = reader["SourceAddress"].ToString(),
                                DestinationAddress = reader["DestinationAddress"].ToString()

                            };
                            bookingss.Add(entity1);
                        }
                    }
                    reader.Close();

                }
            }
            return bookingss;
        }

        public List<EmployeeRoaster> GetAllEmployeeRoasterDetails(int EmployeeID)
        {

            string conSt = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conSt))
            {
                using (cmd = new SqlCommand("usp_GetAllemployeeRoaster", con))
                    cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        roasters = new List<EmployeeRoaster>();
                        while (reader.Read())
                        {
                            EmployeeRoaster roasterentity = new EmployeeRoaster
                            {
                                RosterID = Convert.ToInt32(reader["RosterID"].ToString()),
                                EmployeeID = Convert.ToInt32(reader["EmployeeID"].ToString()),
                                FromDate = Convert.ToDateTime(reader["FromDate"].ToString()),
                                ToDate = Convert.ToDateTime(reader["ToDate"].ToString()),
                                InTime = Convert.ToDateTime(reader["InTime"].ToString()),
                                OutTime = Convert.ToDateTime(reader["OutTime"].ToString()),

                            };
                            roasters.Add(roasterentity);
                        }
                    }
                    reader.Close();
                }
            }
            return roasters;
        }


        /// <summary>
        /// this method will show taxi details available for booking(3.2)
        /// </summary>
        /// <returns></returns>
        public List<Taxi> GetTaxiDetails()
        {

            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("usp_TaxiAvailability", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    taxies = new List<Taxi>();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            Taxi ent = new Taxi
                            {
                                TaxiID = Convert.ToInt32(reader["TaxiID"]),
                                TaxiModel = reader["TaxiModel"].ToString(),
                                Color = reader["Color"].ToString(),
                                RegistrationNumber = reader["Registration Number"].ToString(),
                                TaxiType = reader["TaxiType"].ToString(),

                            };
                            taxies.Add(ent);
                        }
                    }
                    reader.Close();
                }
            }
            return taxies;
        }

        /// <summary>
        /// (3.3)
        /// 
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="TaxiID"></param>
        /// <param name="BookingID"></param>
        /// <returns></returns>
        public int UpdateBooking(int EmployeeID, int TaxiID, int BookingID)
        {


            string conStr = DataConnection.GetConnectionString();
            using (con = new SqlConnection(conStr))
            {
                using (cmd = new SqlCommand("usp_UpdateBooking", con))
                    cmd.CommandType = CommandType.StoredProcedure;
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@TaxiID", TaxiID);
                    cmd.Parameters.AddWithValue("@BookingID", BookingID);


                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
