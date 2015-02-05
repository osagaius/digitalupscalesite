using System;
using System.Data;
using System.Web.UI;

/// <summary>
/// Code behind for the CustomerDisplay page.
/// </summary>
/// <author>
///     Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public partial class Default : Page
{
    /// <summary>
    /// The _selected customer
    /// </summary>
    private Customer _selectedCustomer;
    /// <summary>
    /// The customer list
    /// </summary>
    private CustomerList contactList;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

    /// <summary>
    /// Initializes the label with default customer's information.
    /// </summary>
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

    /// <summary>
    /// Rebuilds the labels.
    /// </summary>
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

    /// <summary>
    /// Gets the selected customer.
    /// </summary>
    /// <returns></returns>
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
            Name = row["Name"].ToString(),
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

    /// <summary>
    /// Extracts the first and last names from a composite name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    private string[] ExtractNames(string name)
    {
        var names = name.Trim().Split(new char[] { ' ' }, 2);
        return names;
    }

    /// <summary>
    /// Raises the <see cref="E:System.Web.UI.Control.Load" /> event.
    /// </summary>
    /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Page.Header.DataBind();
    }
    /// <summary>
    /// Handles the Click event of the btnAdd control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }

        this._selectedCustomer = this.GetSelectedCustomer();

        if (this.FindDuplicate(this._selectedCustomer))
        {
            this.lblMessage.Text = "This customer is already in your contact list.";
        }
        else
        {
            this.lblMessage.Text = string.Empty;
            this.contactList.AddItem(this._selectedCustomer);
        }
    }

    /// <summary>
    /// Finds the duplicate.
    /// </summary>
    /// <param name="aCustomer">a customer.</param>
    /// <returns></returns>
    private bool FindDuplicate(Customer aCustomer)
    {
        var matchingCustomer = this.contactList[aCustomer.Name];
        return matchingCustomer != null;
    }
    /// <summary>
    /// Handles the Click event of the btnView control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnView_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactList.aspx");
    }
}