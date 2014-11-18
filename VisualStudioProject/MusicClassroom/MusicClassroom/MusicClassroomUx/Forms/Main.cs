using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Papi.Negkas.MusicClassroom.Ux.Properties;
using System.IO;

namespace Papi.Negkas.MusicClassroom.Ux
{
  /// <summary>
  /// The main form of the application
  /// </summary>
  internal partial class Main
    : Form
  {
    #region Public Methods

    /// <summary>
    /// Constructor
    /// </summary>
    public Main(int LoggedUserId)
    {
      InitializeComponent();

      Tables = Program.Tables;
      AllUsersBindingSource.DataSource = Tables;
      AllTypesBindingSource.DataSource = Tables;
      InstrumentsBindingSource.DataSource = Tables;
      UserInstrumentsBindingSource.DataSource = Tables;
      SpecialAbilitiesBindingSource.DataSource = Tables; // new addition 15/12/2012 load specialabilities
      AllSettingsBindingSource.DataSource = Tables;
      MusicGenresBindingSource.DataSource = Tables;
      UsersMusicGenresBindingSource.DataSource = Tables;
      EducationTypebindingSource.DataSource = Tables;
      UserVisitsBindingSource.DataSource = Tables;
      UserVisitsBindingSource.Filter = "Tr03_Us01_Id = " + LoggedUserId.ToString();
      Sp03UserTree1LvlBindingSource.DataSource =Tables;
      Sp03UserTree1LvlBindingSource.Filter = "Sp03_Us01_id = " + LoggedUserId.ToString();
      Sp05UserTree2LvlBindingSource.DataSource = Tables;
      Sp05UserTree2LvlBindingSource.Filter = "Sp05_Us01_id = " + LoggedUserId.ToString();
      Us05_Users_Abilities_LevelsbindingSource.DataSource = Tables;
      Us05_Users_Abilities_LevelsbindingSource.Filter = "Us05_Us01_id = " + LoggedUserId.ToString();
      UIbindingSource.DataSource = Tables;
      //UIbindingSource.Filter = "Us03_US01_id = " + LoggedUserId.ToString();
      

      m_LoggedUserId = LoggedUserId;

      Text += " - " + LoggedUser.US01_Name + " " + LoggedUser.US01_Surname;

      // Load the instruments
      UserBindingSource.DataSource = Tables.US01_Users;
      UserBindingSource.Filter = "US01_Id = " + LoggedUserId.ToString();
      UserTestBindingSource.Filter = string.Format("US02_US01_Id = {0}", LoggedUserId.ToString());

      // Remove the administration tab if the user is not the administrator
      if (LoggedUser.US01_Id != -1)
      {
        TabControl.TabPages.Remove(AdminPage);
      }
      else
      {
        //AllUsersBindingSource.DataSource = Tables.US01_Users;
      }
    }

    #endregion Public Methods

    #region Private Properties

    private DataSet.US01_UsersRow LoggedUser
    {
      get { return Tables.US01_Users.FindByUS01_Id(m_LoggedUserId); }
    }

    #endregion Private Properties

    #region Private Methods

    private void Main_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'Tables.Us05_Users_Abilities_Levels' table. You can move, or remove it, as needed.
      this.us05_Users_Abilities_LevelsTableAdapter.Fill(this.Tables.Us05_Users_Abilities_Levels);
      // TODO: This line of code loads data into the 'Tables.Sp05_Tree2_Users' table. You can move, or remove it, as needed.
      this.sp05_Tree2_UsersTableAdapter.Fill(this.Tables.Sp05_Tree2_Users);
      // TODO: This line of code loads data into the 'Tables.Sp04_Tree2_L2' table. You can move, or remove it, as needed.
      this.sp04_Tree2_L2TableAdapter.Fill(this.Tables.Sp04_Tree2_L2);
      // TODO: This line of code loads data into the 'Tables.Sp03_Tree1_users' table. You can move, or remove it, as needed.
      this.sp03_Tree1_usersTableAdapter.Fill(this.Tables.Sp03_Tree1_users);
      // TODO: This line of code loads data into the 'Tables.Us05_User_Education_Type' table. You can move, or remove it, as needed.
      this.us05_User_Education_TypeTableAdapter.Fill(this.Tables.Us05_User_Education_Type);
      // TODO: This line of code loads data into the 'Tables.Tr04_Access_Object' table. You can move, or remove it, as needed.
      this.tr04_Access_ObjectTableAdapter.Fill(this.Tables.Tr04_Access_Object);
      // TODO: This line of code loads data into the 'Tables.Tr03_Theory_Visits' table. You can move, or remove it, as needed.
      this.tr03_Theory_VisitsTableAdapter.Fill(this.Tables.Tr03_Theory_Visits);
      // TODO: This line of code loads data into the 'Tables.Us06_User_Music_Genres' table. You can move, or remove it, as needed.
      this.us06_User_Music_GenresTableAdapter.Fill(this.Tables.Us06_User_Music_Genres);
      // TODO: This line of code loads data into the 'Tables.Pl03_Poll_MusicGenres' table. You can move, or remove it, as needed.
      this.pl03_Poll_MusicGenresTableAdapter.Fill(this.Tables.Pl03_Poll_MusicGenres);
      // TODO: This line of code loads data into the 'Tables.Set01_Settings' table. You can move, or remove it, as needed.
      this.set01_SettingsTableAdapter.Fill(this.Tables.Set01_Settings);
      // TODO: This line of code loads data into the 'Tables.Set01_Settings1' table. You can move, or remove it, as needed.
      this.set01_Settings1TableAdapter.Fill(this.Tables.Set01_Settings1);
      _loading = true;
      //this.Set01_SettingsTableAdapter.Fill(this.Tables.Set01_Settings);
      // _loading = true;

      // TODO: This line of code loads data into the 'Tables.Us03_Users_Instruments' table. You can move, or remove it, as needed.
      this.us03_Users_InstrumentsTableAdapter.Fill(this.Tables.Us03_Users_Instruments);
      // TODO: This line of code loads data into the 'Tables.US02_UserTests' table. You can move, or remove it, as needed.
      this.uS02_UserTestsTableAdapter.Fill(this.Tables.US02_UserTests);
      // TODO: This line of code loads data into the 'Tables.US01_Users' table. You can move, or remove it, as needed.
      this.uS01_UsersTableAdapter.Fill(this.Tables.US01_Users);
      // TODO: This line of code loads data into the 'Tables.IN01_Instruments' table. You can move, or remove it, as needed.
      this.iN01_InstrumentsTableAdapter.Fill(this.Tables.IN01_Instruments);
      // TODO: This line of code loads data into the 'Tables.SP01_SpecialAbilities' table. You can move, or remove it, as needed.
      this.sP01_SpecialAbilitiesTableAdapter.Fill(this.Tables.SP01_SpecialAbilities);
      //this.Pl03_Poll_MusicGenresTableAdapter.Fill(this.Tables.Pl03_Poll_MusicGenres);
      //GeneralTextBox.LoadFromResource(Resources.General);
      //ScalesTextBox.LoadFromResource(Resources.Scales);
      //ChordsTextBox.LoadFromResource(Resources.Chords);

      UserTestBindingSource.DataSource = Tables.US02_UserTests;

      LoadTargetWeights();
      LoadVisualTargetWeights();
      LoadAuralTargetWeights();

      _loading = false;
    }

