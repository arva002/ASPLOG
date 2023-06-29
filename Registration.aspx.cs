using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLogin
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection SQLconn = new SqlConnection("Data Source=20220432-Arun; Initial Catalog=ASPLogin; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("insert into StudentRegistration values ('" + studentname.Text + "', '" + course.SelectedValue + "', '" + contactno.Text + "')", SQLconn);
            DataTable StudentRegistration = new DataTable();
            SQLAdapter.Fill(StudentRegistration);
                
        }
        //It will redirect to the main page upon successfull registration//
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}
