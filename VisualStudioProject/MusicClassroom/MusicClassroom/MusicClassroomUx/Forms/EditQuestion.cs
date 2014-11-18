using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Papi.Negkas.MusicClassroom.Ux
{
  public partial class EditQuestion : Form
  {
    public EditQuestion(DataSet.QS04_QuestionsRow Question)
    {
      InitializeComponent();
      m_Question = Question;
      QuestionBindingSource.DataSource = m_Question;

      PlaySoundButton.Enabled = m_Question.QS04_Sound != null;
    }

    private void EditQuestion_Load(object sender, EventArgs e)
    {
      m_Question.BeginEdit();
    }

    private void SetImageButton_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog ofn = new OpenFileDialog())
      {
        ofn.Filter = "All Image Files|*.jpg;*.png|Jpg files|*.jpg|Png files|*.png|All files|*.*";
        if (ofn.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          byte[] FileBytes = File.ReadAllBytes(ofn.FileName);
          m_Question.QS04_Image = FileBytes;
          QuestionBindingSource.ResetBindings(false);
        }
      }
    }

    private void EditQuestion_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (DialogResult != System.Windows.Forms.DialogResult.OK)
      {
        m_Question.CancelEdit();
      }
      else
      {
        m_Question.EndEdit();
      }
    }

    private void ClearImageButton_Click(object sender, EventArgs e)
    {
      m_Question.QS04_Image = null;
      QuestionBindingSource.ResetBindings(false);
    }

    private void SetAudioButton_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog ofn = new OpenFileDialog())
      {
        ofn.Filter = "All audio Files|*.wav;*.mid|Wave files|*.wav|Midi files|*.mid|All files|*.*";
        if (ofn.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          byte[] FileBytes = File.ReadAllBytes(ofn.FileName);
          m_Question.QS04_Sound = FileBytes;
          PlaySoundButton.Enabled = true;
        }
      }
    }

    private void ClearSoundButton_Click(object sender, EventArgs e)
    {
      m_Question.QS04_Sound = null;
      PlaySoundButton.Enabled = false;
    }

    private void PlaySoundButton_Click(object sender, EventArgs e)
    {
      Sound.Play(m_Question.QS04_Sound);
    }

    private DataSet.QS04_QuestionsRow m_Question;
    
  }
}
