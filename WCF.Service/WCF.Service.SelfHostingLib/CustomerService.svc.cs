using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF.Service.SelfHostingLib
{
    public class CustomerService : ICustomerService
    {
        string connectionString = "Server=.\\SQLEXPRESS;Database=Vir;Trusted_Connection=true;";

        public IEnumerable<Customer> GetByKey(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                List<Customer> listCustomer = new List<Customer>();

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from CUSTOMERS where ID = " + id + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("CUSTOMERS");
                da.Fill(dt);
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    Customer customerInfo = new Customer();
                    customerInfo.NAME = dt.Rows[i]["NAME"].ToString();
                    customerInfo.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                    customerInfo.AGE = int.Parse(dt.Rows[i]["AGE"].ToString());
                    customerInfo.ADDRESS = dt.Rows[i]["ADDRESS"].ToString();
                    customerInfo.DESCRIPTION = dt.Rows[i]["DESCRIPTION"].ToString();
                    listCustomer.Add(customerInfo);
                }

                con.Close();

                return listCustomer;
            }
        }

        public string Save(string name, string id, string age, string address, string description)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                Customer customerInfo = new Customer();
                customerInfo.ADDRESS = address;
                customerInfo.ID = int.Parse(id);
                customerInfo.AGE = int.Parse(age);
                customerInfo.ADDRESS = address;
                customerInfo.DESCRIPTION = description;

                string strMessage = string.Empty;
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into CUSTOMERS(NAME,ID,AGE,ADDRESS,DESCRIPTION) values(@NAME,@ID,@AGE,@ADDRESS,@DESCRIPTION)", con);
                cmd.Parameters.AddWithValue("@NAME", customerInfo.NAME);
                cmd.Parameters.AddWithValue("@ID", customerInfo.ID);
                cmd.Parameters.AddWithValue("@AGE", customerInfo.AGE);
                cmd.Parameters.AddWithValue("@ADDRESS", customerInfo.ADDRESS);
                cmd.Parameters.AddWithValue("@DESCRIPTION", customerInfo.DESCRIPTION);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    strMessage = customerInfo.NAME + " inserted successfully";
                }
                else
                {
                    strMessage = customerInfo.NAME + " not inserted successfully";
                }
                con.Close();
                return strMessage;
            }
        }
    }
}