    /// <summary>
    /// Loads the target weights into the target controls
    /// </summary>
    private void LoadTargetWeights()
    {
      // Fill the level 1 targets map of controls to ids
      _level1Targets[AccThrElementTarget] = 3; // 3 TheoryAcessObjects
      _level1Targets[ReadTheoryTarget] = 2;    // 2 TheoryRead
      _level1Targets[SterotypeTarget] = 1; // 1 Stereotype
      _level1Targets[AbilityTestTarget] = 4; // 4 Exercises

      // Fill the level 2 targets map of controls to ids
      _level2Targets[TimeAccessTarget] = 9; //9		Time Access
      _level2Targets[AccessCounterTarget] = 10; //10		AcCess Counter	
      _level2Targets[AccPerTheoryTarget] = 14; //14		AcessTimePerTheoryTime
      _level2Targets[TimeReadTarget] = 12; //12		TheoryRead Time
      _level2Targets[ReadPerVisitsTarget] = 13; //13		TheoryReadTimePerVisit
      _level2Targets[ReadCounterTarget] = 8; //8		TheoryRead Counter
      _level2Targets[GenderTarget] = 1; //1		Gender
      _level2Targets[EducationTypeTarget] = 2; //2		Education Type
      _level2Targets[TotalTrainingTarget] = 3; //3		Total Training
      _level2Targets[AgeTarget] = 4; //4		Age	
      _level2Targets[TotalMusicYearTarget] = 5; //5		Total Music Years
      _level2Targets[InstrumentsTarget] = 6; //6		Instruments
      _level2Targets[MusicGenresTarget] = 7; //7		Music Genres

      LoadTargetValues(_level1Targets, GetSp02Weight);
      LoadTargetValues(_level2Targets, GetSp04Weight);
    }

