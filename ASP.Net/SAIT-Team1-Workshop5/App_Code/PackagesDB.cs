using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   //Brodie Zoschke Code starts
    //edited February 2nd 2015
    [DataObject(true)]
    public class PackagesDB
    {
        public static double getpkgtotal(int custid)
        {
           // int Id = Convert.ToInt32(custid);

           List<PackagesWBooking> p = GetPackagesFromCustomers(custid);

           double total = p.Sum(item => item.PkgBasePrice);


           return total;
        }


        //new add package method 
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int AddPackages(Packages package)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement = "Insert package " +
                                     "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                     "VALUES (@pkgname, @pkgstartdate, @pkgenddate, @pkgDesc, @pkgbaseprice, @pkgagencycommission)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@pkgname", package.PkgName);
            insertCommand.Parameters.AddWithValue("@pkgstartdate", package.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@pkgenddate", package.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@pkgDesc", package.PkgDesc);
            insertCommand.Parameters.AddWithValue("@pkgbaseprice", package.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@pkgagencycommission", package.PkgAgencyCommission);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                //based on the assumption that the packages with auto increment when created
                string selectStatement = "SELECT IDENT_CURRENT('Packages') FROM Packages";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int packageId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return packageId;
                

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }



        }
        
        //get packages with the bookingdate using the booking id
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<PackagesWBooking> GetPackagesWithBookingDate(int bookingId) 
        {
            //create a list using the packages with dates objects
            List<PackagesWBooking> packagesWBookings = new List<PackagesWBooking>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //select statement with inner join to get the booking date
            string selectStatement = "SELECT PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, BookingDate " +
                                     "FROM Packages p INNER JOIN Bookings b on b.PackageId = p.PackageId Where BookingId = @bookingId";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@bookingId", bookingId);


            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();
                //while reader is executing 
                while (reader.Read())
                {
                    //create a new package with booking object 
                    PackagesWBooking p = new PackagesWBooking();
                    //fill the object values with using the reader and converting to proper data types
                    p.PkgName = reader["PkgName"].ToString();
                    p.PkgStartDate = reader["PkgStartDate"].ToString();
                    p.PkgEndDate = reader["PkgEndDate"].ToString();
                    p.PkgDesc = reader["PkgDesc"].ToString();
                    p.PkgBasePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                    p.PkgAgencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);
                    p.BookingDate= reader["BookingDate"].ToString();
                    //add new object to the list created
                    packagesWBookings.Add(p);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            //return the list 
            return packagesWBookings;

        }

        //variation of the get packages class that returns just the packages in the database and only using the columns of the table
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Packages> GetAllPackages()
        {
            List<Packages> packages = new List<Packages>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            
            


            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();
                

                while (reader.Read())
                {
                    Packages p = new Packages();
                    p.PkgName = reader["PkgName"].ToString();
                    p.PkgStartDate = reader["PkgStartDate"].ToString();
                    p.PkgEndDate = reader["PkgEndDate"].ToString();
                    p.PkgDesc = reader["PkgDesc"].ToString();
                    p.PkgBasePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                    p.PkgAgencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);
                    
                    packages.Add(p);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return packages;

        }
       
        //third variation where the customer Id is used to obtain the packages
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<PackagesWBooking> GetPackagesFromCustomers(int customerId)
        {
            List<PackagesWBooking> packagesWBooking = new List<PackagesWBooking>();
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement = "SELECT BookingNo, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, BookingDate " +
                                     "FROM Packages p INNER JOIN Bookings b on b.PackageId = p.PackageId "+
                                                     "INNER JOIN Customers c on c.CustomerId = b.CustomerId "+
                                                     "WHERE c.CustomerId = @customerId";
                                      
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@customerId", customerId);


            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();
                

                while (reader.Read())
                {
                    PackagesWBooking p = new PackagesWBooking();
                    p.BookingNo = reader["BookingNo"].ToString();
                    p.PkgName = reader["PkgName"].ToString();
                    p.PkgStartDate = reader["PkgStartDate"].ToString();
                    p.PkgEndDate = reader["PkgEndDate"].ToString();
                    p.PkgDesc = reader["PkgDesc"].ToString();
                    p.PkgBasePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                    p.PkgAgencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);
                    p.BookingDate = reader["BookingDate"].ToString();
                    packagesWBooking.Add(p);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return packagesWBooking;

        }



    }
        

