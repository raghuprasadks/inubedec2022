using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetconsole
{
    class Program
    {
        static void Main(string[] args)
        {
//            CreateTable();
          //  InsertData();
           // ReadData();
           // DeleteData();
            SPWithoutParam();
            Console.ReadKey();
        }

        static void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  windows authetication
                  con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query 
                // sql server authentication with user id and password
                //con = new SqlConnection("Server = RAGHUPRASAD; Database = student; User Id = sa; Password = inube@123");
                SqlCommand cm = new SqlCommand("create table student(id int not null,name varchar(100), email varchar(50), join_date date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        static void InsertData()
        {

            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student (id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        static void ReadData()
        {

            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("select * from student", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        static void DeleteData()
        {

            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from student where id = '101'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        static void SPWithoutParam()
        {
                //Store the connection string in the ConnectionString variable
                string ConnectionString = @"data source=.; database=StudentDB; integrated security=SSPI";


             //   SqlConnection con = null;
                try
                {
                    // Creating Connection  
              //      con = new SqlConnection("data source=.; database=student; integrated security=SSPI");

                    //Create the SqlConnection object
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    //Create the SqlCommand object by passing the stored procedure name and connection object as parameters
                    SqlCommand cmd = new SqlCommand("spGetStudents", connection)
                    {
                        //Specify the command type as Stored Procedure
                        CommandType = CommandType.StoredProcedure
                    };

                    //Open the Connection
                    connection.Open();

                    //Execute the command i.e. Executing the Stored Procedure using ExecuteReader method
                    //SqlDataReader requires an active and open connection
                    SqlDataReader sdr = cmd.ExecuteReader();

                    //Read the data from the SqlDataReader 
                    //Read() method will returns true as long as data is there in the SqlDataReader
                    while (sdr.Read())
                    {
                        //Accessing the data using the string key as index
                        Console.WriteLine(sdr["Id"] + ",  " + sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["Mobile"]);

                        //Accessing the data using the integer index position as key
                        //Console.WriteLine(sdr[0] + ",  " + sdr[1] + ",  " + sdr[2] + ",  " + sdr[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }
            Console.ReadKey();
        
    
}

    }
    }