    /// <summary>
    /// Loads the target weights into the target controls
    /// </summary>
    private void LoadVisualTargetWeights(object sender, TabControlEventArgs e)
    {
      // Fill the level 1 targets map of controls to ids
      _userVisualTargetsL1[VisualAccThrElementTarget] = 3; // 3 TheoryAcessObjects
      _userVisualTargetsL1[VisualReadTheoryTarget] = 2;    // 2 TheoryRead
      _userVisualTargetsL1[VisualSterotypeTarget] = 1; // 1 Stereotype
      _userVisualTargetsL1[VisualAbilityTestTarget] = 4; // 4 Exercises

      // Fill the level 2 targets map of controls to ids
      _userVisualTargets[VisualTimeAccessTarget] = 9; //9		Time Access
      _userVisualTargets[VisualAccessCounterTarget] = 10; //10		AcCess Counter	
      _userVisualTargets[VisualAccPerTheoryTarget] = 14; //14		AcessTimePerTheoryTime
      _userVisualTargets[VisualTimeReadTarget] = 12; //12		TheoryRead Time
      _userVisualTargets[VisualReadPerVisitsTarget] = 13; //13		TheoryReadTimePerVisit
      _userVisualTargets[VisualReadCounterTarget] = 8; //8		TheoryRead Counter
      _userVisualTargets[VisualGenderTarget] = 1; //1		Gender
      _userVisualTargets[VisualEducationTypeTarget] = 2; //2		Education Type
      _userVisualTargets[VisualTotalTrainingTarget] = 3; //3		Total Training
      _userVisualTargets[VisualAgeTarget] = 4; //4		Age	
      _userVisualTargets[VisualTotalMusicYearTarget] = 5; //5		Total Music Years
      _userVisualTargets[VisualInstrumentsTarget] = 6; //6		Instruments
      _userVisualTargets[VisualMusicGenresTarget] = 7; //7		Music Genres

      
      LoadTargetValues(_userVisualTargets, GetSp05VisualScore);
      LoadTargetValues(_userVisualTargetsL1, GetSp03VisualScore);
      LoadUserAbilityScore(VisualAbilityTarget, 1);
    }


    private void LoadUserAbilityScore(Target control, int sp01Id)
    {
      var row = Tables.Us05_Users_Abilities_Levels.FirstOrDefault(r => r.Us05_Us01_id == m_LoggedUserId && r.Us05_Sp01_id == sp01Id);
      if (row == null || row.IsUs05_Level_WNull())
      {
        control.Weight = 0;
      }
      else
      {
        control.Weight = (float)row.Us05_Level_W;
      }
    }

    /// <summary>
    /// Loads the target weights into the target controls
    /// </summary>
    private void LoadAuralTargetWeights(object sender, TabControlEventArgs e)
    {
      // Fill the level 1 targets map of controls to ids
      _userAuralTargetsL1[AudioAccThrElementTarget] = 3; // 3 TheoryAcessObjects
      _userAuralTargetsL1[AudioReadTheoryTarget] = 2;    // 2 TheoryRead
      _userAuralTargetsL1[AudioSterotypeTarget] = 1; // 1 Stereotype
      _userAuralTargetsL1[AudioAbilityTestTarget] = 4; // 4 Exercises

      // Fill the level 2 targets map of controls to ids
      _userAuralTargets[AudioTimeAccessTarget] = 9; //9		Time Access
      _userAuralTargets[AudioAccessCounterTarget] = 10; //10		AcCess Counter	
      _userAuralTargets[AudioAccPerTheoryTarget] = 14; //14		AcessTimePerTheoryTime
      _userAuralTargets[AudioTimeReadTarget] = 12; //12		TheoryRead Time
      _userAuralTargets[AudioReadPerVisitsTarget] = 13; //13		TheoryReadTimePerVisit
      _userAuralTargets[AudioReadCounterTarget] = 8; //8		TheoryRead Counter
      _userAuralTargets[AudioGenderTarget] = 1; //1		Gender
      _userAuralTargets[AudioEducationTypeTarget] = 2; //2		Education Type
      _userAuralTargets[AudioTotalTrainingTarget] = 3; //3		Total Training
      _userAuralTargets[AudioAgeTarget] = 4; //4		Age	
      _userAuralTargets[AudioTotalMusicYearTarget] = 5; //5		Total Music Years
      _userAuralTargets[AudioInstrumentsTarget] = 6; //6		Instruments
      _userAuralTargets[AudioMusicGenresTarget] = 7; //7		Music Genres

      LoadTargetValues(_userAuralTargets, GetSp05AuralScore);
      LoadTargetValues(_userAuralTargetsL1, GetSp03AuralScore);
      LoadUserAbilityScore(AuralAbilityTarget, 2);
    }
    private float GetSp03VisualScore(int sp02Id)
    {
      var row = Tables.Sp03_Tree1_users.FirstOrDefault(r => r.Sp03_Tree1 == sp02Id && r.Sp03_Sp01_id == 1 && r.Sp03_Us01_id == m_LoggedUserId);
      if (row != null && !row.IsSp03_lvl_WNull())
      {
        return (float)row.Sp03_lvl_W;
      }
      return 0;
    }
    private float GetSp03AuralScore(int sp02Id)
    {
      var row = Tables.Sp03_Tree1_users.FirstOrDefault(r => r.Sp03_Tree1 == sp02Id && r.Sp03_Sp01_id == 2 && r.Sp03_Us01_id == m_LoggedUserId);
      if (row != null && !row.IsSp03_lvl_WNull())
      {
        return (float)row.Sp03_lvl_W;
      }
      return 0;
    }
    private float GetSp05VisualScore(int sp04Id)
    {
      var row = Tables.Sp05_Tree2_Users.FirstOrDefault(r => r.Sp05_Sp04_id == sp04Id && r.Sp05_Sp01_id == 1 && r.Sp05_Us01_id == m_LoggedUserId);
      if (row != null && !row.IsSp05_LvlNull())
      {
        return (float)row.Sp05_Lvl;
      }
      return 0;
    }
   
