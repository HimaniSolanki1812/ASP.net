using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace first_web
{
    public partial class clientside_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["usercookie"] != null)
                {
                    String user = Request.Cookies["usercookie"].Value;
                    Label7.Text = "Welcome " + user;
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            if (ViewState["clicks"] != null)
                count = (int)ViewState["clicks"];
            count++;
            ViewState["clicks"] = count;
            lblViewState.Text = "Button clicked " + count + " times.";

            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = "56";
            lblHidden.Text = "Hidden Field Value:" + HiddenField1.Value;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //HttpCookie cookie = new HttpCookie("mycookie");
            Response.Cookies["mycookie"].Value = txtcookie.Text;
            Response.Cookies["mycookie"].Expires = DateTime.Now.AddMinutes(3);
            //Response.Cookies.Add(cookie)
            lblCookie.Text = "cookie created";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["myCookie"] != null)
            {
                string cookieValue = Request.Cookies["myCookie"].Value;
                lblCookie.Text = "Cookie Value: " + cookieValue;
            }
            else
            {
                lblCookie.Text = "No cookie found.";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("/state.aspx?user=" + txtQueryString.Text);
        }
    }
}