using ContactDBHandler;
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
    public partial class index : System.Web.UI.Page
    {
        const string constr = "Data Source = ACADEMY006-VM; Initial Catalog = Contacts; Integrated Security = SSPI; ";
        SqlConnection connect = new SqlConnection(constr);
        List<Person> c;
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select * from contact", connect);
            //try
            //{
            //    connect.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        string id = reader["id"].ToString();
            //        string Ssn = reader["ssn"].ToString();
            //        string firstname = reader["firstname"].ToString();
            //        string lastname = reader["lastname"].ToString();
            //        c.Contacts.Add(new Person(id, firstname, lastname, Ssn));
            //    }
            //    if (Request["id"] != null)
            //    {
            //        reader.Close();
            //        DeleteRow(connect, cmd);
            //    }
            //}
            //catch (Exception)
            //{

            //}
            //finally
            //{
            //    connect.Close();
        //}
        c = DBHandler.FecthContacts(constr);
            if (!IsPostBack)
            {
                LoadTable();
            }
            else
            {

            }
        }

        void DeleteRow(SqlConnection con, SqlCommand cmd)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteContact";
                cmd.Parameters.AddWithValue("@id", id);
                //con.Open();
                cmd.ExecuteNonQuery();
                c.Remove(c.Find(p => p.Id == id));
                LoadTable();
            }
            catch (Exception eE)
            {
                string s = eE.Message;
            }
            finally
            {
                //con.Close();
            }

        }

        void LoadTable()
        {
            int count = 1;
            //< div class=\"container\">
            string table = "<div class=\"table-responsive\" style=\"margin-top: 50px;\"><table class=\"table\"><thead><tr><th>#</th><th>Firstname</th>";
            table += "<th>Lastname</th><th>Ssn</th><th>Controls</th></tr></thead><tbody>";
            foreach (Person p in c)
            {
                //ListItem tempP = new ListItem($"{p.FirstName} {p.LastName}", p.Id);
                //lbContacts.Items.Add(tempP);
                table += $"<tr><td>{count}</td>\n<td>{Server.HtmlEncode(p.Firstname)}</td>\n<td>{Server.HtmlEncode(p.Lastname)}</td>\n<td>{p.Ssn}</td>" +
                    $"\n<td><a onclick=\"runModal({p.Id}, '{p.Firstname}', '{p.Lastname}');\">Edit</a>|<a href=\"index.aspx?id={p.Id}\">Delete</a></td>\n</tr>";
                count++;
            }
            table += "</tbody></table></div>"

            LTable.Text = table;
        }

        //protected void btnOk_Click(object sender, EventArgs e)
        //{

        //    SqlConnection connect = new SqlConnection("Data Source = ACADEMY006-VM; Initial Catalog = Contacts; Integrated Security = SSPI;");
        //    SqlCommand cmd = new SqlCommand();
        //    string query = $"update contact set firstname ='{tbFirstname.Text}', lastname = '{tbLastname.Text}' where id = {Convert.ToInt32(lbContacts.SelectedValue)}";
        //    try
        //    {
        //        cmd.CommandText = query;
        //        cmd.Connection = connect;

        //        connect.Open();
        //        cmd.ExecuteNonQuery();
        //        //Person t = c.Contacts.Find(p => p.SocialSecurityNumber == lbContacts.SelectedValue);
        //        //t.FirstName = tbFirstname.Text;
        //        //t.LastName = tbLastname.Text;
        //        //lbContacts.Items.Clear();
        //        foreach (Person p in c.Contacts)
        //        {
        //            ListItem tempP = new ListItem($"{p.FirstName} {p.LastName}", p.SocialSecurityNumber);
        //            lbContacts.Items.Add(tempP);
        //        }

        //    }
        //    catch (Exception ee)
        //    {
        //        string s = ee.Message;

        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }
        //}

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void lbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int index = lbContacts.SelectedIndex;
            //if (lbContacts.SelectedIndex > -1)
            //{

            //}
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateNewPerson.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update contact set firstname='{tbVfirstname.Text}', lastname='{tbVlastname.Text}' where id={Convert.ToInt32(tbVId.Text)}";
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                //string s = tbVfirstname.Text;
                //string ss = tbVlastname.Text;
                //string sss = tbVId.Text;
            }
            catch (Exception ee)
            {
                string s = ee.Message;
            }
            finally
            {
                connect.Close();
            }
            Response.Redirect("index.aspx");
        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{
        //    SqlConnection connect = new SqlConnection("Data Source = ACADEMY006-VM; Initial Catalog = Contacts; Integrated Security = SSPI;");
        //    SqlCommand cmd = new SqlCommand("spDeleteContact", connect);
        //    try
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@id", SqlDbType.Int);
        //        cmd.Parameters["@id"].Value = Convert.ToInt32(lbContacts.SelectedValue);

        //        connect.Open();
        //        cmd.ExecuteNonQuery();
        //        Person t = c.Contacts.Find(p => p.SocialSecurityNumber == lbContacts.SelectedValue);
        //        c.Contacts.Remove(t);
        //        lbContacts.Items.Clear();
        //        IOrderedEnumerable<Person> temp = c.Contacts.OrderBy(p => p.LastName);
        //        foreach (Person p in temp)
        //        {
        //            ListItem tempP = new ListItem($"{p.FirstName} {p.LastName}", p.SocialSecurityNumber);
        //            lbContacts.Items.Add(tempP);
        //        }

        //    }
        //    catch (Exception ee)
        //    {

        //        string s = ee.Message;
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }
        //}

        //protected void lbContacts_SelectedIndexChanged1(object sender, EventArgs e)
        //{
        //    Person temp = c.Contacts.Find(p => p.Id == lbContacts.SelectedValue);
        //    lblID.Text = temp.Id;
        //    tbFirstname.Text = temp.FirstName;
        //    tbLastname.Text = temp.LastName;
        //    tbSsn.Text = temp.SocialSecurityNumber;
        //}
    }
}