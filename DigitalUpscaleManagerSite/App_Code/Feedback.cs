using System;
using System.Diagnostics;

/// <summary>
/// Models feedback from a customer.
/// </summary>
/// <author>
///     Osa Gaius
/// </author>
/// <version>Spring 2015</version>
public class Feedback
{
    #region Instance Variables
    private string feedbackID;
    private string customerID;
    private string softwareID;
    private string supportID;
    private DateTime dateOpened;
    private DateTime dateClosed;
    private string title;
    private string description;

    #endregion

    #region Methods

    /// <summary>
    /// Returns a string representation of the feedback.
    /// </summary>
    /// <returns>a string representing the feedback</returns>
    public string FormatFeedback()
    {
        return "Feedback for software " + this.softwareID + " closed " +
               this.dateClosed + " (" + this.title + ")";
    }
    #endregion

    #region Properties
    public string FeedbackId
    {
        get { return this.feedbackID; }
        set
        {
            Trace.Assert(value != null);
            this.feedbackID = value;
        }
    }

    public string CustomerId
    {
        get { return this.customerID; }
        set
        {
            Trace.Assert(value != null);
            this.customerID = value;
        }
    }

    public string SoftwareId
    {
        get { return this.softwareID; }
        set
        {
            Trace.Assert(value != null);
            this.softwareID = value;
        }
    }

    public string SupportId
    {
        get { return this.supportID; }
        set
        {
            Trace.Assert(value != null);
            this.supportID = value;
        }
    }

    public DateTime DateOpened
    {
        get { return this.dateOpened; }
        set
        {
            Trace.Assert(value != null);
            this.dateOpened = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            Trace.Assert(value != null);
            this.title = value;
        }
    }

    public DateTime DateClosed
    {
        get { return this.dateClosed; }
        set
        {
            Trace.Assert(value != null);
            this.dateClosed = value;
        }
    }

    public string Description
    {
        get { return this.description; }
        set
        {
            Trace.Assert(value != null);
            this.description = value;
        }
    } 
    #endregion
}