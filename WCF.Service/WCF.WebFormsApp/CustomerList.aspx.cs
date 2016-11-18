using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.WebFormsApp.WCFService;

namespace WCF.WebFormsApp
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            using (CustomerServiceClient client = new CustomerServiceClient())
            {
                grdCustomers.DataSource= client.GetByKey(txtId.Text.Trim());
                grdCustomers.DataBind();
                client.Close();
            }
        }
    }
}