    private float GetSp05AuralScore(int sp04Id)
    {
      var row = Tables.Sp05_Tree2_Users.FirstOrDefault(r => r.Sp05_Sp04_id == sp04Id && r.Sp05_Sp01_id == 2 && r.Sp05_Us01_id == m_LoggedUserId);
      if (row != null && !row.IsSp05_LvlNull())
      {
        return (float)row.Sp05_Lvl;
      }
      return 0;
    }


    private float GetSp04Weight(int sp04Id)
    {
      var row = Tables.Sp04_Tree2_L2.FindBySp04_id(sp04Id);
      return (float)row.Sp04_Weight;
    }

    private float GetSp02Weight(int sp02Id)
    {
      var row = Tables.Sp02_Tree_L1.FindBySp02_id(sp02Id);
      return (float)row.Sp02_Weight;
    }

    private void LoadTargetValues(Dictionary<Target, int> targets, Func<int, float> getWeight)
    {
      foreach (var item in targets)
      {
        item.Key.Weight = getWeight(item.Value);
      }
    }


    /// <summary>
    /// Called when the theoretical button is pressed
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void TheoriticalButton_Click(object sender, EventArgs e)
    {
      ExercisesMenu.Show(TheoriticalButton, 0, TheoriticalButton.Height);
    }

    private void ExercisesMenu_Opening(object sender, CancelEventArgs e)
    {
      // Get the level of the current user
      QuestionLevel QuestionsLevel;
      double UserLevel = LoggedUser.US01_CurrentLvl;
      //UserLevel = 1;
      if (UserLevel <= 5)
      {
        QuestionsLevel = QuestionLevel.Novice;
      }
      else if (UserLevel <= 7.5)
      {
        QuestionsLevel = QuestionLevel.Intermediate;
      }
      else
      {
        QuestionsLevel = QuestionLevel.Advanced;
      }

      ExercisesMenu.Items.Clear();
      foreach (DataSet.QS02_CategoriesRow Row in Tables.QS02_Categories.Rows)
      {
        ToolStripMenuItem Item = (ToolStripMenuItem)ExercisesMenu.Items.Add(Row.QS02_Description);
        Item.Tag = Row;

        // Load the questions of this item
        LoadQuestions(Item, QuestionsLevel);
      }
    }

    private void LoadQuestions(ToolStripMenuItem Item, QuestionLevel QuestionsLevel)
    {
      Item.DropDownItems.Clear();
      DataSet.QS02_CategoriesRow Category = (DataSet.QS02_CategoriesRow)Item.Tag;
      foreach (DataSet.QS03_TestsRow Test in Category.GetQS03_TestsRows())
      {
        ToolStripMenuItem TestItem = (ToolStripMenuItem)Item.DropDownItems.Add(string.Format("Test {0}", Test.QS03_Id));
        TestItem.Tag = Test;
        TestItem.Enabled = Test.QS06_TestLevelsRow.QS06_Level == (int)QuestionsLevel;
        TestItem.Click += new EventHandler(TestItem_Click);
      }
    }

    /// <summary>
    /// Called when a test item is clicked
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void TestItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem TestMenu = (ToolStripMenuItem)sender;
      DataSet.QS03_TestsRow CurrentTest = (DataSet.QS03_TestsRow)TestMenu.Tag;
      using (Test TestForm = new Test(CurrentTest, LoggedUser))
      {
        TestForm.ShowDialog(this);
      }

      // Reset the binding to the logged user since it might have been reloaded from the database
      UserBindingSource.DataSource = LoggedUser;

