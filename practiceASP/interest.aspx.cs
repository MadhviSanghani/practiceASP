using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practiceASP
{
    public partial class interest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(TextBox1.Text);
            int r = Convert.ToInt32(TextBox2.Text);
            int t = Convert.ToInt32(TextBox3.Text);
            int si = (p * r * t) / 100;
            Response.Write(si);
        }
    }
}