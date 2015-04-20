using System;
using System.Diagnostics;

/// <summary>
/// Models a software product in the database.
/// </summary>
/// <author>Osa Gaius</author>
/// <version>Spring 2015</version>
public class Product
{

    #region Instance Variables

    /// <summary>
    /// The software identifier
    /// </summary>
    private string _softwareId;
    /// <summary>
    /// The support identifier
    /// </summary>
    private string _name;
    /// <summary>
    /// The release date
    /// </summary>
    private DateTime _date;
    /// <summary>
    /// The title
    /// </summary>
    private string _version;

    #endregion

    #region Methods


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
    /// Gets or sets the date opened.
    /// </summary>
    /// <value>
    /// The date opened.
    /// </value>
    public DateTime Date
    {
        get { return this._date; }
        set
        {
            Trace.Assert(value != null);
            this._date = value;
        }
    }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Version
    {
        get { return this._version; }
        set
        {
            Trace.Assert(value != null);
            this._version = value;
        }
    }

    #endregion
}