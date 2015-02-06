﻿using System;
using System.Web.UI;

/// <summary>
/// Code behind for the Customer Feedback page.
/// </summary>
public partial class CustomerFeedback : Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        this.txtCustomerID.Focus();
        if (!IsPostBack)
            this.pnlFeedback.Enabled = false;
    }
}