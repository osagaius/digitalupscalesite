using System;

/// <summary>
/// 
/// </summary>
public partial class MaintainSupport : System.Web.UI.Page
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


    protected void fvSelectedStaff_ItemUpdated(object sender, System.Web.UI.WebControls.FormViewUpdatedEventArgs e)
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
            ddlSupport.DataBind();
        }
    }
    protected void fvSelectedStaff_ItemDeleted(object sender, System.Web.UI.WebControls.FormViewDeletedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            ddlSupport.DataBind();
        }
    }
    protected void fvSelectedStaff_ItemInserted(object sender, System.Web.UI.WebControls.FormViewInsertedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            ddlSupport.DataBind();
        }
    }
}