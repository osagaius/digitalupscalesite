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
    private string customerID;
    /// <summary>
    /// The feedback identifier
    /// </summary>
    private string feedbackID;
    /// <summary>
    /// The software identifier
    /// </summary>
    private string softwareID;
    /// <summary>
    /// The support identifier
    /// </summary>
    private string supportID;
    /// <summary>
    /// The date opened
    /// </summary>
    private DateTime dateOpened;
    /// <summary>
    /// The date closed
    /// </summary>
    private DateTime dateClosed;
    /// <summary>
    /// The title
    /// </summary>
    private string title;
    /// <summary>
    /// The description
    /// </summary>
    private string description;

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
        return "Feedback for software " + this.softwareID + " closed " +
               this.dateClosed.ToString("MM/dd/yyyy") + " (" + this.title + ")";
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
        get { return this.softwareID; }
        set
        {
            Trace.Assert(value != null);
            this.softwareID = value;
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
        get { return this.supportID; }
        set
        {
            Trace.Assert(value != null);
            this.supportID = value;
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
        get { return this.dateOpened; }
        set
        {
            Trace.Assert(value != null);
            this.dateOpened = value;
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
        get { return this.title; }
        set
        {
            Trace.Assert(value != null);
            this.title = value;
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
        get { return this.dateClosed; }
        set
        {
            Trace.Assert(value != null);
            this.dateClosed = value;
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
        get { return this.description; }
        set
        {
            Trace.Assert(value != null);
            this.description = value;
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
        get { return this.customerID; }
        set
        {
            Trace.Assert(value != null);
            this.customerID = value;
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
        get { return this.feedbackID; }
        set
        {
            Trace.Assert(value != null);
            this.feedbackID = value;
        }
    }

    #endregion
}