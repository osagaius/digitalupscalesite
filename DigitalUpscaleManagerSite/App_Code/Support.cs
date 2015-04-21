using System.Diagnostics;


/// <summary>
/// Summary description for Support
/// </summary>
public class Support
{
    #region Instance Variables

    /// <summary>
    /// The support identifier
    /// </summary>
    private string _supportId;
    /// <summary>
    /// The support name
    /// </summary>
    private string _name;
    /// <summary>
    /// The email
    /// </summary>
    private string _email;
    /// <summary>
    /// The phone
    /// </summary>
    private string _phone;

    #endregion

    #region Methods


    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the support identifier.
    /// </summary>
    /// <value>
    /// The support identifier.
    /// </value>
    public string SupportId
    {
        get { return this._supportId; }
        set
        {
            Trace.Assert(value != null);
            this._supportId = value;
        }
    }


    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name
    {
        get { return this._name; }
        set
        {
            Trace.Assert(value != null);
            this._name = value;
        }
    }


    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    public string Email
    {
        get { return this._email; }
        set
        {
            Trace.Assert(value != null);
            this._email = value;
        }
    }

=
    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    /// <value>
    /// The phone.
    /// </value>
    public string Phone
    {
        get { return this._phone; }
        set
        {
            Trace.Assert(value != null);
            this._phone = value;
        }
    }

    #endregion
}