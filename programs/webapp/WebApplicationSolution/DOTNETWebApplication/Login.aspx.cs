using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DOTNETWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = TextBoxEmail.Text;
            string password = TextBoxPassword.Text;

            if (email.Equals("admin@gmail.com") && password.Equals("admin"))
            {
                Response.Redirect("~/Home");
            }
            else
            {
                LabelResult.Text = "Invalid User Name or Password";
            }
        }
    }
}