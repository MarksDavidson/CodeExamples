using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

//Created By Mark Davidson
//Group #1
//CPRG 214
//Last Edited  Jan 21 2015

    [DataObject(true)]
    public static class CustomerDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer Login(string customerEmail, string customerPassword)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT CustomerID, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, " +
                "CustHomePhone, CustBusPhone, CustEmail, Password FROM Customers WHERE CustEmail = @custEmail AND Password = @Password";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@custEmail", customerEmail);
            selectCommand.Parameters.AddWithValue("@Password", customerPassword);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                    customer.CustPassword = (string)custReader["Password"];
                    //customer.AgentId = (int)custReader["AgentID"];

                    return customer;
                }
                else
                {
                    return null;
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
        }

        //Brodie modified a get customer by email 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer GetCustomerByEmail(string customerEmail)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT CustomerID, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, " +
                "CustHomePhone, CustBusPhone, CustEmail FROM Customers WHERE CustEmail = @custEmail";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@custEmail", customerEmail);
        

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                
                    //customer.AgentId = (int)custReader["AgentID"];

                    return customer;
                }
                else
                {
                    return null;
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
        }

        //Create full list of all Customers
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Customer> GetAllCustomers()
        {
            List<Customer>  customers = new List<Customer>(); // empty list
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT CustomerID, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, " +
                "CustHomePhone, CustBusPhone, CustEmail FROM Customers ";
                
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            
            try
            {
                connection.Open();
                SqlDataReader custReader = selectCommand.ExecuteReader();
                while(custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                    //customer.AgentId = (int)custReader["AgentID"];
                    customers.Add(customer);
                }
                custReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }


        //Find single customer by ID
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Customer GetCustomerByID(int customerID)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string selectStatement =
                "SELECT CustomerID, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, " +
                "CustHomePhone, CustBusPhone, CustEmail FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@CustomerID", customerID);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)custReader["CustomerID"];
                    customer.CustFirstName = (string)custReader["CustFirstName"];
                    customer.CustLastName = (string)custReader["CustLastName"];
                    customer.CustAddress = (string)custReader["CustAddress"];
                    customer.CustCity = (string)custReader["CustCity"];
                    customer.CustProv = (string)custReader["CustProv"];
                    customer.CustPostal = (string)custReader["CustPostal"];
                    customer.CustCountry = (string)custReader["CustCountry"];
                    customer.CustHomePhone = (string)custReader["CustHomePhone"];
                    customer.CustBusPhone = (string)custReader["CustBusPhone"];
                    customer.CustEmail = (string)custReader["CustEmail"];
                    //customer.AgentId = (int)custReader["AgentID"];
                    
                    return customer;
                }
                else
                {
                    return null;
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
        }


        //Add Customer
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static int AddCustomer(Customer customer)
        {
            // check to see if bus phone is set. if it isn't supply this empty value.
            if (customer.CustBusPhone == null)
            {
                customer.CustBusPhone = " ";
            }
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string insertStatement =
                "INSERT Customers " +
                "(CustFirstName,CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail) " +
                "VALUES (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, @CustCountry, @CustHomePhone, @CustBusPhone, @custEmail)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@CustFirstName", customer.CustFirstName);
            insertCommand.Parameters.AddWithValue(
                "@CustLastName", customer.CustLastName);
            insertCommand.Parameters.AddWithValue(
                "@CustAddress", customer.CustAddress);
            insertCommand.Parameters.AddWithValue(
                "@CustCity", customer.CustCity);
            insertCommand.Parameters.AddWithValue(
                "@CustProv", customer.CustProv);
            insertCommand.Parameters.AddWithValue(
                "@CustPostal", customer.CustPostal);
            insertCommand.Parameters.AddWithValue(
                "@CustCountry", customer.CustCountry);
            insertCommand.Parameters.AddWithValue(
                "@CustHomePhone", customer.CustHomePhone);
            insertCommand.Parameters.AddWithValue(
                "@CustBusPhone", customer.CustBusPhone);
            insertCommand.Parameters.AddWithValue(
                "@custEmail", customer.CustEmail);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Customers') FROM Customers";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);
                int customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return customerID;
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


        //Update customer (Mark and Darcie)
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static bool UpdateCustomer(Customer original_customer,
            Customer customer)
   
        {
            // check to see if bus phone is set. if it isn't supply this empty value.
             if (customer.CustBusPhone == null)
            {
                customer.CustBusPhone = " ";
            }

            SqlConnection connection = TravelExpertsDB.GetConnection();
            string updateStatement =
                "UPDATE Customers SET " +
                "CustFirstName = @CustFirstName, " +
                "CustLastName = @CustLastName, " +
                "CustAddress = @CustAddress, " +
                "CustCity = @CustCity, " +
                "CustProv = @CustProv, " +
                "CustPostal = @CustPostal, " +
                "CustCountry = @CustCountry, " +
                "CustHomePhone = @CustHomePhone, " +
                "CustBusPhone = @CustBusPhone, " +
                "CustEmail = @CustEmail " +
                //"AgentId = @AgentId " +

                "WHERE CustFirstName = @original_CustFirstName " +
                "AND CustLastName = @original_CustLastName " +
                "AND CustAddress = @original_CustAddress " +
                "AND CustCity = @original_CustCity " +
                "AND CustProv = @original_CustProv " +
                "AND CustPostal = @original_CustPostal " +
                "AND CustCountry = @original_CustCountry " +
                "AND CustHomePhone = @original_CustHomePhone " +
                "AND CustBusPhone = @original_CustBusPhone " +
                "AND CustEmail = @original_CustEmail ";
                //"AND AgentId = @original_AgentId ";


            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue(
                 "@CustFirstName", customer.CustFirstName);
            updateCommand.Parameters.AddWithValue(
                "@CustLastName", customer.CustLastName);
            updateCommand.Parameters.AddWithValue(
                "@CustAddress", customer.CustAddress);
            updateCommand.Parameters.AddWithValue(
                "@CustCity", customer.CustCity);
            updateCommand.Parameters.AddWithValue(
                "@CustProv", customer.CustProv);
            updateCommand.Parameters.AddWithValue(
                "@CustPostal", customer.CustPostal);
            updateCommand.Parameters.AddWithValue(
                "@CustCountry", customer.CustCountry);
            updateCommand.Parameters.AddWithValue(
                "@CustHomePhone", customer.CustHomePhone);
            updateCommand.Parameters.AddWithValue(
                "@CustBusPhone", customer.CustBusPhone);
            updateCommand.Parameters.AddWithValue(
                "@CustEmail", customer.CustEmail);
            //updateCommand.Parameters.AddWithValue(
            //    "@AgentId", newCustomer.AgentId);

            updateCommand.Parameters.AddWithValue(
                "@original_CustFirstName", original_customer.CustFirstName);
            updateCommand.Parameters.AddWithValue(
                "@original_CustLastName", original_customer.CustLastName);
            updateCommand.Parameters.AddWithValue(
                "@original_CustAddress", original_customer.CustAddress);
            updateCommand.Parameters.AddWithValue(
                "@original_CustCity", original_customer.CustCity);
            updateCommand.Parameters.AddWithValue(
                "@original_CustProv", original_customer.CustProv);
            updateCommand.Parameters.AddWithValue(
                "@original_CustPostal", original_customer.CustPostal);
            updateCommand.Parameters.AddWithValue(
                "@original_CustCountry", original_customer.CustCountry);
            updateCommand.Parameters.AddWithValue(
                "@original_CustHomePhone", original_customer.CustHomePhone);
            updateCommand.Parameters.AddWithValue(
                "@original_CustBusPhone", original_customer.CustBusPhone);
            updateCommand.Parameters.AddWithValue(
                "@original_CustEmail", original_customer.CustEmail);
            //updateCommand.Parameters.AddWithValue(
            //    "@original_AgentId", original_customer.AgentId);
            
            
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
        
        
    

        //Delete customer
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static bool DeleteCustomer(Customer customer)
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Customers " +
                "WHERE CustFirstName = @CustFirstName " +
                "CustLastName = @CustLastName " +
                "AND CustAddress = @CustAddress " +
                "AND CityCity = @CityCity " +
                "AND CustProv = @CustProv " + 
                "AND CustPostal = @CustPostal "+
                "AND CustCountry = @CustCountry " +
                "AND CustHomePhone = @CustHomePhone " +
                "AND CustBusPhone = @CustBusPhone " +
                "AND CustEmail = @CustEmail " +
                "AND AgentId = @AgentId";

            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@CustFirstName", customer.CustFirstName);
            deleteCommand.Parameters.AddWithValue(
                "@CustLastName", customer.CustLastName);
            deleteCommand.Parameters.AddWithValue(
                "@CustAddress", customer.CustAddress);
            deleteCommand.Parameters.AddWithValue(
                "@CustCity", customer.CustCity);
            deleteCommand.Parameters.AddWithValue(
                "@CustProv", customer.CustProv);
            deleteCommand.Parameters.AddWithValue(
                "@CustPostal", customer.CustPostal);
            deleteCommand.Parameters.AddWithValue(
                "@CustCountry", customer.CustCountry);
            deleteCommand.Parameters.AddWithValue(
                "@CustHomePhone", customer.CustHomePhone);
            deleteCommand.Parameters.AddWithValue(
                "@CustBusPhone", customer.CustBusPhone);
            deleteCommand.Parameters.AddWithValue(
                "@CustEmail", customer.CustEmail);
            deleteCommand.Parameters.AddWithValue(
                 "@AgentId", customer.AgentId);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
    }

