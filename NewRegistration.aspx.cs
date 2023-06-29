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
    public partial class NewRegistration : System.Web.UI.Page
    {
        SqlConnection SQLconn = new SqlConnection("Data Source=20220432-Arun; Initial Catalog=ASPLogin; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("insert into NewRegistration values ('" + FirstName.Text + "', '" + LastName.Text + "', '" + Password.Text + "', '" + Mobile.Text + "')", SQLconn);
            DataTable NewRegistration = new DataTable();
            SQLAdapter.Fill(NewRegistration);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Redirectform.aspx");
        }
    }
}