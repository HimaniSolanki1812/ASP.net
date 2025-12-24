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
   
    }
}