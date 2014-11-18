using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Papi.Negkas.MusicClassroom.Properties;

namespace Papi.Negkas.MusicClassroom
{
  public static class DB
  {
    #region Public Static Methods

    /// <summary>
    /// Connects to the database
    /// </summary>
    public static void Connect()
    {
      string ConnectionString = string.Format(m_ConnectionStringTemplate,
                                              Settings.Default.ServerName,
                                              int.MaxValue);
      m_Connection = new SqlConnection(ConnectionString);
      m_Connection.Open();      
    }

    /// <summary>
    /// Executes an SQL query and returns the data reader
    /// </summary>
    /// <param name="SqlQuery">
    /// The SQL query to execute
    /// </param>
    /// <returns>
    /// The data reader containing the result
    /// </returns>
    public static SqlDataReader GetReader(string SqlQuery)
    {
      SqlCommand Command = new SqlCommand(SqlQuery, m_Connection);
      return Command.ExecuteReader();
    }

    /// <summary>
    /// Disconnects from the database
    /// </summary>
    public static void Disconnect()
    {
      m_Connection.Close();
      m_Connection.Dispose();
    }

    /// <summary>
    /// Prepares a string for use in an sql query
    /// </summary>
    /// <param name="Text">
    /// The text to prepare
    /// </param>
    /// <returns>
    /// The safe string that can be used in sql
    /// </returns>
    public static string PrepareForSql(string Text)
    {
      // Escape character so that they can safely be used in SQL
      return Text;
    }

    /// <summary>
    /// Gets a string from the column with the specified name
    /// </summary>
    /// <param name="Reader">
    /// The reader from which to get the string
    /// </param>
    /// <param name="FieldName">
    /// The field name
    /// </param>
    /// <returns>
    /// The string value of the field
    /// </returns>
    public static string GetString(this SqlDataReader Reader,
                                   string FieldName)
    {
      int Ordinal = Reader.GetFieldOrdinal(FieldName);
      return Reader.GetString(Ordinal);
    }

    /// <summary>
    /// Reads an integer from the specified column
    /// </summary>
    /// <param name="Reader">
    /// The reader from which to read the integer
    /// </param>
    /// <param name="FieldName">
    /// The name of the column
    /// </param>
    /// <returns>
    /// The integer value read
    /// </returns>
    public static int GetInteger(this SqlDataReader Reader,
                                 string FieldName)
    {
      int Ordinal = Reader.GetFieldOrdinal(FieldName);
      return Reader.GetInt32(Ordinal);
    }

    /// <summary>
    /// Gets a boolean value from the reader
    /// </summary>
    /// <param name="Reader">
    /// The reader to get the value from
    /// </param>
    /// <param name="FieldName">
    /// The column from which to reader the boolean value
    /// </param>
    /// <returns>
    /// The boolen value read
    /// </returns>
    public static bool GetBoolean(this SqlDataReader Reader,
                                 string FieldName)
    {
      int Ordinal = Reader.GetFieldOrdinal(FieldName);
      return Reader.GetBoolean(Ordinal);
    }

    /// <summary>
    /// Reads bytes from the reader
    /// </summary>
    /// <param name="Reader">
    /// The reader to read the bytes from
    /// </param>
    /// <param name="FieldName">
    /// The name of the column from which to load the bytes from
    /// </param>
    /// <returns>
    /// A byte array with the contents of the column
    /// </returns>
    public static byte[] GetBytes(this SqlDataReader Reader,
                                  string FieldName)
    {
      int Ordinal = Reader.GetFieldOrdinal(FieldName);
      int Length = (int)Reader.GetBytes(Ordinal, 0, null, 0, 0);
      byte[] Bytes = new byte[Length];
      Reader.GetBytes(Ordinal, 0, Bytes, 0, Length);
      return Bytes;
    }

    #endregion Public Static Methods

    #region Private Static Methods

    /// <summary>
    /// Gets the field ordinal matching the field name
    /// </summary>
    /// <param name="Reader">
    /// The reader from which to extract the field ordinal
    /// </param>
    /// <param name="FieldName">
    /// The name of the field which ordinal to retrieve
    /// </param>
    /// <returns>
    /// The ordianl of the specified field name, -1 if not found
    /// </returns>
    private static int GetFieldOrdinal(this SqlDataReader Reader,
                                       string FieldName)
    {
      for (int i = 0; i < Reader.FieldCount; i++)
      {
        if (Reader.GetName(i) == FieldName)
        {
          return i;
        }
      }
      return -1;
    }

    #endregion Private Static Methods


    #region Private Static Fields

    /// <summary>
    /// Used for accessing the database
    /// </summary>
    internal static SqlConnection m_Connection;

    /// <summary>
    /// Template to use as connection string
    /// </summary>
    private const string m_ConnectionStringTemplate =
      "server={0};Trusted_Connection=yes;database=musicProjectNegkas;connection timeout={1}";

    #endregion Private Static Fields
  }
}
