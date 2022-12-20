using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DOTNETWebApplication
{
    public partial class ViewStateForm : System.Web.UI.Page
    {
        //int counter = 0;
        int ClicksCount = 1;

        string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label2.Text = "Page_Load is Called";
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
                msg = "Page_Load is Called:Not post back";
            }
            else
            {
                msg = "Page_Load is Called:post back";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label2.Text = "Button1_Click is Called";
            /**
            counter = counter + 1;
            TextBox1.Text = counter.ToString();
            Label2.Text = msg;
            **/

            if (ViewState["Clicks"] != null)
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString(); ;
            ViewState["Clicks"] = ClicksCount;

        }
    }
}