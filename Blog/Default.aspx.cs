using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["userId"];
       
        if (cookie != null)
        {
            LB_message.Text = "bienvenue :" + cookie.Value;
        }
       
    }
}