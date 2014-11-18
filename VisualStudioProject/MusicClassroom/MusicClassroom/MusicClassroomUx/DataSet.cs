using System.Data.Common;
using System.Data.SqlClient;
using Papi.Negkas.MusicClassroom.Ux.DataSetTableAdapters;
using System.Data;
using System.Collections.Generic;

namespace Papi.Negkas.MusicClassroom.Ux
{
  public partial class DataSet
  {
    partial class Tr04_Access_ObjectDataTable
    {
      public void Load()
      {
        var ta = new Tr04_Access_ObjectTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        var ta = new Tr04_Access_ObjectTableAdapter();
        ta.Update(this);
      }
    }

    partial class SP01_SpecialAbilitiesDataTable
    {
      public void Load()
      { //new entry 5/12/2012
        SP01_SpecialAbilitiesTableAdapter ta = new SP01_SpecialAbilitiesTableAdapter(); 
        
        ta.Fill(this);
      }
      public void Save()
      {
        //new entry 5/12/2012
        SP01_SpecialAbilitiesTableAdapter ta = new SP01_SpecialAbilitiesTableAdapter(); 
        ta.Update(this);
      }
    }
    partial class Us03_Users_InstrumentsDataTable
    {
      public void Load()
      { //new entry 23/12/2012
        Us03_Users_InstrumentsTableAdapter ta = new Us03_Users_InstrumentsTableAdapter();

        ta.Fill(this);
      }
      public void Save()
      {
        //new entry 23/12/2012
        Us03_Users_InstrumentsTableAdapter ta = new Us03_Users_InstrumentsTableAdapter();
        ta.Update(this);
      }
    }
    partial class Us06_User_Music_GenresDataTable
    {
        public void Load()
        { //new entry 23/12/2012
            Us06_User_Music_GenresTableAdapter ta = new Us06_User_Music_GenresTableAdapter();

            ta.Fill(this);
        }
        public void Save()
        {
            //new entry 23/12/2012
            Us06_User_Music_GenresTableAdapter ta = new Us06_User_Music_GenresTableAdapter();
            ta.Update(this);
        }
    }
    partial class IN01_InstrumentsDataTable
    {
      public void Load()
      {
        IN01_InstrumentsTableAdapter ta = new IN01_InstrumentsTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        IN01_InstrumentsTableAdapter ta = new IN01_InstrumentsTableAdapter();
        ta.Update(this);
      }
    }
  
    partial class QS01_TypesDataTable
    {
      public void Load()
      {
        QS01_TypesTableAdapter ta = new QS01_TypesTableAdapter();
        ta.Fill(this);
      }
    }

    partial class US02_UserTestsDataTable
    {
      public void Load()
      {
        US02_UserTestsTableAdapter ta = new US02_UserTestsTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        US02_UserTestsTableAdapter ta = new US02_UserTestsTableAdapter();
        ta.Update(this);
        ta.Fill(this);

        // Reload the users table to get the latest level values
        ((DataSet)this.DataSet).US01_Users.Load();
      }
    }

    partial class QS06_TestLevelsDataTable
    {
      public void Load()
      {
        QS06_TestLevelsTableAdapter ta = new QS06_TestLevelsTableAdapter();
        ta.Fill(this);
      }
    }

    partial class QS02_CategoriesDataTable
    {
      public void Load()
      {
        QS02_CategoriesTableAdapter ta = new QS02_CategoriesTableAdapter();
        ta.Fill(this);
      }
    }

    partial class QS05_AnswersDataTable
    {
      public void Load()
      {
        QS05_AnswersTableAdapter ta = new QS05_AnswersTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        QS05_AnswersTableAdapter ta = new QS05_AnswersTableAdapter();
        ta.Update(this);
      }
    }

    partial class QS04_QuestionsDataTable
    {
      public void Load()
      {
        QS04_QuestionsTableAdapter ta = new QS04_QuestionsTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        QS04_QuestionsTableAdapter ta = new QS04_QuestionsTableAdapter();
        ta.Update(this);
      }
    }

    partial class QS03_TestsDataTable
    {
      public void Load()
      {
        QS03_TestsTableAdapter ta = new QS03_TestsTableAdapter();
        ta.Fill(this);
      }
    }

    partial class Sp02_Tree_L1DataTable
    {
        public void Load()
        {
            Sp02_Tree_L1TableAdapter ta = new Sp02_Tree_L1TableAdapter();
            ta.Fill(this);
        }

        public void Save()
        {
            Sp02_Tree_L1TableAdapter ta = new Sp02_Tree_L1TableAdapter();
            ta.Update(this);
        }
    }

    partial class Sp04_Tree2_L2DataTable
    {
        public void Load()
        {
            Sp04_Tree2_L2TableAdapter ta = new Sp04_Tree2_L2TableAdapter();
            ta.Fill(this);
        }

