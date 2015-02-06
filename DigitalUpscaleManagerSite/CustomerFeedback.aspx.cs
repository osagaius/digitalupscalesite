using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Code behind for the Customer Feedback page.
/// </summary>
/// <author>Osa Gaius</author>
/// <version>Spring 2015</version>
public partial class CustomerFeedback : Page
{
    private string customerID;
    private List<Feedback> customerFeedback;

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtCustomerID.Focus();
        this.customerFeedback = new List<Feedback>();

        if (!IsPostBack)
            this.ResetFeedbackPanel();
    }
    /// <summary>
    /// Handles the Click event of the btnFeedback control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnFeedback_Click(object sender, EventArgs e)
    {
        this.customerID = this.txtCustomerID.Text;
        var customerData = new DataView();
        if (IsValid)
        {
             customerData = this.GetCustomerData();
        }

        if (customerData != null && customerData.Count > 0)
        {
            this.lblFeedbackMessage.Text = "";
            this.pnlFeedback.Enabled = true;
            this.DisplayCustomerFeedback(customerData);
            this.lstFeedback.Focus();
            this.rfvFeedbackList.Enabled = true;
        }
        else
        {
            this.lblFeedbackMessage.Text = "No feedback found. Please check your ID.";
            this.ResetFeedbackPanel();
        }
    }

    private void ResetFeedbackPanel()
    {
        this.pnlFeedback.Enabled = false;
        this.lstFeedback.Items.Clear();
        this.rfvFeedbackList.Enabled = false;
    }

    private void DisplayCustomerFeedback(DataView customerData)
    {
        this.GenerateCustomerFeedbackList(customerData);
        var sorted = this.customerFeedback.OrderBy(x => x.DateClosed);

        foreach (var currentFeedback in sorted)
        {
            var item = new ListItem { Value = currentFeedback.FeedbackId, Text = currentFeedback.FormatFeedback() };
            this.lstFeedback.Items.Add(item);
        }
    }

    private void GenerateCustomerFeedbackList(DataView customerData)
    {
        this.customerFeedback.Clear();
        this.lstFeedback.Items.Clear();

        for (var i = 0; i < customerData.Count; i++)
        {
            var row = customerData[i];
            var feedback = GenerateFeedback(row);
            this.customerFeedback.Add(feedback);
        }
    }

    private static Feedback GenerateFeedback(DataRowView row)
    {
        return new Feedback()
        {
            CustomerId = row["CustomerID"].ToString(),
            FeedbackId = row["FeedbackID"].ToString(),
            SoftwareId = row["SoftwareID"].ToString(),
            SupportId = row["SupportID"].ToString(),
            DateOpened = Convert.ToDateTime(row["DateOpened"]).Date,
            DateClosed = Convert.ToDateTime(row["DateClosed"]).Date,
            Title = row["Title"].ToString(),
            Description = row["Description"].ToString()
        };
    }

    /// <summary>
    /// Gets the selected customer.
    /// </summary>
    /// <returns></returns>
    private DataView GetCustomerData()
    {
        var dataTable = (DataView)this.SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        if (dataTable == null || this.customerID.Length < 1)
        {
            return null;
        }
        dataTable.RowFilter = "CustomerID = " + this.customerID;
        return dataTable;
    }

    /// <summary>
    /// Handles the Click event of the btnSubmit control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (!IsValid)
        {
            return;
        }
        var description = this.GenerateDescription();

        Session["Contact"] = this.chbContact.Checked;

        Response.Redirect("FeedbackComplete.aspx");
    }

    private Description GenerateDescription()
    {
        return new Description()
        {
            CustomerId = Convert.ToInt32(this.customerID),
            FeedbackId = Convert.ToInt32(this.lstFeedback.SelectedItem.Value),
            ServiceTime = Convert.ToInt32(this.rblServiceTime.SelectedItem.Value),
            Efficiency = Convert.ToInt32(this.rblEfficiency.SelectedItem.Value),
            Resolution = Convert.ToInt32(this.rblResolution.SelectedItem.Value),
            Comments = this.txtComments.Text,
            Contact = this.chbContact.Checked,
            ContactMethod = this.rblContactMethod.SelectedValue
        };
    }
}