using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace first_web
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\First.net\\first_web\\App_Data\\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("Select username,password from login where username='"+txtname.Text+ "' and password='"+txtpsw.Text+"'", con);
            SqlCommand cmd = new SqlCommand("Select username,password from login where username=@u and password=@p", con);
            cmd.Parameters.AddWithValue("@u",txtname.Text);
            cmd.Parameters.AddWithValue("@p", txtpsw.Text);




            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["username"] = txtname.Text;
                HttpCookie cookie = new HttpCookie("usercookie");
                cookie.Value = txtname.Text;
                cookie.Expires = DateTime.Now.AddMinutes(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("clientside_aspx.aspx");
            }
            else
            {
                Response.Write("Username and password doesn't match");
            }
        }
    }
    }
