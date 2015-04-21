using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Data.OleDb;

/// <summary>
/// The object data class to interact with the database
/// and deal with feedback objects.
/// </summary>
/// <author>
/// Osa Gaius
/// </author>
/// <version>
/// Spring 2015
/// </version>
[DataObject(true)]
public class FeedbackDatabase
{
    /// <summary>
    /// Gets the open feedback incidents.
    /// </summary>
    /// <param name="supportStaffId">The support staff identifier.</param>
    /// <returns></returns>
    /// <exception cref="System.IO.InvalidDataException">Could not execute query</exception>
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetOpenFeedbackIncidents(int supportStaffId)
    {
        var feedbackList = new List<Feedback>();
        var connection = new OleDbConnection(GetConnectionString());
        const string statement = "SELECT Customer.Name, Feedback.DateOpened, Software.Name AS Software " +
                                 "FROM ((Customer INNER JOIN Feedback ON Customer.CustomerID = Feedback.CustomerID) " +
                                 "INNER JOIN Software ON Feedback.SoftwareID = Software.SoftwareID) " +
                                 "WHERE (Feedback.SupportID = @SupportID) AND (Feedback.DateClosed IS NULL)";

        var command = new OleDbCommand(statement, connection);
        command.Parameters.AddWithValue("SupportID", supportStaffId.ToString(CultureInfo.CurrentCulture));

        connection.Open();
        var dataReader =
            command.ExecuteReader(CommandBehavior.CloseConnection);
        if (dataReader == null)
            throw new InvalidDataException("Could not execute query");

        if (dataReader.Depth == 0)
        {
            connection.Close();
            return feedbackList;
        }

        while (dataReader.Read())
        {
            var current = new Feedback
            {
                Customer = dataReader["Customer.Name"].ToString(),
                DateOpened = DateTime.Parse(dataReader["Feedback.DateOpened"].ToString()),
                SoftwareName = dataReader["Software.Name"].ToString(),
            };
            feedbackList.Add(current);
        }


        dataReader.Close();
        return feedbackList;
    }

    /// <summary>
    /// Gets the connection string.
    /// </summary>
    /// <returns></returns>
    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["DigitalUpscaleConnectionString"].ConnectionString;
    }
}