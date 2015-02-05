using System.Diagnostics;

/// <summary>
///     Models a Customer object.
/// </summary>
/// <author>
///     Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public class Customer
{
    #region Instance variables

    /// <summary>
    ///     The _customer identifier
    /// </summary>
    private string _customerId;

    /// <summary>
    /// The _name
    /// </summary>
    private string _name;

    /// <summary>
    ///     The _firstName
    /// </summary>
    private string _firstName;

    /// <summary>
    /// The _last name
    /// </summary>
    private string _lastName;

    /// <summary>
    ///     The _address
    /// </summary>
    private string _address;

    /// <summary>
    ///     The _city
    /// </summary>
    private string _city;

    /// <summary>
    ///     The _state
    /// </summary>
    private string _state;

    /// <summary>
    ///     The _zipcode
    /// </summary>
    private string _zipCode;

    /// <summary>
    ///     The _email
    /// </summary>
    private string _email;

    /// <summary>
    ///     The _phone
    /// </summary>
    private string _phone;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the product identifier.
    /// </summary>
    /// <value>
    ///     The product identifier.
    /// </value>
    public string CustomerId
    {
        get { return this._customerId; }
        set
        {
            Trace.Assert(value != null, "Invalid Customer Id");
            this._customerId = value;
        }
    }

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>
    ///     The name.
    /// </value>
    public string FirstName
    {
        get { return this._firstName; }
        set
        {
            Trace.Assert(value != null, "Invalid FirstName");
            this._firstName = value;
        }
    }

    /// <summary>
    ///     Gets or sets the short description.
    /// </summary>
    /// <value>
    ///     The short description.
    /// </value>
    public string Address
    {
        get { return this._address; }
        set
        {
            Trace.Assert(value != null, "Invalid Address");
            this._address = value;
        }
    }

    /// <summary>
    ///     Gets or sets the long description.
    /// </summary>
    /// <value>
    ///     The long description.
    /// </value>
    public string City
    {
        get { return this._city; }
        set
        {
            Trace.Assert(value != null, "Invalid City");
            this._city = value;
        }
    }

    /// <summary>
    ///     Gets or sets the image file.
    /// </summary>
    /// <value>
    ///     The image file.
    /// </value>
    public string State
    {
        get { return this._state; }
        set
        {
            Trace.Assert(value != null, "Invalid state");
            this._state = value;
        }
    }

    /// <summary>
    ///     Gets or sets the zipcode.
    /// </summary>
    /// <value>
    ///     The zipcode.
    /// </value>
    public string ZipCode
    {
        get { return this._zipCode; }
        set
        {
            Trace.Assert(value != null, "Invalid zipcode");
            this._zipCode = value;
        }
    }

    /// <summary>
    ///     Gets or sets the email.
    /// </summary>
    /// <value>
    ///     The email.
    /// </value>
    public string Email
    {
        get { return this._email; }
        set
        {
            Trace.Assert(value != null, "Invalid email");
            this._email = value;
        }
    }

    /// <summary>
    ///     Gets or sets the phone.
    /// </summary>
    /// <value>
    ///     The phone.
    /// </value>
    public string Phone
    {
        get { return this._phone; }
        set
        {
            Trace.Assert(value != null, "Invalid phone");
            this._phone = value;
        }
    }

    /// <summary>
    /// Gets or sets the last name.
    /// </summary>
    /// <value>
    /// The last name.
    /// </value>
    public string LastName
    {
        get { return this._lastName; }
        set
        {
            Trace.Assert(value != null, "Invalid name");
            this._lastName = value;
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
            Trace.Assert(value != null, "Invalid name");
            this._name = value;
        }
    }

    #endregion
}