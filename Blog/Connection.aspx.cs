using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Connection : System.Web.UI.Page
{
    string cnx = @"Data Source=STA6101318\SQLEXPRESS;Initial Catalog=BLOG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["userId"];
        LB_message.Text = cookie.Value;
    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        if (txtb_mdp.Text != "" && txtb_mdp.Text.Length > 1)
        {


            try
            {
                SqlConnection connection = new SqlConnection(cnx);
                connection.Open();
                String req = "select IdTypeUtilisateur from dbo.Utilisateur where email=@email and [Password]=@pwd";
                SqlCommand sqlCommand = new SqlCommand(req, connection);
                sqlCommand.Parameters.AddWithValue("@email", txtb_Login.Text);
                sqlCommand.Parameters.AddWithValue("@pwd", txtb_mdp.Text);

                try
                {
                    int IdTypeUtilisateur = Int32.Parse(sqlCommand.ExecuteScalar().ToString());
                    if (IdTypeUtilisateur == 4)
                    {
                        Session["email"] = txtb_Login.Text;
                        Session["niveau"] = IdTypeUtilisateur;
                        if (CB_Remember.Checked)
                        {
                            HttpCookie httpCookie = new HttpCookie("userId", txtb_Login.Text);
                            Response.Cookies.Add(httpCookie);
                            Response.Redirect("/Default.aspx");

                        }
                        Response.Redirect("/Default.aspx");

                    }
                    else
                    {
                        Session["email"] = txtb_Login.Text;
                        Session["niveau"] = IdTypeUtilisateur;
                        if (CB_Remember.Checked)
                        {
                            HttpCookie httpCookie = new HttpCookie("Admin", txtb_Login.Text);
                            Response.Cookies.Add(httpCookie);
                            Response.Redirect("/Administration.aspx");

                        }
                        Response.Redirect("/Administration.aspx");

                    }
                   

                }
                catch (Exception ex)
                {
                    connection.Close();
                    LB_message.Text = "impossible de t identifier"+ex.Message;
                }





            }
            catch (Exception ex)
            {
                LB_message.Text = "impossible de vous identifier" + ex.Message;

            }
        }
        else
        {
            LB_message.Text = "veuillez indiquer un mot de passe";
        }
    }
    
}