        public void Save()
        {
            Sp04_Tree2_L2TableAdapter ta = new Sp04_Tree2_L2TableAdapter();
            ta.Update(this);
        }
    }
    partial class Set01_SettingsDataTable
    {
      public void Load()
      {
        Set01_SettingsTableAdapter ta = new Set01_SettingsTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        Set01_SettingsTableAdapter ta = new Set01_SettingsTableAdapter();
        ta.Update(this);
      }
    }
    partial class Set02_SoundsDataTable
    {
      public void Load()
      {
        Set02_SoundsTableAdapter ta = new Set02_SoundsTableAdapter();
        ta.Fill(this);
      }
    }
    partial class Pl03_Poll_MusicGenresDataTable
    {
        public void Load()
        {
            Pl03_Poll_MusicGenresTableAdapter ta = new Pl03_Poll_MusicGenresTableAdapter();
            ta.Fill(this);
        }

        public void Save()
        {
            Pl03_Poll_MusicGenresTableAdapter ta = new Pl03_Poll_MusicGenresTableAdapter();
            ta.Update(this);
        }
    }
    partial class Tr03_Theory_VisitsDataTable
    {
        public void Load()
        {
            Tr03_Theory_VisitsTableAdapter ta = new Tr03_Theory_VisitsTableAdapter();
            ta.Fill(this);
        }

        public void Save()
        {
            Tr03_Theory_VisitsTableAdapter ta = new Tr03_Theory_VisitsTableAdapter();
            ta.Update(this);
        }
    }
    partial class Us05_User_Education_TypeDataTable
    {
      public void Load()
      {
        Us05_User_Education_TypeTableAdapter ta = new Us05_User_Education_TypeTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        Us05_User_Education_TypeTableAdapter ta = new Us05_User_Education_TypeTableAdapter();
        ta.Update(this);
      }
    }
    partial class Sp03_Tree1_usersDataTable
    {
      public void Load()
      {
        Sp03_Tree1_usersTableAdapter ta = new Sp03_Tree1_usersTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        Sp03_Tree1_usersTableAdapter ta = new Sp03_Tree1_usersTableAdapter();
        ta.Update(this);
      }
    }
    partial class Sp05_Tree2_UsersDataTable
    {
      public void Load()
      {
        Sp05_Tree2_UsersTableAdapter ta = new Sp05_Tree2_UsersTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        Sp05_Tree2_UsersTableAdapter ta = new Sp05_Tree2_UsersTableAdapter();
        ta.Update(this);
      }
    }
    partial class Us05_Users_Abilities_LevelsDataTable
    {
      public void Load()
      {
        Us05_Users_Abilities_LevelsTableAdapter ta = new Us05_Users_Abilities_LevelsTableAdapter();
        ta.Fill(this);
      }

     
    } 
    public void Load()
    {
      IN01_Instruments.Load();
      US01_Users.Load();
      QS03_Tests.Load();
      QS04_Questions.Load();
      QS05_Answers.Load();
      QS02_Categories.Load();
      QS06_TestLevels.Load();
      US02_UserTests.Load();
      QS01_Types.Load();
      SP01_SpecialAbilities.Load(); //new entry 5/12/2012
      Us03_Users_Instruments.Load(); //new entry 23/12/2012
      Sp02_Tree_L1.Load();
      Sp04_Tree2_L2.Load();
      Set01_Settings.Load(); //gia kapoio logo den den douleysei swsta to login
      Us06_User_Music_Genres.Load();
      Pl03_Poll_MusicGenres.Load();
      Tr03_Theory_Visits.Load();
      Us05_User_Education_Type.Load();
      Sp03_Tree1_users.Load();
      Sp05_Tree2_Users.Load();
      Us05_Users_Abilities_Levels.Load();
      Set02_Sounds.Load();
      Us06_User_Music_Genres.Load();
      Pl03_Poll_MusicGenres.Load();

    }

    public void Save()
    {
      US01_Users.Save();
      US02_UserTests.Save();
      QS04_Questions.Save();
      QS05_Answers.Save();
      Sp02_Tree_L1.Save();
      Sp04_Tree2_L2.Save();
      Set01_Settings.Save();
      Us06_User_Music_Genres.Save();
      Pl03_Poll_MusicGenres.Save();
      Tr03_Theory_Visits.Save();
      Us05_User_Education_Type.Save();
      Us03_Users_Instruments.Save();
      Us06_User_Music_Genres.Save();
    }

    partial class US01_UsersDataTable
    {
      public void Load()
      {
        US01_UsersTableAdapter ta = new US01_UsersTableAdapter();
        ta.Fill(this);
      }

      public void Save()
      {
        US01_UsersTableAdapter ta = new US01_UsersTableAdapter();
        ta.Update(this);
        ta.Fill(this);
      }
    }

    private void InitializeComponent()
    {
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
  }
}
