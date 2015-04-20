using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
}