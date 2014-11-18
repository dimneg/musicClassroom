using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Papi.Negkas.MusicClassroom
{
  /// <summary>
  /// A class to represent an instrument
  /// </summary>
  public class Instrument
    : TableObject
  {
    #region Public Properties

    /// <summary>
    /// Gets/Sets the name of the instrument
    /// </summary>
    public string Name
    {
      get { return m_Name; }
      set { m_Name = value; }
    }

    /// <summary>
    /// Gets/Sets the description of the instrument
    /// </summary>
    public string Description
    {
      get { return m_Description; }
      set { m_Description = value; }
    }

    /// <summary>
    /// Gets the image of the instrument
    /// </summary>
    public Bitmap Image
    {
      get { return m_Image.Value; }
    }

    #endregion Public Properties

    #region Public Methods

    /// <summary>
    /// Updates the image of the instrument
    /// </summary>
    /// <param name="FileName">
    /// Full path to the filename to use as the new image
    /// </param>
//    internal void UpdateImage(string FileName)
//    {
//      byte[] FileBytes = System.IO.File.ReadAllBytes(FileName);

//      System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand();
//      Command.Connection = DB.m_Connection;
//      Command.CommandText = @"UPDATE IN01_Instruments
//                                  SET    IN01_Image = @Pic
//                                  WHERE  IN01_Id = " + m_Id;
//      Command.Parameters.Add("@Pic", FileBytes);
//      Command.ExecuteNonQuery();
//    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="Id">
    /// The id of the instrument to load
    /// </param>
    public Instrument(int Id)
    {
      string SqlQuery = string.Format(m_Load, Id);

      using (SqlDataReader Reader = DB.GetReader(SqlQuery))
      {
        Reader.Read();

        m_Id = Reader.GetInteger("IN01_Id");
        m_Name = Reader.GetString("IN01_Name");
        m_Description = Reader.GetString("IN01_Description");
        m_ImageBytes = Reader.GetBytes("IN01_Image");
        m_Image = new Lazy<Bitmap>(LoadImage);
      }
    }

    #endregion Public Methods

    #region Private Methods

    /// <summary>
    /// Private constructor to be used when loading all the instruments at once
    /// </summary>
    /// <param name="Id">
    /// The id of the instrument
    /// </param>
    /// <param name="Name">
    /// The name of the instrument
    /// </param>
    /// <param name="Description">
    /// The description of the instrument
    /// </param>
    private Instrument(int Id, string Name, string Description, byte[] ImageBytes)
    {
      m_Id = Id;
      m_Name = Name;
      m_Description = Description;
      m_ImageBytes = ImageBytes;
      m_Image = new Lazy<Bitmap>(LoadImage);
    }

    /// <summary>
    /// Loads the image bitmap from the image bytes
    /// </summary>
    /// <returns>
    /// The image bitmap as loaded from the image bytes
    /// </returns>
    private Bitmap LoadImage()
    {
      using (MemoryStream stream = new MemoryStream(m_ImageBytes))
      {
        Bitmap bmp = new Bitmap(stream);
        return bmp;
      }
    }

    #endregion Private Methods

    #region Public Static Methods

    /// <summary>
    /// Loads all the instruments from the database
    /// </summary>
    /// <returns>
    /// A list of all the instruments from the database
    /// </returns>
    public static List<Instrument> GetAll()
    {
      List<Instrument> Instruments = new List<Instrument>();
      using (SqlDataReader Reader = DB.GetReader(m_LoadAll))
      {
        while (Reader.Read())
        {
          Instrument NewInstrument = new Instrument(Reader.GetInteger("IN01_Id"),
                                                    Reader.GetString("IN01_Name"),
                                                    Reader.GetString("IN01_Description"),
                                                    Reader.GetBytes("IN01_Image"));
          Instruments.Add(NewInstrument);
        }
      }
      return Instruments;
    }

    #endregion Public Static Methods

    #region Private Fields

    /// <summary>
    /// The name of the instrument
    /// </summary>
    private string m_Name;

    /// <summary>
    /// The description of the instrument
    /// </summary>
    private string m_Description;

    /// <summary>
    /// The bytes of the instrument image
    /// </summary>
    private byte[] m_ImageBytes;

    /// <summary>
    /// The image of the instrument
    /// </summary>
    private Lazy<Bitmap> m_Image;

    #endregion Private Fields

    #region Private static fields

    /// <summary>
    /// Sql template to load an instrument
    /// </summary>
    private const string m_Load =
      @"SELECT IN01_Id,
               IN01_Name,
               IN01_Description,
               IN01_Image
        FROM   IN01_Instruments
        WHERE  IN01_Id = {0}";

    /// <summary>
    /// Loads all the instruments from the database
    /// </summary>
    private const string m_LoadAll =
      @"SELECT IN01_Id,
               IN01_Name,
               IN01_Description,
               IN01_Image
        FROM   IN01_Instruments";

    #endregion Private static fields
  }

}
