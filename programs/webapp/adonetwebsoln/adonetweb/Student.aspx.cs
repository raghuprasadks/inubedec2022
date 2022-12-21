using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adonetweb
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                // con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                //Get connection string from web.config file  
                string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                con = new SqlConnection(strcon);
                // Writing insert query  
                string query = "insert into students(name,email,address) values('" + TextBoxName.Text + "','" + TextBoxEmail.Text + "','" + TextBoxAddress.Text + "')";  
                SqlCommand sc = new SqlCommand(query, con);
                // Opening connection  
                con.Open();
                // Executing query  
                int status = sc.ExecuteNonQuery();
                LabelResult.Text = "Your record has been saved with the following details!";
                // ----------------------- Retrieving Data ------------------ //  
                SqlCommand cm = new SqlCommand("select top 1 * from students order by id desc", con);
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();
                LabelData.Text = " ";
                LabelData.Text += $"User Name  {sdr["name"].ToString()}";
               // Label3.Text = "Email ID"; Label6.Text = sdr["email"].ToString();
                //Label4.Text = "Contact"; Label7.Text = sdr["contact"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
    
