using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace first_web
{
    public partial class first_web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Welcome to asp.net");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;

            if (selectedDate == DateTime.MinValue)
            {
                Label2.Text = "No date selected.";
                return;
            }

            // Print selected date and the day of week (full name)
            string dayName = selectedDate.ToString("dddd"); // e.g. "Wednesday"
            Label2.Text = $"Selected date: {selectedDate:dd-MM-yyyy} ({dayName})";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string files = FileUpload2.FileName;
            string path = Server.MapPath("~/Files/")+files;
            FileUpload2.SaveAs(path);
            Label3.Text = "File Uploaded";

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;

        }
    }
}