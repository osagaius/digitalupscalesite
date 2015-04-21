using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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
        this.lblError.Text = "";
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
    /// <summary>
    /// Handles the Click event of the btnAddProduct control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
        {
            return;
        }

        try
        {
            var product = CreateProductFromEntry();
            AddProductToDatabase(product);
        }
        catch (OleDbException ex)
        {
            this.lblError.Text += ex.Message;
        }

        ClearTextBoxes();
    }

    /// <summary>
    /// Creates the product from the user's entry entry.
    /// </summary>
    /// <returns></returns>
    private Product CreateProductFromEntry()
    {
        var product = new Product()
        {
            SoftwareId = this.txtID.Text,
            Name = this.txtName.Text,
            Version = this.txtVersion.Text,
            Date = DateTime.Parse(this.txtDate.Text)
        };
        return product;
    }

    /// <summary>
    /// Clears the text boxes.
    /// </summary>
    private void ClearTextBoxes()
    {
        this.txtName.Text = "";
        this.txtID.Text = "";
        this.txtVersion.Text = "";
        this.txtDate.Text = "";
    }

    /// <summary>
    /// Adds a product to database.
    /// </summary>
    /// <param name="product">The product.</param>
    private void AddProductToDatabase(Product product)
    {
        var strConnString = ConfigurationManager.ConnectionStrings["DigitalManagerConnectionString"].ConnectionString;
        using (var con = new OleDbConnection(strConnString))
        {
            using (var cmd = new OleDbCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [Software] VALUES(@SoftwareID, @Name, @Version, @ReleaseDate)";
                cmd.Parameters.AddWithValue("@SoftwareID", product.SoftwareId);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Version", product.Version);
                cmd.Parameters.AddWithValue("@ReleaseDate", product.Date);
                con.Open();
                var affected = cmd.ExecuteNonQuery();
                con.Close();

                if (affected == -1)
                {
                    this.lblError.Text += "The product could not be added";
                }
                else
                {
                    Response.Redirect("Products.aspx");
                }
            }
        }
    }
    /// <summary>
    /// Handles the RowDeleted event of the gvProducts control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="GridViewDeletedEventArgs"/> instance containing the event data.</param>
    protected void gvProducts_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        this.lblError.Text = "";
        if (e.Exception != null)
        {
            this.lblError.Text = "A database error has occurred.<br /<br />" + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else
        {
            gvProducts.DataBind();
        }
    }
    /// <summary>
    /// Handles the RowUpdated event of the gvProducts control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="GridViewUpdatedEventArgs"/> instance containing the event data.</param>
    protected void gvProducts_RowUpdated(object sender, GridViewUpdatedEventArgs e)
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
            gvProducts.DataBind();
        }
        EnableProductPanel();
    }
    /// <summary>
    /// Handles the RowEditing event of the gvProducts control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="GridViewEditEventArgs"/> instance containing the event data.</param>
    protected void gvProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        DisableProductPanel();
    }
    /// <summary>
    /// Handles the RowCancelingEdit event of the gvProducts control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="GridViewCancelEditEventArgs"/> instance containing the event data.</param>
    protected void gvProducts_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        EnableProductPanel();
    }
    /// <summary>
    /// Disables the product panel.
    /// </summary>
    private void DisableProductPanel()
    {
        pnlAddProduct.Enabled = false;
        rfvDate.Enabled = false;
        rfvID.Enabled = false;
        rfvName.Enabled = false;
        rfvVersion.Enabled = false;
    }

    /// <summary>
    /// Enables the product panel.
    /// </summary>
    private void EnableProductPanel()
    {
        pnlAddProduct.Enabled = true;
        rfvDate.Enabled = true;
        rfvID.Enabled = true;
        rfvName.Enabled = true;
        rfvVersion.Enabled = true;
    }

}