      // Show the statistics tab page
      TabControl.SelectedTab = StatisticsTabPage;
    }

    /// <summary>
    /// Called to supply values to the unbound cells
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void StatisticsDataList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      DataSet.US02_UserTestsRow BoundRow = StatisticsDataList.Rows[e.RowIndex].GetBoundItem<DataSet.US02_UserTestsRow>();
      if (BoundRow != null)
      {
        if (e.ColumnIndex == CategoryColumn.Index)
        {
          DataSet.QS03_TestsRow Test = Tables.QS03_Tests.FindByQS03_Id(BoundRow.US02_QS03_Id);
          e.Value = Test.QS02_CategoriesRow.QS02_Description;
        }
        else if (e.ColumnIndex == TypeColumn.Index)
        {
          DataSet.QS03_TestsRow Test = Tables.QS03_Tests.FindByQS03_Id(BoundRow.US02_QS03_Id);
          e.Value = Test.QS02_CategoriesRow.QS01_TypesRow.QS01_Description;
        }
        else if (e.ColumnIndex == TestLevelColumn.Index)
        {
          DataSet.QS03_TestsRow Test = Tables.QS03_Tests.FindByQS03_Id(BoundRow.US02_QS03_Id);
          e.Value = Test.QS06_TestLevelsRow.QS06_Level.ToString();
        }
        else if (e.ColumnIndex == AbilityColumn.Index)
        {
          DataSet.QS03_TestsRow Test = Tables.QS03_Tests.FindByQS03_Id(BoundRow.US02_QS03_Id);
          if (Test.SP01_SpecialAbilitiesRow == null)
          {
            e.Value = string.Empty;
          }
          else
          {
            e.Value = Test.SP01_SpecialAbilitiesRow.SP01_Name ?? string.Empty;
          }
        } 
        else if (e.ColumnIndex == OrdinalColumn.Index)
        {
          e.Value = e.RowIndex + 1;
        }
      }
    }
   /* private void UserDataGroup_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
  
    }
    */
    private void NewUserButton_Click(object sender, EventArgs e)
    {
      using (CreateUser NewUser = new CreateUser())
      {
        NewUser.ShowDialog(this);
      }
    }

    private void EditUserButton_Click(object sender, EventArgs e)
    {
      DataSet.US01_UsersRow User = UsersDataList.GetSelectedItem<DataSet.US01_UsersRow>();
      using (CreateUser NewUser = new CreateUser(User))
      {
        NewUser.ShowDialog(this);
      }
    }

    private void DeleteQuestionButton_Click(object sender, EventArgs e)
    {
      DataSet.QS04_QuestionsRow Question = QuestionsDataList.GetSelectedItem<DataSet.QS04_QuestionsRow>();
      if (Question != null)
      {
        if (MessageBox.Show(this,
                            Resources.S_QDeleteQuestion,
                            this.Text,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
        {
          // First remove the answers
          foreach (var Answer in Question.GetQS05_AnswersRows())
          {
            Tables.QS05_Answers.RemoveQS05_AnswersRow(Answer);
          }

          // Then remove the question
          Tables.QS04_Questions.RemoveQS04_QuestionsRow(Question);
          Tables.Save();
        }
      }
    }

    #endregion Private Methods

    #region Private Fields

    /// <summary>
    /// The id of the logged user
    /// </summary>
    private int m_LoggedUserId;

    /// <summary>
    /// Flag indicating that the form is loading
    /// </summary>
    private bool _loading;

    #endregion Private Fields

    private void DeleteAnswerButton_Click(object sender, EventArgs e)
    {

    }

    private void EditQuestionButton_Click(object sender, EventArgs e)
    {
      DataSet.QS04_QuestionsRow Question =
        QuestionsDataList.GetSelectedItem<DataSet.QS04_QuestionsRow>();

      if (Question != null)
      {
        using (EditQuestion EditForm = new EditQuestion(Question))
        {
          if (EditForm.ShowDialog(this) == DialogResult.OK)
          {
            Tables.Save();
          }
        }
      }
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void QuestionsGroupBox_Enter(object sender, EventArgs e)
    {

    }

    private void TypesCombo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void AdminUsersPage_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void NewAbilityBtn_Click(object sender, EventArgs e)
    {
      using (AddAbility NewAbility = new AddAbility())
      {
        NewAbility.ShowDialog(this);
      }
    }

    private void EditAbilityBtn_Click(object sender, EventArgs e)
    {
      /* DataSet.US01_UsersRow User = UsersDataList.GetSelectedItem<DataSet.US01_UsersRow>();
       using (CreateUser NewUser = new CreateUser(User))
       {
           NewUser.ShowDialog(this);
       } */
      DataSet.SP01_SpecialAbilitiesRow
      Ability = SpecialAbilitiesGridView.GetSelectedItem<DataSet.SP01_SpecialAbilitiesRow>();
      using (AddAbility NewAbility = new AddAbility(Ability))
      {
        NewAbility.ShowDialog(this);
      }
    }

    private void DeleteAbilityBtn_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Δεν επιτρέπεται η Διαγραφή!");
    }

    private void ScalesTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void ChordsTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.do_);
    }

    private void ShowTheoryImage(Bitmap bitmap)
    {
      using (ViewImage viewer = new ViewImage(bitmap))
      {
        viewer.ShowDialog(this);
        
        const int imagesId = 1;
        SaveSpecialAbility(imagesId, viewer.StartTime, viewer.EndTime);
      }
    }

    private void SaveSpecialAbility(int abilityId, DateTime startTime, DateTime endTime)
    {
      var lastRow = Tables.Tr04_Access_Object.LastOrDefault();
      var id = 0;
      if (lastRow != null)
      {
        id = lastRow.Tr04_Id;
      }
      id++;

      var abilityRow = Tables.SP01_SpecialAbilities.First(r => r.SP01_Id == abilityId);

      Tables.Tr04_Access_Object.AddTr04_Access_ObjectRow(
        id,
        _workingTheoryRow,
        abilityRow,
        startTime,
        endTime);

      Tables.Tr04_Access_Object.Save();
    }

    private void UsersToInstruments_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (UsersToInstrumentsBindingSource.Count > 0)
      {
        StringBuilder filterBuilder = new StringBuilder();
        foreach (DataRowView row in UsersToInstrumentsBindingSource.List)
        {
          DataSet.Us03_Users_InstrumentsRow instrumentDetail = (DataSet.Us03_Users_InstrumentsRow)row.Row;
          if (filterBuilder.Length > 0)
          {
            filterBuilder.Append(" OR ");
          }
          filterBuilder.AppendFormat("IN01_Id = {0}", instrumentDetail.US03_IN01_id);
        }
        UserInstrumentsBindingSource.Filter = filterBuilder.ToString();
      }
      else
      {
        UserInstrumentsBindingSource.Filter = "1 = 0";
      }
    }
    private void UsersToMusicGenres_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (UsersToMusicGenresBindingSource.Count > 0)
      {
        StringBuilder filterBuilder = new StringBuilder();
        foreach (DataRowView row in UsersToMusicGenresBindingSource.List)
        {
          DataSet.Us06_User_Music_GenresRow MusicGenreDetail = (DataSet.Us06_User_Music_GenresRow)row.Row;
          if (filterBuilder.Length > 0)
          {
            filterBuilder.Append(" OR ");
          }
          filterBuilder.AppendFormat("Pl03_id = {0}", MusicGenreDetail.Us06_Pl03_id);
        }
        UsersMusicGenresBindingSource.Filter = filterBuilder.ToString();
      }
      else
      {
        UsersMusicGenresBindingSource.Filter = "1 = 0";
      }
    }


    private void UsersDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void GeneralTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBoxDo_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.DoBig);
    }

    private void pictureBoxRe_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.ReBig);
    }

    private void pictureBoxMi_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.MiBig);
    }

    private void pictureBoxFa_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.FaBig);
    }

    private void pictureBoxLa_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.LaBig);
    }

    private void pictureBoxSi_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.SiBig);
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void pictureBoxRe_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.ReBig);
    }

    private void pictureBoxMi_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.MiBig);
    }

    private void pictureBoxFa_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.FaBig);
    }




    private void pictureBoxLa_Click_2(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.LaBig);
    }

    private void pictureBoxSi_Click_2(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.SiBig);
    }

    private void richTextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage2_Click_1(object sender, EventArgs e)
    {

    }

    private void richTextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void ThrSclBtn1_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.DoMajorScaleAll);
    }

    private void ThrChrImageBtnDoMaj_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordDoMajorBig);
    }

    private void ThrChrImageBtnLaMin_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordLaMinorBig);
    }

    private void ThrChrImageBtnFaAgm_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordfaAugBig);
    }

    private void ThrChrImageBtnSiDim_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordsiMinorDimBig);
    }

    private void ThrChrSoundBtnDoMaj_Click(object sender, EventArgs e)
    {
      //Sound.Play
    }

    private void pictureBox2_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.SolBig);
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void richTextBoxThGen_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.EighthBig);
    }

    private void pictureBox8_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.DoBig);
    }

    private void pictureBox7_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.ReBig);
    }

    private void pictureBox6_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.MiBig);
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.FaBig);
    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.SolBig);
    }

    private void pictureBox4_Click_1(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.LaBig);
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.SiBig);
    }

    private void pictureBoxWhole_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.WholeBig);
    }

    private void pictureBoxHalf_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.HalfBig);
    }

    private void pictureBoxQuarter_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.QuarterBig);
    }

    private void pictureBox16th_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.S16thBig);
    }

    private void pictureBoxSolKey_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.KeySolBig);
    }

    private void pictureBoxKeyFa_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.KeyFaBig);
    }

    private void pictureBox2_Click_2(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.KeyAltoBig);
    }

    private void pictureBox9_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.PauseBig);
    }

    private void pictureBox10_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.PauseHalfBig);
    }

    private void pictureBox11_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.Pause4thBig);
    }

    private void pictureBox12_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.Pause8thBig);
    }

    private void pictureBox13_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.DoMajorScaleAll);
    }

    private void pictureBox14_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox59_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox15_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.DoMajorScaleAll);
    }

    private void ThCh1_Click(object sender, EventArgs e)
    {

    }

    private void richTextBox76_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox77_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox78_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox75_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox80_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox79_TextChanged(object sender, EventArgs e)
    {

    }

    private void richTextBox82_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox17_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordDoMajorBig);
    }

    private void richTextBox83_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox18_Click(object sender, EventArgs e)
    {
      PlaySound(3);
    }

    private void richTextBox81_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox16_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.LaMinorScaleAll);
    }

    private void pictureBox22_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordfaAugBig);
    }

    private void pictureBox24_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordsiMinorDimBig);
    }

    private void pictureBox20_Click(object sender, EventArgs e)
    {
      ShowTheoryImage(Resources.chordLaMinorBig);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      ExercisesMenu.Show(TheoriticalButton, 0, TheoriticalButton.Height);
    }

    /// <summary>
    /// Called whenever a weight changes to update the values on the database
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void Target_WeightChanged(object sender, EventArgs e)
    {
      if (!_loading)
      {
        // Update the value on the table
        Target target = (Target)sender;

        // Check if the target group weights exceed 1
        var groupName = target.GroupName;
        if (!string.IsNullOrWhiteSpace(groupName) && target.Parent != null)
        {
          float sum = 0;
          foreach (Target control in target.Parent.Controls)
          {
            if (control.GroupName == groupName)
            {
              sum += control.Weight;
            }
          }

          if ((sum > 1.05) || (sum < 0.95))
          {
            MessageBox.Show(string.Format("Το άθροισμα δεν είναι σωστό ({0})", sum));
            return;
          }
        }

        if (_level1Targets.ContainsKey(target))
        {
          var id = _level1Targets[target];
          var row = Tables.Sp02_Tree_L1.FindBySp02_id(id);
          row.Sp02_Weight = (decimal)target.Weight;
          Tables.Sp02_Tree_L1.Save(); //modification
        }

        else if (_level2Targets.ContainsKey(target))
        {
          var id = _level2Targets[target];
          var row = Tables.Sp04_Tree2_L2.FindBySp04_id(id);
          row.Sp04_Weight = (decimal)target.Weight;
          Tables.Sp04_Tree2_L2.Save(); //modification
        }

        // Save the weights
        // Tables.Save(); //modification
      }
    }

    // Weights
    private Dictionary<Target, int> _level1Targets = new Dictionary<Target, int>();
    private Dictionary<Target, int> _level2Targets = new Dictionary<Target, int>();

    // User visual targets controls
    private Dictionary<Target, int> _userVisualTargets = new Dictionary<Target, int>();
    private Dictionary<Target, int> _userVisualTargetsL1 = new Dictionary<Target, int>(); //level1

    // User audio targets controls
    private Dictionary<Target, int> _userAuralTargets = new Dictionary<Target, int>();
    private Dictionary<Target, int> _userAuralTargetsL1 = new Dictionary<Target, int>(); //level1

    /// <summary>
    /// The tab of the theory page which is currently open
    /// </summary>
    private DataSet.Tr03_Theory_VisitsRow _workingTheoryRow;

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void target25_Load(object sender, EventArgs e)
    {

    }

    private void target24_Load(object sender, EventArgs e)
    {

    }

    private void target23_Load(object sender, EventArgs e)
    {

    }

    private void target33_Load(object sender, EventArgs e)
    {

    }

    private void target34_Load(object sender, EventArgs e)
    {

    }

    private void target35_Load(object sender, EventArgs e)
    {

    }

    private void target36_Load(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void MusicGenresLabel_Click(object sender, EventArgs e)
    {

    }

    private void TheoryStatsTab_Click(object sender, EventArgs e)
    {

    }
    
    /// <summary>
    /// Initializes the first theory row
    /// </summary>
    private void InitTheoryRow()
    {
      // TODO: Run when TAB changes to Theory
      if (_workingTheoryRow == null)
      {
        var currentCategory = GetCurrentCategory();
        _workingTheoryRow = CreateWorkingTheoryRow(currentCategory);
      }
    }

    private int GetCurrentCategory()
    {
      var tabControl = (TabControl)richTextBoxThScl;

      switch (tabControl.SelectedIndex)
      {
        case 0:
        case 1:
          return 3;

        case 2:
        case 3:
          return 1;

        case 4:
        case 5:
          return 2;

        default:
          return -1;
      }
    }

    /// <summary>
    /// Called when the selected tab pages change
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void richTextBoxThScl_SelectedIndexChanged(object sender, EventArgs e)
    {
      int currentCategory = GetCurrentCategory();

      // If there is a change in the working category
      if (currentCategory >= 0
          &&
          currentCategory != _workingTheoryRow.Tr03_Qs02_id)
      {
        // Update finish time on previous working category
        _workingTheoryRow.Tr03_Finish_Time = DateTime.Now;

        // Create a new row for the new category
        _workingTheoryRow = CreateWorkingTheoryRow(currentCategory);
      }
    }

    /// <summary>
    /// Creates a new working theory row
    /// </summary>
    /// <param name="currentCategory">
    /// The theory category to initialize the row with
    /// </param>
    /// <returns>
    /// The newly created theory row
    /// </returns>
    private DataSet.Tr03_Theory_VisitsRow CreateWorkingTheoryRow(int currentCategory)
    {
      var loggedUserRow = Tables.US01_Users.FindByUS01_Id(m_LoggedUserId);
      var categoryRow = Tables.QS02_Categories.FindByQS02_Id(currentCategory);

      var lastRow = Tables.Tr03_Theory_Visits.LastOrDefault();
      var primaryKey = 0;
      if (lastRow != null)
      {
        primaryKey = lastRow.Tr03_Id;
      }
      primaryKey++;

      var date = DateTime.Now;

      var row = Tables.Tr03_Theory_Visits.AddTr03_Theory_VisitsRow(
        primaryKey,
        loggedUserRow,
        categoryRow,
        date,
        date);

      Tables.Tr03_Theory_Visits.Save();

      return row;
    }

    /// <summary>
    /// Closes and saves the working theory row (if any)
    /// </summary>
    private void CloseWorkingTheoryRow()
    {
      if (_workingTheoryRow != null)
      {
        _workingTheoryRow.Tr03_Finish_Time = DateTime.Now;
        Tables.Tr03_Theory_Visits.Save();

        _workingTheoryRow = null;
      }
    }

    /// <summary>
    /// Called when the main tab control changes its selected tab
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
      // If theory is selected
      if (TabControl.SelectedTab == TheoryTabPage)
      {
        // Initialize the theory row for the first time
        InitTheoryRow();
      }
      else
      {
        CloseWorkingTheoryRow();
      }
    }

    /// <summary>
    /// Called after the form has been closed
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
      CloseWorkingTheoryRow();
    }

    /// <summary>
    /// Called to provide a custom cell value
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == tr04Tr01IdDataGridViewTextBoxColumn.Index)
      {
        if (e.Value is int)
        {
          int ability = (int)e.Value;
          var row = Tables.SP01_SpecialAbilities.FirstOrDefault(r => r.SP01_Id == ability);
          if (row == null)
          {
            e.Value = "Άγνωστο";
          }
          else
          {
            e.Value = row.SP01_Name;
          }
        }
      }
    }
    private void TheoryStatsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == tr03Qs02idDataGridViewTextBoxColumn.Index)
      {
        if (e.Value is int)
        {
          int category = (int)e.Value;
          var row = Tables.QS02_Categories.FirstOrDefault(r => r.QS02_Id == category);
          if (row == null)
          {
            e.Value = "Άγνωστο";
          }
          else
          {
            e.Value = row.QS02_Description;
          }
        }
      }
    }
    private void UsersDataList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == Us01_EducationType_Us05_id.Index)
      {
        if (e.Value is int)
        {
          int edutype = (int)e.Value;
          var row = Tables.Us05_User_Education_Type.FirstOrDefault(r => r.Us05_id == edutype);
          if (row == null)
          {
            e.Value = "Άγνωστο";
          }
          else
          {
            e.Value = row.Us05_Education_type;
          }
        }
      }
    }
    private void EduTypegridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == us01EducationTypeUs05idDataGridViewTextBoxColumn.Index)
      {
        if (e.Value is int)
        {
          int edutype = (int)e.Value;
          var row = Tables.Us05_User_Education_Type.FirstOrDefault(r => r.Us05_id == edutype);
          if (row == null)
          {
            e.Value = "Άγνωστο";
          }
          else
          {
            e.Value = row.Us05_Education_type;
          }
        }
      }
    }

    /// <summary>
    /// Called when a cell is done editing
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void SettingsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      // If a new value is set
      if (e.ColumnIndex == administrationValueColumn.Index)
      {
        // Save the table back to the database
        Tables.Set01_Settings.Save();
      }
    }

    private void pictureBox14_Click_1(object sender, EventArgs e)
    {
      PlaySound(1);
    }

    private void PlaySound(int id)
    {
      var row = Tables.Set02_Sounds.FindBySet02_id(id);
      if (row != null && !row.IsSet02_SoundNull())
      {
        Sound.Play(row.Set02_Sound);
      }

      const int soundsId = 2;
      var time = DateTime.Now;
      SaveSpecialAbility(soundsId, time, time.AddSeconds(5));
    }

    private void pictureBox13_Click_1(object sender, EventArgs e)
    {
      PlaySound(2);
    }

    private void pictureBox21_Click(object sender, EventArgs e)
    {
      PlaySound(5);
    }

    private void pictureBox19_Click(object sender, EventArgs e)
    {
      PlaySound(4);
    }

    private void pictureBox23_Click(object sender, EventArgs e)
    {
      PlaySound(6);
    }

    private void ExperienceSlider_Scroll(object sender, EventArgs e)
    {
      //UserExptextBox.Text = ExperienceSlider.Value.ToString();
    }

    private void LoadVisualTargetWeights()
    {

    }

    private void LoadAuralTargetWeights()
    {

    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }
  }

}
