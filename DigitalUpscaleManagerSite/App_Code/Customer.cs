using System.Diagnostics;

/// <summary>
/// Models a Customer object.
/// </summary>
/// <author>
/// Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public class Customer
{
    #region Instance variables
    /// <summary>
    /// The _customer identifier
    /// </summary>
    private string _customerId;
    /// <summary>
    /// The _name
    /// </summary>
    private string _name;
    /// <summary>
    /// The _address
    /// </summary>
    private string _address;
    /// <summary>
    /// The _city
    /// </summary>
    private string _city;
    /// <summary>
    /// The _state
    /// </summary>
    private string _state;
    /// <summary>
    /// The _zipcode
    /// </summary>
    private string _zipcode;
    /// <summary>
    /// The _email
    /// </summary>
    private string _email;
    /// <summary>
    /// The _phone
    /// </summary>
    private string _phone; 
    #endregion


    #region Properties
		// <summary>
    /// Gets or sets the product identifier.
    /// </summary>
    /// <value>
    /// The product identifier.
    /// </value>
    public string CustomerId
    {
        get { return _customerId; }
        set
        {
            Trace.Assert(value != null, "Invalid Customer Id");
            _customerId = value;
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
        get { return _name; }
        set
        {
            Trace.Assert(value != null, "Invalid Name");
            _name = value;
        }
    }

    /// <summary>
    /// Gets or sets the short description.
    /// </summary>
    /// <value>
    /// The short description.
    /// </value>
    public string Address
    {
        get { return _address; }
        set
        {
            Trace.Assert(value != null, "Invalid Address");
            _address = value;
        }
    }

    /// <summary>
    /// Gets or sets the long description.
    /// </summary>
    /// <value>
    /// The long description.
    /// </value>
    public string City
    {
        get { return _city; }
        set
        {
            Trace.Assert(value != null, "Invalid City");
            _city = value;
        }
    }


    /// <summary>
    /// Gets or sets the image file.
    /// </summary>
    /// <value>
    /// The image file.
    /// </value>
    public string State
    {
        get { return _state; }
        set
        {
            Trace.Assert(value != null, "Invalid state");
            _state = value;
        }
    }

    /// <summary>
    /// Gets or sets the zipcode.
    /// </summary>
    /// <value>
    /// The zipcode.
    /// </value>
    public string Zipcode
    {
        get { return _zipcode; }
        set
        {
            Trace.Assert(value != null, "Invalid zipcode");
            _zipcode = value;
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
        get { return _email; }
        set
        {
            Trace.Assert(value != null, "Invalid email");
            _email = value;
        }
    }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    /// <value>
    /// The phone.
    /// </value>
    public string Phone
    {
        get { return _phone; }
        set
        {
            Trace.Assert(value != null, "Invalid phone");
            _phone = value;
        }
    } 
	#endregion
}