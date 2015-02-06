using System;
using System.Web.UI;

/// <summary>
/// Code behind for FeedbackComplete page
/// </summary>
/// <author>Osa Gaius</author>
/// <version>Spring 2015</version>
public partial class FeedbackComplete : Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Session["Contact"].Equals(true))
        {
            this.contact.Visible = false;
        }
    }
    /// <summary>
    /// Handles the Click event of the btnReturn control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerFeedback.aspx");
    }
}