using System.Collections;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Data.OleDb;

/// <summary>
/// The object data class to interact with the database
/// and deal with support objects.
/// </summary>
/// <author>
/// Osa Gaius
/// </author>
/// <version>
/// Spring 2015
/// </version>
[DataObject(true)]
public static class SupportDatabase
{
    /// <summary>
    /// Gets all the support staff.
    /// </summary>
    /// <returns>
    /// Collection of support staff
    /// </returns>
    /// <exception cref="System.IO.InvalidDataException">Could not execute query</exception>
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetAllSupportStaff()
    {
        var supportList = new List<Support>();
        var connection = new OleDbConnection(GetConnectionString());
        const string statement = "SELECT SupportId, Name, Email, Phone "
            + "FROM Support ORDER BY Name";
        var command = new OleDbCommand(statement, connection);
        connection.Open();
        var dataReader =
            command.ExecuteReader(CommandBehavior.CloseConnection);
        if (dataReader == null)
            throw new InvalidDataException("Could not execute query");

        while (dataReader.Read())
        {
            var current = new Support()
            {
                SupportId = dataReader["SupportId"].ToString(),
                Name = dataReader["Name"].ToString(),
                Email = dataReader["Email"].ToString(),
                Phone = dataReader["Phone"].ToString(),
            };
            supportList.Add(current);
        }


        dataReader.Close();
        connection.Close();
        return supportList;
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