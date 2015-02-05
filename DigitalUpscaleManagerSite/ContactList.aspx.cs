using System;
using System.Web.UI;

public partial class Cart : Page
{
    private CustomerList customerList;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.customerList = CustomerList.GetCustomers();
        if (!IsPostBack)
            this.DisplayCustomers();
    }

    private void DisplayCustomers()
    {
        this.lstCustomers.Items.Clear();
        for (var i = 0; i < this.customerList.Count; i++)
        {
            var customer = this.customerList[i];
            this.lstCustomers.Items.Add(customer.FirstName);
        }
    }

    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (this.customerList.Count <= 0)
        {
            return;
        }

        this.RemoveSelectedCustomer();
    }

    private void RemoveSelectedCustomer()
    {
        if (this.lstCustomers.SelectedIndex > -1)
        {
            this.customerList.RemoveAt(this.lstCustomers.SelectedIndex);
            this.DisplayCustomers();
        }
        else
        {
            this.lblMessage.Text = "Please select the item you want to remove.";
        }
    }

    protected void btnEmpty_Click(object sender, EventArgs e)
    {
        if (this.customerList.Count <= 0)
        {
            return;
        }
        this.customerList.Clear();
        this.lblMessage.Text = string.Empty;
        this.lstCustomers.Items.Clear();
    }
    protected void btnSelectAdditional_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDisplay.aspx");
    }
}