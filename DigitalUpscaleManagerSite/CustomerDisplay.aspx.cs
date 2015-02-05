using System;
using System.Data;
using System.Web.UI;

public partial class Default : Page
{
    private Customer _selectedCustomer;
    private CustomerList contactList;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.ddlCustomers.DataBind();
            this.contactList = new CustomerList();
            Session["CustomerList"] = this.contactList;
        }
        else
        {
            this.contactList = CustomerList.GetCustomers();
        }

        this.InitializeLabelWithDefaultCustomer();
    }

    private void InitializeLabelWithDefaultCustomer()
    {
        this._selectedCustomer = this.GetSelectedCustomer();
        this.RebuildLabels();
        this.lblCustomerID.Text += this._selectedCustomer.CustomerId;
        this.lblAddress.Text += this._selectedCustomer.Address;
        this.lblCity.Text += this._selectedCustomer.City;
        this.lblState.Text += this._selectedCustomer.State;
        this.lblZipCode.Text += this._selectedCustomer.ZipCode;
        this.lblPhone.Text += this._selectedCustomer.Phone;
        this.lblEmail.Text += this._selectedCustomer.Email;
    }

    private void RebuildLabels()
    {
        this.lblCustomerID.Text = "Customer ID: ";
        this.lblAddress.Text = "Address: ";
        this.lblCity.Text = "City: ";
        this.lblState.Text = "State: ";
        this.lblZipCode.Text = "Zip Code: ";
        this.lblPhone.Text = "Phone: ";
        this.lblEmail.Text = "Email: ";
    }

    private Customer GetSelectedCustomer()
    {
        var customersTable = (DataView)this.SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (customersTable == null)
        {
            return null;
        }
        customersTable.RowFilter =
            "CustomerID = '" + this.ddlCustomers.SelectedValue + "'";
        var row = customersTable[0];
        var names = this.ExtractNames(row["Name"].ToString());

        var customer = new Customer
        {
            CustomerId = row["CustomerID"].ToString(),
            FirstName = names[0],
            LastName = names[1],
            Address = row["Address"].ToString(),
            City = row["City"].ToString(),
            State = row["State"].ToString(),
            ZipCode = row["ZipCode"].ToString(),
            Phone = row["Phone"].ToString(),
            Email = row["Email"].ToString()
        };

        return customer;
    }

    private string[] ExtractNames(string name)
    {
        var names = name.Trim().Split(new char[] { ' ' }, 2);
        return names;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Page.Header.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }

        this._selectedCustomer = this.GetSelectedCustomer();
        this.contactList.AddItem(this._selectedCustomer);

    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactList.aspx");
    }
}