using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Papi.Negkas.MusicClassroom.Ux
{
  /// <summary>
  /// A class to manage new user creation
  /// </summary>
  public partial class CreateUser : Form
  {
    #region Public Methods

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateUser()
    {
      InitializeComponent();

      TotalTrainingComboBox.SelectedIndex = 0;

      DataSet.US01_UsersRow UserRow = Program.Tables.US01_Users.NewUS01_UsersRow();
      UserRow.US01_Id = 0;
      UserRow.US01_UserName = string.Empty;
      UserRow.US01_Password = string.Empty;
      UserRow.US01_Surname = string.Empty;
      UserRow.US01_Name = string.Empty;
      UserRow.US01_Surname = string.Empty;
      UserRow.US01_Age = 0;
      UserRow.US01_TheoryExperience = 0;
      UserRow.US01_Gender = false;
      UserRow.US01_CurrentLvl = 0;
      //new
      UserRow.Us01_EducationType_Us05_id = 1; //attention, foreign key test evala timh

      UserRow.Us01_TotalMusicYears = 0;
      UserRow.Us01_TotalTraining = String.Empty;
      

      // Show available instruments
      InitInstruments();
      InitMusicGenres();

      Init(UserRow);
    }

    private void InitInstruments()
    {
      foreach (DataSet.IN01_InstrumentsRow row in Program.Tables.IN01_Instruments.Rows)
      {
        _instruments.Add(new SelectableInstrument(row));
      }
      SelectableInstrumentsBindingSource.DataSource = _instruments;
    }
    private void InitMusicGenres()
    {
      foreach (DataSet.Pl03_Poll_MusicGenresRow row in Program.Tables.Pl03_Poll_MusicGenres.Rows)
      {
        _MusicGenres.Add(new SelectableMusicGenre(row));
      }
      SelectableMusicGenresBindingSource.DataSource = _MusicGenres;
    }

    /// <summary>
    /// Sets the user row as the binding source
    /// </summary>
    /// <param name="UserRow">
    /// The user row to set as source for the data
    /// </param>
    private void Init(DataSet.US01_UsersRow UserRow)
    {
      UserBindingSource.DataSource = UserRow;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="UserRow">
    /// The user row to edit
    /// </param>
    public CreateUser(DataSet.US01_UsersRow UserRow)
      : this()
    {
      Init(UserRow);

      // Disable the user name field
      UserNameTextBox.Enabled = false;
    
    }

    #endregion Public Methods

    #region Private Methods

    /// <summary>
    /// Called when the OK button is pressed
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void OkBtn_Click(object sender, EventArgs e)
    {
      try
      {
        DataSet.US01_UsersRow Row = (DataSet.US01_UsersRow)UserBindingSource.DataSource;
        bool IsNewUser = Row.RowState == DataRowState.Detached && Row.US01_Id == 0;

        if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
        {
          throw new ApplicationException("Το Όνομα Χρήστη δεν μπορεί να είναι κενό");
        }

        if (IsNewUser && Program.Tables.US01_Users.FirstOrDefault(UserRow => { return UserRow.US01_UserName == UserNameTextBox.Text; }) != null)
        {
          throw new ApplicationException(string.Format("Το Όνομα Χρήστη {0} υπάρχει ήδη", UserNameTextBox.Text));
        }

        if (string.IsNullOrEmpty(PasswordTextBox.Text))
        {
          throw new ApplicationException("Ο Κωδικός Πρόσβασης δεν μπορεί να είναι κενός");
        }
        if (string.IsNullOrEmpty(NameTextBox.Text))
        {
          throw new ApplicationException("Το όνομα δεν μπορεί να είναι κενό");
        }
        if (string.IsNullOrEmpty(AgeTextBox.Text))
        {
          throw new ApplicationException("Η ηλικία δεν μπορεί να είναι κενή");
        }
        if (string.IsNullOrEmpty(SurnameTextBox.Text))
        {
          throw new ApplicationException("Το επίθετο δεν μπορεί να είναι κενό");
        }

        if (PasswordTextBox.Text != VerifyPasswordTextBox.Text)
        {
          throw new ApplicationException("Οι Κωδικός Πρόσβασης δεν ταιριάζουν");
        }
        string selectedTotalTraining = TotalTrainingComboBox.SelectedItem.ToString();
       int selectedEdutype = Convert.ToInt32(EducationTypeComboBox.SelectedValue);
         

        if (IsNewUser)
        {
          DataSet.US01_UsersRow LastUser = Program.Tables.US01_Users.LastOrDefault();
          if (LastUser != null)
          {
            Row.US01_Id = LastUser.US01_Id;
           
          }
          Row.US01_Id++;
        

          Row.Us01_TotalTraining = selectedTotalTraining;
          Row.Us01_EducationType_Us05_id = selectedEdutype;
          Program.Tables.US01_Users.AddUS01_UsersRow(Row);

          var lastRow = Program.Tables.Us03_Users_Instruments.LastOrDefault();
          var id = 0;
          if (lastRow != null)
          {
            id = lastRow.US03_id;
          }
          

          foreach(var selectedInstrument in _instruments)
          {
            if (selectedInstrument.IsSelected)
            {
              id++;
              Program.Tables.Us03_Users_Instruments.AddUs03_Users_InstrumentsRow(
                id,
                selectedInstrument.Row,
                Row);
            } 
          }


          var lastRowMG = Program.Tables.Us06_User_Music_Genres.LastOrDefault();
          var idMG = 0;
          if (lastRowMG != null)
          {
            idMG = lastRowMG.Us06_id;
          }
          else idMG = Program.Tables.Us06_User_Music_Genres.Count() + 1; //just a try



          foreach (var selectedMusicGenre in _MusicGenres)
          {
            if (selectedMusicGenre.IsSelected)
            {
              idMG++;
              Program.Tables.Us06_User_Music_Genres.AddUs06_User_Music_GenresRow(
                idMG,
                Row,
                selectedMusicGenre.Row
                );
            }
          }
        }
        

        Program.Tables.Save();

        DialogResult = DialogResult.OK;
      }
      catch (Exception Error)
      {
        MessageBox.Show(this, Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion Private Methods

    private void CancelBtn_Click(object sender, EventArgs e)
    {

    }

    private void CreateUser_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dataSet.Us05_User_Education_Type' table. You can move, or remove it, as needed.
      this.us05_User_Education_TypeTableAdapter.Fill(this.dataSet.Us05_User_Education_Type);
      // TODO: This line of code loads data into the 'dataSet.IN01_Instruments' table. You can move, or remove it, as needed.
      this.iN01_InstrumentsTableAdapter.Fill(this.dataSet.IN01_Instruments);

    }

    private void GenderLabel_Click(object sender, EventArgs e)
    {

    }

    private void UserBindingSource_CurrentChanged(object sender, EventArgs e)
    {

    }

    private void ExperienceSlider_Scroll(object sender, EventArgs e)
    {
      adminUserExptextbox.Text = ExperienceSlider.Value.ToString();
    }

    private void UserNameLabel_Click(object sender, EventArgs e)
    {

    }

    private void ExperienceLabel_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private BindingList<SelectableInstrument> _instruments = new BindingList<SelectableInstrument>();
    private BindingList<SelectableMusicGenre> _MusicGenres = new BindingList<SelectableMusicGenre>();

    private void InvolvementSlider_Scroll(object sender, EventArgs e)
    {
      adminUserInvtextbox.Text = InvolvementSlider.Value.ToString();
    }
  }

  public abstract class SelectableObject
    : INotifyPropertyChanged
  {
    public abstract string Name
    {
      get;
    }

    /// <summary>
    /// Flag indicating whether the object is selected
    /// </summary>
    public bool IsSelected
    {
      get { return _isSelected; }
      set
      {
        if (_isSelected != value)
        {
          _isSelected = value;
          RaisePropertyChanged("IsSelected");
        }
      }
    }

    private void RaisePropertyChanged(string propertyName)
    {
      var handler = PropertyChanged;
      if (handler != null)
      {
        handler(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private bool _isSelected;
  }

  public class SelectableInstrument
    : SelectableObject
  {
    public override string Name
    {
      get { return Row.IN01_Name; }
    }

    public SelectableInstrument(DataSet.IN01_InstrumentsRow row)
    {
      Row = row;
    }

    public DataSet.IN01_InstrumentsRow Row { get; private set; }
  }
  public class SelectableMusicGenre
    : SelectableObject
  {
    public override string Name
    {
      get { return Row.Pl03_genre; }
    }

    public SelectableMusicGenre(DataSet.Pl03_Poll_MusicGenresRow row)
    {
      Row = row;
    }

    public DataSet.Pl03_Poll_MusicGenresRow Row { get; private set; }
  }
}
