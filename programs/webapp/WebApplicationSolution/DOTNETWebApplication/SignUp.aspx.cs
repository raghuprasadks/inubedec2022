using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DOTNETWebApplication
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelPageLoad.Text = "Page_Load";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LabelButtonClick.Text = "Button1_Click";

            LabelMsg.Text = TextBoxName.Text + " registration successful ";
        }
    }
}