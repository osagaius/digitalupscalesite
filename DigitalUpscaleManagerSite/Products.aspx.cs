using System;
using System.Web.UI.WebControls;

/// <summary>
/// Code behind for the Products page.
/// </summary>
public partial class Products : System.Web.UI.Page
{
    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Handles the ServerValidate event of the date entry control.
    /// </summary>
    /// <param name="source">The source of the event.</param>
    /// <param name="args">The <see cref="ServerValidateEventArgs"/> instance containing the event data.</param>
    protected void valDateRange_ServerValidate(object source, ServerValidateEventArgs args)
    {
        DateTime minDate = DateTime.Parse("1000/12/28");
        DateTime maxDate = DateTime.Parse("9999/12/28");
        DateTime dt;

        args.IsValid = (DateTime.TryParse(args.Value, out dt)
                        && dt <= maxDate
                        && dt >= minDate);
    }
}