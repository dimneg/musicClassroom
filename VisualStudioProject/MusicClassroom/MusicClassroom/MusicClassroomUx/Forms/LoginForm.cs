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
  internal partial class LoginForm
    : Form
  {
    /// <summary>
    /// The logged in user id
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public LoginForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Called when the user presses the OK button
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    private void OKButton_Click(object sender, EventArgs e)
    {
      // Check user credentials
      try
      {
        DataSet.US01_UsersRow User = Program.Tables.US01_Users.First(UserRow => 
        { return UserRow.US01_UserName == UserNameTextBox.Text && UserRow.US01_Password == PasswordTextBox.Text; });
        UserId = User.US01_Id;
        DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      catch
      {
        MessageBox.Show(this,
                        "Λάθος όνομα χρήστη ή κωδικός ή αδυναμία σύνδεσης με τη βάση δεδομένων",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
      }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }
  }
}
