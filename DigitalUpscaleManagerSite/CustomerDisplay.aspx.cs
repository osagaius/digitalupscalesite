using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    private Customer _selectedCustomer;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            ddlCustomers.DataBind();

        _selectedCustomer = this.GetSelectedCustomer();
        RebuildLabels();
        lblCustomerID.Text += _selectedCustomer.CustomerId;
        lblAddress.Text += _selectedCustomer.Address;
        lblCity.Text += _selectedCustomer.City;
        lblState.Text += _selectedCustomer.State;
        lblZipCode.Text += _selectedCustomer.ZipCode;
        lblPhone.Text += _selectedCustomer.Phone;
        lblEmail.Text += _selectedCustomer.Email;
    }

    private void RebuildLabels()
    {
        lblCustomerID.Text = "Customer ID: ";
        lblAddress.Text = "Address: ";
        lblCity.Text = "City: ";
        lblState.Text = "State: ";
        lblZipCode.Text = "Zip Code: ";
        lblPhone.Text = "Phone: ";
        lblEmail.Text = "Email: ";
    }

    private Customer GetSelectedCustomer()
    {

        var customersTable = (DataView)
            SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (customersTable == null) return null;
        customersTable.RowFilter =
            "CustomerID = '" + ddlCustomers.SelectedValue + "'";
        var row = customersTable[0];

        var p = new Customer
        {
            CustomerId = row["CustomerID"].ToString(),
            Address = row["Address"].ToString(),
            City = row["City"].ToString(),
            State = row["State"].ToString(),
            ZipCode = row["ZipCode"].ToString(),
            Phone = row["Phone"].ToString(),
            Email = row["Email"].ToString()
        };

        return p;
    }

}
