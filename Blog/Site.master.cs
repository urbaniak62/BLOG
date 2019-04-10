using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : MasterPage
{
    private const string AntiXsrfTokenKey = "__AntiXsrfToken";
    private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
    private string _antiXsrfTokenValue;

    protected void Page_Init(object sender, EventArgs e)
    {
        //  Le code ci-dessous vous aide à vous protéger contre les attaques XSRF
        var requestCookie = Request.Cookies[AntiXsrfTokenKey];
        Guid requestCookieGuidValue;
        if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
        {
            // Utilisez les jetons anti-XSRF à partir du cookie
            _antiXsrfTokenValue = requestCookie.Value;
            Page.ViewStateUserKey = _antiXsrfTokenValue;
        }
        else
        {
            // Générer un nouveau jeton anti-XSRF et enregistrer le cookie
            _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
            Page.ViewStateUserKey = _antiXsrfTokenValue;

            var responseCookie = new HttpCookie(AntiXsrfTokenKey)
            {
                HttpOnly = true,
                Value = _antiXsrfTokenValue
            };
            if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
            {
                responseCookie.Secure = true;
            }
            Response.Cookies.Set(responseCookie);
        }

        

        HttpCookie reqCookies = Request.Cookies["userId"];
        var urlActuelle = HttpContext.Current.Request.Path;
        //niveau
        //email
        //cookie ou session
        //si connecté et admin ou cookie avec droit admin pas de soucis
        //sinon empecher administration
        HttpCookie cookies = Request.Cookies["niveauUserBlog"];
        if ((cookies!=null&& cookies.Value=="2")||(Session["email"]!=null && Session["niveau"].ToString()=="4") && urlActuelle.Contains("Administration"))
        {

        }
        else if (urlActuelle.Contains("Administration"))
        {
            Response.Redirect("/connection.aspx");
        }

        
        if (Session["niveau"] != null)
        {

        }
        //if (reqCookies==null && urlActuelle.Contains("Administration"))
        //{
        //    Response.Redirect("/Default.aspx");
        //}

        Page.PreLoad += master_Page_PreLoad;
    }

    protected void master_Page_PreLoad(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Définir le jeton anti-XSRF
            ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
            ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
        }
        else
        {
            // Valider le jeton anti-XSRF
            if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
            {
                throw new InvalidOperationException("Échec de la validation du jeton anti-XSRF.");
            }
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Context.GetOwinContext().Authentication.SignOut();
    }
}