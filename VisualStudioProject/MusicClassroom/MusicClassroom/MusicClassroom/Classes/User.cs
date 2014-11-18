using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Papi.Negkas.MusicClassroom;
using System.Data.SqlClient;

namespace Papi.Negkas.MusicClassroom
{
  /// <summary>
  /// A class to represent a user entity in the database
  /// </summary>
  public class User
    : TableObject
  {
    #region Public Properties

    /// <summary>
    /// Gets/Sets the UserName of the user
    /// </summary>
    public string UserName
    {
      get { return m_UserName; }
      set { m_UserName = value; }
    }

    /// <summary>
    /// Gets/Sets the password of the user
    /// </summary>
    public string Password
    {
      get { return m_Password; }
      set { m_Password = value; }
    }

    /// <summary>
    /// Gets/Sets the name of the user
    /// </summary>
    public string Name
    {
      get { return m_Name; }
      set { m_Name = value; }
    }

    /// <summary>
    /// Gets/Sets the surname of the user
    /// </summary>
    public string Surname
    {
      get { return m_Surname; }
      set { m_Surname = value; }
    }

    /// <summary>
    /// Gets/Sets the age of the user
    /// </summary>
    public int Age
    {
      get { return m_Age; }
      set { m_Age = value; }
    }

    /// <summary>
    /// Gets/Sets the theory experience of the user
    /// </summary>
    public int TheoryExperience
    {
      get { return m_TheoryExperience; }
      set { m_TheoryExperience = value; }
    }

    /// <summary>
    /// Gets/Sets the gender of the user
    /// </summary>
    public bool IsFemale
    {
      get { return m_IsFemale; }
      set { m_IsFemale = value; }
    }
    

    #endregion Public Properties

    #region Public Methods

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="UserName">
    /// The username
    /// </param>
    /// <param name="Password">
    /// The password of the user to load
    /// </param>
    public User(string UserName, string Password)
    {

      string SqlQuery = string.Format(m_LoadFromCredentials,
                                      DB.PrepareForSql(UserName),
                                      DB.PrepareForSql(Password));

      using (SqlDataReader Reader = DB.GetReader(SqlQuery))
      {
        Reader.Read();

        m_Id = Reader.GetInteger("US01_Id");
        m_UserName = Reader.GetString("US01_UserName");
        m_Password = Reader.GetString("US01_Password");
        m_Name = Reader.GetString("US01_Name");
        m_Surname = Reader.GetString("US01_Surname");
        m_Age = Reader.GetInteger("US01_Age");
        m_TheoryExperience = Reader.GetInteger("US01_TheoryExperience");
        m_IsFemale = Reader.GetBoolean("US01_Gender");        
      }
    }

    #endregion Public Methods

    #region Private Fields

    /// <summary>
    /// The user name of the user
    /// </summary>
    private string m_UserName;

    /// <summary>
    /// The password of the user
    /// </summary>
    private string m_Password;

    /// <summary>
    /// The name of the user
    /// </summary>
    private string m_Name;

    /// <summary>
    /// The surname of the user
    /// </summary>
    private string m_Surname;

    /// <summary>
    /// The age of the user
    /// </summary>
    private int m_Age;

    /// <summary>
    /// The theory experience of the user
    /// </summary>
    private int m_TheoryExperience;

    /// <summary>
    /// The gender of the user
    /// </summary>
    private bool m_IsFemale;

    #endregion Public Fields

    #region Private Static Fields

    /// <summary>
    /// An sql template for loading the user by specifying the credentials
    /// </summary>
    private const string m_LoadFromCredentials =
      @"SELECT TOP (1)
               US01_Id,
               US01_UserName,
               US01_Password,
               US01_Name,
               US01_Surname,
               US01_Age,
               US01_TheoryExperience,
               US01_Gender
        FROM   US01_Users
        WHERE  US01_UserName = N'{0}'
        AND    US01_Password = N'{1}'";

    #endregion Private Static Fields
  }
}
