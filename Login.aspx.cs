using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SQLconn = new SqlConnection("Data Source=20220432-Arun; Initial Catalog=ASPLogin; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            messagelbl.Text = "";
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * FROM NewRegistration WHERE UserName='" + txtFirstName.Text + "' AND Password='" + txtPassword.Text + "'", SQLconn);
            DataTable DT = new DataTable();

                       if (DT.Rows.Count > 0)
            {
                messagelbl.Visible = true;
                messagelbl.Text = "You have successfully Logged into the System";
                messagelbl.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("Redirectform.aspx");
            }
            else
                
                messagelbl.Text = "Invalid Username or Password";
                messagelbl.ForeColor = System.Drawing.Color.Red;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Redirectform.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRegistration.aspx");
        }
    }
}
