﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team1_Workshop4_Part2
{   //Brodie Zoschke Workshop 4 code start
    class SupplierDB
    {
        public static Supplier GetSupplier(int supplierId) 
        {
            //Create Connection to Database
            SqlConnection connection = TravelExpertsDB.GetConnection(); 
            //Create the Sql statement to select values using the entered id
            string selectStatement = "SELECT SupplierId, SupName FROM suppliers WHERE SupplierId = @supplierId";
            //create sql command that uses the Sql statement and the connection to the database
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //Add parameter for @supplier id and give value
            selectCommand.Parameters.AddWithValue("@supplierId", supplierId);
            try
            {
                
                connection.Open();
                //start Datareader and only read a single row
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                //if a read was possible then proceed or else return null if no supplier exists
                if (reader.Read())
                {
                    //create new supplier object
                    Supplier s = new Supplier();
                    //insert the supplier Id value from the reader into the object as an integer
                    s.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    //insert the supplier name into the object and convert to string
                    s.SupName = reader["SupName"].ToString();
                    //return the object
                    return s;
                }
                else
                {
                    return null;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        

        //add a new supplier 
        public static int AddSupplier(Supplier supplier)
        {
            //open connevtion with database
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //Create an insert statement for a new supplier for both ID and Name
            string insertStatement = "INSERT suppliers (SupplierId, SupName) VALUES (@supId, @supName)";
            //create sql command with insert statement and connection
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            //create two parameters to add the values of supplier id and supplier name
            insertCommand.Parameters.AddWithValue("@supId", supplier.SupplierId);
            insertCommand.Parameters.AddWithValue("@supName", supplier.SupName);

            try
            {
                    
                connection.Open();
                //execture command which checks how many rows were affected
                insertCommand.ExecuteNonQuery();
                //return the Supplier Id of the inserted supplier
                return supplier.SupplierId;
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
        //update command for the supplier, using a new object to overwrite the old
        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            //establish connection
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //create sql statement that sets the new values where the old ones exist, currently not allowing the id to be changed
            string updateStatement = "UPDATE Suppliers SET SupName = @newSupName "+
                                     "WHERE SupplierId = @OldSupId "+
                                     "AND SupName = @OldSupName";
            //create a sql command to use the sql statment and connection
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            //3 parameters to insert values into the id placeholders
            updateCommand.Parameters.AddWithValue("@newSupName",newSupplier.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupName",oldSupplier.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupId",oldSupplier.SupplierId);

            try
            {

                connection.Open();
                //create a variable to hold the results of the execute non query
                int count = updateCommand.ExecuteNonQuery(); //count rows that are affected
                if (count > 0)
                {
                    return true; //if rows were affected then return a true value 
                }
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
        public static bool DeleteSupplier(Supplier supplier) //Delete the current supplier 
        {
            SqlConnection connection = TravelExpertsDB.GetConnection();
            //create a delete statement where the supplier is the ID in the text box
            string deleteStatement = "DELETE FROM Suppliers Where SupplierId = @supID";
            //create new delete command with statment and connection
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            //add a parameter at the @supId with the supplier id value
            deleteCommand.Parameters.AddWithValue("@supID", supplier.SupplierId);

            try
            {
                connection.Open();
                //create count variable to check if a row was affected
                int count = deleteCommand.ExecuteNonQuery(); //if any rows were affected then return true
                if (count > 0) 
                    return true; //return true if rows changed
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
        //Make a Generic Delete Command for deleting suppliers that are added and un related in database
        

        ////display supplier for presentation layer if needed
        //public void DisplaySupplier()
        //{
        //    txtSupplierID.Text = supplier.SupplierId;
        //    txtSupplierName.Text = supplier.SupName;
        //}

        ////getSupplier method for the presentation layer if needed
        //public void GetSupplier(int supplierId)
              
        //{
        //    try
        //    {
       //calls get product from SupplierDB which connects to database with sql
        //        supplier = SupplierDB.GetSupplier(supplierId); 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.GetType().ToString());
        //    }
        //}

    //Brodie Code End
            
    }

