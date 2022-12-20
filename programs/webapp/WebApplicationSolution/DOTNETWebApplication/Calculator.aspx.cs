using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DOTNETWebApplication
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int fn = Convert.ToInt32(TextBoxFN.Text);
            string oper = DropDownList1.SelectedValue;
            int sn = Convert.ToInt32(TextBoxSN.Text);
            int result = 0;
            if (oper.Equals("+"))
            {
                result = fn + sn;
                LabelResult.Text = $"{fn} + {sn} = {result}";
            }else if (oper.Equals("-"))
            {
                result = fn - sn;
                LabelResult.Text = $"{fn} - {sn} = {result}";
            }
            else if (oper.Equals("*"))
            {
                result = fn * sn;
                LabelResult.Text = $"{fn} * {sn} = {result}";
            }
            else if (oper.Equals("/"))
            {
                result = fn / sn;
                LabelResult.Text = $"{fn} / {sn} = {result}";
            }
        }
    }
}