using System;
using System.Diagnostics;

/// <summary>
/// Models feedback from a customer.
/// </summary>
/// <author>
/// Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public class Feedback
{
    #region Instance Variables

    /// <summary>
    /// The customer identifier
    /// </summary>
    private string _customerId;
    /// <summary>
    /// The feedback identifier
    /// </summary>
    private string _feedbackId;
    /// <summary>
    /// The software identifier
    /// </summary>
    private string _softwareId;
    /// <summary>
    /// The support identifier
    /// </summary>
    private string _supportId;
    /// <summary>
    /// The date opened
    /// </summary>
    private DateTime _dateOpened;
    /// <summary>
    /// The date closed
    /// </summary>
    private DateTime _dateClosed;
    /// <summary>
    /// The title
    /// </summary>
    private string _title;
    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    #endregion

    #region Methods

    /// <summary>
    /// Returns a string representation of the feedback.
    /// </summary>
    /// <returns>
    /// a string representing the feedback
    /// </returns>
    public string FormatFeedback()
    {
        return "Feedback for software " + this._softwareId + " closed " +
               this._dateClosed.ToString("MM/dd/yyyy") + " (" + this._title + ")";
    }
    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the software identifier.
    /// </summary>
    /// <value>
    /// The software identifier.
    /// </value>
    public string SoftwareId
    {
        get { return this._softwareId; }
        set
        {
            Trace.Assert(value != null);
            this._softwareId = value;
        }
    }

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
    /// Gets or sets the date opened.
    /// </summary>
    /// <value>
    /// The date opened.
    /// </value>
    public DateTime DateOpened
    {
        get { return this._dateOpened; }
        set
        {
            Trace.Assert(value != null);
            this._dateOpened = value;
        }
    }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Title
    {
        get { return this._title; }
        set
        {
            Trace.Assert(value != null);
            this._title = value;
        }
    }

    /// <summary>
    /// Gets or sets the date closed.
    /// </summary>
    /// <value>
    /// The date closed.
    /// </value>
    public DateTime DateClosed
    {
        get { return this._dateClosed; }
        set
        {
            Trace.Assert(value != null);
            this._dateClosed = value;
        }
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>
    /// The description.
    /// </value>
    public string Description
    {
        get { return this._description; }
        set
        {
            Trace.Assert(value != null);
            this._description = value;
        }
    }

    /// <summary>
    /// Gets or sets the customer identifier.
    /// </summary>
    /// <value>
    /// The customer identifier.
    /// </value>
    public string CustomerId
    {
        get { return this._customerId; }
        set
        {
            Trace.Assert(value != null);
            this._customerId = value;
        }
    }

    /// <summary>
    /// Gets or sets the feedback identifier.
    /// </summary>
    /// <value>
    /// The feedback identifier.
    /// </value>
    public string FeedbackId
    {
        get { return this._feedbackId; }
        set
        {
            Trace.Assert(value != null);
            this._feedbackId = value;
        }
    }

    #endregion
}