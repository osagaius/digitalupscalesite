using System;
using System.Web.UI;

/// <summary>
/// Code behind for the ContactList page.
/// </summary>
/// <author>
///     Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public partial class ContactList : Page
{
    private CustomerList customerList;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        this.customerList = CustomerList.GetCustomers();
        if (!IsPostBack)
            this.DisplayCustomers();
    }

    private void DisplayCustomers()
    {
        this.lstCustomers.Items.Clear();
        this.customerList.Sort();
        for (var i = 0; i < this.customerList.Count; i++)
        {
            var customer = this.customerList[i];
            this.lstCustomers.Items.Add(customer.GenerateDisplayText());
        }
    }
    /// <summary>
    /// Handles the Click event of the btnRemove control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
            this.lblMessage.Text = "Please select the customer you want to remove.";
        }
    }

    /// <summary>
    /// Handles the Click event of the btnEmpty control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
    /// <summary>
    /// Handles the Click event of the btnSelectAdditional control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void btnSelectAdditional_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}