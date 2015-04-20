using System.Diagnostics;

/// <summary>
/// Models the description of feedback from a customer.
/// </summary>
/// <author>
/// Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public class Description
{
    #region Instance Variables

    /// <summary>
    /// The comments
    /// </summary>
    private string _comments;

    /// <summary>
    /// The contact method
    /// </summary>
    private string _contactMethod; 
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the customer identifier.
    /// </summary>
    /// <value>
    /// The customer identifier.
    /// </value>
    public int CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the feedback identifier.
    /// </summary>
    /// <value>
    /// The feedback identifier.
    /// </value>
    public int FeedbackId { get; set; }

    /// <summary>
    /// Gets or sets the service time.
    /// </summary>
    /// <value>
    /// The service time.
    /// </value>
    public int ServiceTime { get; set; }

    /// <summary>
    /// Gets or sets the efficiency.
    /// </summary>
    /// <value>
    /// The efficiency.
    /// </value>
    public int Efficiency { get; set; }

    /// <summary>
    /// Gets or sets the resolution.
    /// </summary>
    /// <value>
    /// The resolution.
    /// </value>
    public int Resolution { get; set; }

    /// <summary>
    /// Gets or sets the comments.
    /// </summary>
    /// <value>
    /// The comments.
    /// </value>
    public string Comments
    {
        get { return this._comments; }
        set
        {
            Trace.Assert(value != null);
            this._comments = value;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="Description"/> is contact.
    /// </summary>
    /// <value>
    ///   <c>true</c> if contact; otherwise, <c>false</c>.
    /// </value>
    public bool Contact { get; set; }

    /// <summary>
    /// Gets or sets the contact method.
    /// </summary>
    /// <value>
    /// The contact method.
    /// </value>
    public string ContactMethod
    {
        get { return this._contactMethod; }
        set
        {
            Trace.Assert(value != null);
            this._contactMethod = value;
        }
    } 
    #endregion
}