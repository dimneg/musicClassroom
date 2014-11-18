using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Papi.Negkas.MusicClassroom.Ux.Properties;

namespace Papi.Negkas.MusicClassroom.Ux
{
  public partial class Test : Form
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="Test">
    /// The test to run
    /// </param>
    public Test(DataSet.QS03_TestsRow Test, DataSet.US01_UsersRow User)
    {
      InitializeComponent();
      m_Test = Test;
      m_User = User;
      m_Questions = Test.GetQS04_QuestionsRows().ToList();
    }

    private void Test_Load(object sender, EventArgs e)
    {
      // Show the first question
      ShowQuestion(m_Questions[0]);
    }

    private void ShowQuestion(DataSet.QS04_QuestionsRow Question)
    {
      PreviousButton.Enabled = true;
      NextButton.Enabled = true;
      m_CurrentQuestion = Question;
      HelpLabel.Text = string.Empty;
      QuestionLabel.Text = Question.QS04_Question;

      // Load the image from the data
      try
      {
        if (Question.QS04_Image != null)
        {
          using (MemoryStream Stream = new MemoryStream(Question.QS04_Image))
          {
            QuestionPicture.Image = new Bitmap(Stream);
          }
        }
        else
        {
          QuestionPicture.Image = null;
        }
      }
      catch
      {
        QuestionPicture.Image = null;
      }

      // Play the sound data
      Sound.Play(Question.QS04_Sound);

      // Hide image panel if no image exists
      SplitContainer.Panel1Collapsed = QuestionPicture.Image == null;

      m_QuestionAttempts = 0;
      QuestionsPanel.Controls.Clear();
      int TopY = 0;
      foreach (DataSet.QS05_AnswersRow Answer in Question.GetQS05_AnswersRows())
      {
        Button Btn = new Button();
        Btn.Text = Answer.QS05_Answer;
        Btn.Tag = Answer;
        Btn.Click += new EventHandler(Btn_Click);
        Btn.Location = new Point(0, TopY);
        Btn.Size = new Size(QuestionsPanel.Width, 50);
        Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

        QuestionsPanel.Controls.Add(Btn);

        TopY += Btn.Size.Height + 6;
      }
    }

    /// <summary>
    /// Called when an answer is clicked
    /// </summary>
    /// <param name="sender">
    /// Event sender
    /// </param>
    /// <param name="e">
    /// Event arguments
    /// </param>
    void Btn_Click(object sender, EventArgs e)
    {
      Button AnswerButton = (Button)sender;
      DataSet.QS05_AnswersRow Answer = (DataSet.QS05_AnswersRow)AnswerButton.Tag;
      if (Answer.QS05_Id == m_CurrentQuestion.QS04_QS05_Id)
      {
        // Move the current question to the answered questions and remove it from the list of questions
        m_AnsweredQuestions.Add(m_CurrentQuestion, m_QuestionAttempts);
        int IndexOfQuestion = m_Questions.IndexOf(m_CurrentQuestion);
        m_Questions.RemoveAt(IndexOfQuestion);
        if (m_Questions.Count == 0)
        {
          FinalizeTest();
          Close();
          return;
        }
        else if (m_Questions.Count == IndexOfQuestion)
        {
          IndexOfQuestion = 0;
        }
        ShowQuestion(m_Questions[IndexOfQuestion]);
      }
      else
      {
        // Disable the next and previous button
        PreviousButton.Enabled = false;
        NextButton.Enabled = false;

        m_QuestionAttempts++;
        HelpLabel.Text = Answer.QS05_Advice;
        AnswerButton.Enabled = false;
      }
    }

    /// <summary>
    /// Called when the test finishes
    /// </summary>
    private void FinalizeTest()
    {
      double FinalMark = 0.0;

      foreach (var Question in m_AnsweredQuestions)
      {
        int PossibleAnswers = Question.Key.GetQS05_AnswersRows().Count();
        int AttemptedAnswers = Question.Value;

        if (AttemptedAnswers != 0)
        {
          double Nominator = PossibleAnswers / (AttemptedAnswers * 2);

          FinalMark += (double)Nominator / (double)PossibleAnswers;
        }
        else
        {
          FinalMark += 1;
        }
      }
      FinalMark = (FinalMark / m_AnsweredQuestions.Count) * 10; //grade out of 10

      // Save the final mark to the user
      int UserTestId = 0;
      DataSet.US02_UserTestsRow Row = Program.Tables.US02_UserTests.LastOrDefault();
      if (Row != null)
      {
        UserTestId = Row.US02_Id;
      }
      UserTestId++;

      Program.Tables.US02_UserTests.AddUS02_UserTestsRow(UserTestId,
                                                         m_User,
                                                         m_Test,
                                                         (decimal)FinalMark,
                                                         DateTime.Now);
      Program.Tables.Save();

      MessageBox.Show(this, 
                      string.Format(Resources.S_TestCompleted, FinalMark), 
                      Text, 
                      MessageBoxButtons.OK, 
                      MessageBoxIcon.Information);
    }

    /// <summary>
    /// The test to run
    /// </summary>
    private DataSet.QS03_TestsRow m_Test;

    /// <summary>
    /// The user taking the test
    /// </summary>
    private DataSet.US01_UsersRow m_User;

    /// <summary>
    /// The question currently on the screen
    /// </summary>
    private DataSet.QS04_QuestionsRow m_CurrentQuestion;

    /// <summary>
    /// The list of questions left to answer
    /// </summary>
    private List<DataSet.QS04_QuestionsRow> m_Questions;

    /// <summary>
    /// The number of times the user answered the current question wrong
    /// </summary>
    private int m_QuestionAttempts;

    /// <summary>
    /// The list of answered questions
    /// </summary>
    private Dictionary<DataSet.QS04_QuestionsRow, int> m_AnsweredQuestions = new Dictionary<DataSet.QS04_QuestionsRow, int>();

    private void PreviousButton_Click(object sender, EventArgs e)
    {
      int IndexOfQuestion = m_Questions.IndexOf(m_CurrentQuestion);
      IndexOfQuestion--;
      if (IndexOfQuestion < 0)
      {
        IndexOfQuestion = m_Questions.Count - 1;
      }
      ShowQuestion(m_Questions[IndexOfQuestion]);
    }

    private void NextButton_Click(object sender, EventArgs e)
    {
      int IndexOfQuestion = m_Questions.IndexOf(m_CurrentQuestion);
      IndexOfQuestion++;
      if (IndexOfQuestion == m_Questions.Count)
      {
        IndexOfQuestion = 0;
      }
      ShowQuestion(m_Questions[IndexOfQuestion]);
    }
  }
}
