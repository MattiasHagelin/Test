using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class AddContact : System.Web.UI.Page
    {
        string id = null;
        SqlConnection connect = new SqlConnection("Data Source = ACADEMY006-VM; Initial Catalog = Contacts; Integrated Security = SSPI;");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    id = Request.QueryString["id"].ToString();
                    lblIDtxt.Text = id;
                    FetchContact();
                }
                catch (Exception ee)
                {
                    string s = ee.Message;
                }
            } else
            {
                try
                {
                    id = Request.QueryString["id"].ToString();
                }
                catch (Exception)
                {
                    id = null;
                }
            }
        }

        void FetchContact()
        {

            try
            {
                cmd.CommandText = $"select * from contact where id={Convert.ToInt32(id)}";
                cmd.Connection = connect;
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbFirstname.Text = reader["firstname"].ToString();
                    tbLastname.Text = reader["lastname"].ToString();
                    tbSsn.Text = reader["ssn"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connect.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void lbSave_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", tbFirstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", tbLastname.Text);
                    cmd.Parameters.AddWithValue("@ssn", tbSsn.Text);
                    cmd.Parameters.AddWithValue("@new_id", 0);
                    cmd.CommandText = "spAddContact";
                    cmd.Connection = connect;
                    connect.Open();
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ee)
                {
                    string s = ee.Message;
                }
                finally
                {
                    connect.Close();
                }

            }
            else
            {
                try
                {
                    cmd.CommandText = $"update contact set firstname ='{tbFirstname.Text}', lastname = '{tbLastname.Text}', ssn = '{tbSsn.Text}' where id = {Convert.ToInt32(id)}";
                    cmd.Connection = connect;
                    connect.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    string s = ee.Message;
                }
                finally
                {
                    connect.Close();
                }
            }

            Response.Redirect("index.aspx");
        }
    }
}
