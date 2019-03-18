using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageT1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se existe o cookie
            HttpCookie cookie = Request.Cookies["AvisoT1"];
            if (cookie != null)
            {
                DivLogin.Visible = false;
                Response.Write(cookie.Value);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DivLogin.Visible = false;
            //criar um cookie
            HttpCookie cookie = new HttpCookie("AvisoT1");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Value = "Aceitou";
            //enviar cookie para browser
            Response.Cookies.Add(cookie);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DivLogin.Visible = false;
            //criar um cookie
            HttpCookie cookie = new HttpCookie("AvisoT1");
            cookie.Expires = DateTime.Now.AddYears(1);
            cookie.Value = "Rejeitou";
            //enviar cookie para browser
            Response.Cookies.Add(cookie);
        }
    }
}