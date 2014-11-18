using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Papi.Negkas.MusicClassroom
{
  /// <summary>
  /// A class from which all the table object inherit from
  /// </summary>
  public abstract class TableObject
  {
    #region Public Properties

    public int Id
    {
      get { return m_Id; }
      private set { m_Id = value; }
    }

    #endregion Public Properties

    #region Protected Fields

    /// <summary>
    /// The table id
    /// </summary>
    protected int m_Id;

    #endregion Protected Fields
  }
}
