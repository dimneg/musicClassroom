namespace Papi.Negkas.MusicClassroom.Ux
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.UserNameTextBox = new System.Windows.Forms.TextBox();
      this.OKButton = new System.Windows.Forms.Button();
      this.CloseButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Όνομα χρήστη:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Κωδικός: ";
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(107, 32);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.Size = new System.Drawing.Size(156, 20);
      this.PasswordTextBox.TabIndex = 3;
      // 
      // UserNameTextBox
      // 
      this.UserNameTextBox.Location = new System.Drawing.Point(107, 6);
      this.UserNameTextBox.Name = "UserNameTextBox";
      this.UserNameTextBox.Size = new System.Drawing.Size(156, 20);
      this.UserNameTextBox.TabIndex = 1;
      // 
      // OKButton
      // 
      this.OKButton.Location = new System.Drawing.Point(107, 66);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(75, 23);
      this.OKButton.TabIndex = 4;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // CloseButton
      // 
      this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CloseButton.Location = new System.Drawing.Point(188, 66);
      this.CloseButton.Name = "CloseButton";
      this.CloseButton.Size = new System.Drawing.Size(75, 23);
      this.CloseButton.TabIndex = 5;
      this.CloseButton.Text = "Έξοδος";
      this.CloseButton.UseVisualStyleBackColor = true;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.OKButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CloseButton;
      this.ClientSize = new System.Drawing.Size(275, 101);
      this.Controls.Add(this.CloseButton);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.UserNameTextBox);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Είσοδος Χρήστη";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.TextBox UserNameTextBox;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Button CloseButton;
  }
}