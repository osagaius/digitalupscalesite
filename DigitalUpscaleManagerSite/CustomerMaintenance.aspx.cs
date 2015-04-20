using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Code behind for the CustomerMaintenance page.
/// </summary>
public partial class CustomerMaintenance : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        this.lblError.Text = "";
    }

    /// <summary>
    /// Handles the ItemDeleted event of the dvSelectedCustomer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="DetailsViewDeletedEventArgs"/> instance containing the event data.</param>
    protected void dvSelectedCustomer_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            gvCustomers.DataBind();
        }
    }
    /// <summary>
    /// Handles the ItemUpdated event of the dvSelectedCustomer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="DetailsViewUpdatedEventArgs"/> instance containing the event data.</param>
    protected void dvSelectedCustomer_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
        {
            this.lblError.Text = "Another user may have updated this customer. Try again";
        }
        else
        {
            gvCustomers.DataBind();
        }
    }
    /// <summary>
    /// Handles the ItemInserted event of the dvSelectedCustomer control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="DetailsViewInsertedEventArgs"/> instance containing the event data.</param>
    protected void dvSelectedCustomer_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            gvCustomers.DataBind();
        }
    }
}