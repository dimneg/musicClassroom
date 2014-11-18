using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Papi.Negkas.MusicClassroom.Classes
{
    public class QuestionTypes
      : TableObject
    {
      #region Public Properties

      /// <summary>
      /// Gets the description of the question type
      /// </summary>
      public string Description
      {
        get { return m_Description; }
        set { m_Description = value; }
      }

      #endregion Public Properties

      #region Private Fields

      /// <summary>
      /// The description of the question type
      /// </summary>
      private string m_Description;

      #endregion Private Fields
    }
}
