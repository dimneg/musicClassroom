using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Papi.Negkas.MusicClassroom.Ux
{
  static class Program
  {
    /// <summary>
    /// The data set used throughout the project
    /// </summary>
    public static DataSet Tables
    {
      get
      {
        if (m_DataSet == null)
        {
          m_DataSet = new DataSet();
          m_DataSet.Load();
        }
        return m_DataSet;
      }
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Show the login form and get the logged user
      int LoggedUserId = Login();
      if (LoggedUserId != 0)
      {
        Application.Run(new Main(LoggedUserId));
      }
    }

    /// <summary>
    /// Shows the login form
    /// </summary>
    /// <returns>
    /// The id of the logged user, 0 on failure
    /// </returns>
    private static int Login()
    {
      using (LoginForm Login = new LoginForm())
      {
        Login.ShowDialog();
        if (Login.DialogResult == DialogResult.OK)
        {
          return Login.UserId;
        }
        return 0;
      }
    }


    /// <summary>
    /// The dataset used throught the project
    /// </summary>
    private static DataSet m_DataSet;
  }
}
