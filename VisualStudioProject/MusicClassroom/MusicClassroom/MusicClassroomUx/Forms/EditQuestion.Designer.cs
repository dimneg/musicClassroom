namespace Papi.Negkas.MusicClassroom.Ux
{
  partial class EditQuestion
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
      this.components = new System.ComponentModel.Container();
      this.QuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.QuestionPropertiesGroupBox = new System.Windows.Forms.GroupBox();
      this.PlaySoundButton = new System.Windows.Forms.Button();
      this.SetAudioButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.ClearSoundButton = new System.Windows.Forms.Button();
      this.ClearImageButton = new System.Windows.Forms.Button();
      this.SetImageButton = new System.Windows.Forms.Button();
      this.ImageLabel = new System.Windows.Forms.Label();
      this.QuestionImage = new System.Windows.Forms.PictureBox();
      this.QuestionText = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.OkButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).BeginInit();
      this.QuestionPropertiesGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).BeginInit();
      this.SuspendLayout();
      // 
      // QuestionBindingSource
      // 
      this.QuestionBindingSource.DataSource = typeof(Papi.Negkas.MusicClassroom.Ux.DataSet.QS04_QuestionsRow);
      // 
      // QuestionPropertiesGroupBox
      // 
      this.QuestionPropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.QuestionPropertiesGroupBox.Controls.Add(this.PlaySoundButton);
      this.QuestionPropertiesGroupBox.Controls.Add(this.SetAudioButton);
      this.QuestionPropertiesGroupBox.Controls.Add(this.label2);
      this.QuestionPropertiesGroupBox.Controls.Add(this.ClearSoundButton);
      this.QuestionPropertiesGroupBox.Controls.Add(this.ClearImageButton);
      this.QuestionPropertiesGroupBox.Controls.Add(this.SetImageButton);
      this.QuestionPropertiesGroupBox.Controls.Add(this.ImageLabel);
      this.QuestionPropertiesGroupBox.Controls.Add(this.QuestionImage);
      this.QuestionPropertiesGroupBox.Controls.Add(this.QuestionText);
      this.QuestionPropertiesGroupBox.Controls.Add(this.label1);
      this.QuestionPropertiesGroupBox.Location = new System.Drawing.Point(6, 6);
      this.QuestionPropertiesGroupBox.Name = "QuestionPropertiesGroupBox";
      this.QuestionPropertiesGroupBox.Size = new System.Drawing.Size(463, 275);
      this.QuestionPropertiesGroupBox.TabIndex = 1;
      this.QuestionPropertiesGroupBox.TabStop = false;
      this.QuestionPropertiesGroupBox.Text = "Στοιχεία Ερώτησης";
      // 
      // PlaySoundButton
      // 
      this.PlaySoundButton.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.PlaySoundButton.Location = new System.Drawing.Point(100, 204);
      this.PlaySoundButton.Name = "PlaySoundButton";
      this.PlaySoundButton.Size = new System.Drawing.Size(324, 60);
      this.PlaySoundButton.TabIndex = 6;
      this.PlaySoundButton.Text = "4";
      this.PlaySoundButton.UseVisualStyleBackColor = true;
      this.PlaySoundButton.Click += new System.EventHandler(this.PlaySoundButton_Click);
      // 
      // SetAudioButton
      // 
      this.SetAudioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SetAudioButton.Location = new System.Drawing.Point(430, 204);
      this.SetAudioButton.Name = "SetAudioButton";
      this.SetAudioButton.Size = new System.Drawing.Size(27, 27);
      this.SetAudioButton.TabIndex = 7;
      this.SetAudioButton.Text = "...";
      this.SetAudioButton.UseVisualStyleBackColor = true;
      this.SetAudioButton.Click += new System.EventHandler(this.SetAudioButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 229);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Ήχος:";
      // 
      // ClearSoundButton
      // 
      this.ClearSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ClearSoundButton.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.ClearSoundButton.Location = new System.Drawing.Point(430, 237);
      this.ClearSoundButton.Name = "ClearSoundButton";
      this.ClearSoundButton.Size = new System.Drawing.Size(27, 27);
      this.ClearSoundButton.TabIndex = 8;
      this.ClearSoundButton.Text = "r";
      this.ClearSoundButton.UseVisualStyleBackColor = true;
      this.ClearSoundButton.Click += new System.EventHandler(this.ClearSoundButton_Click);
      // 
      // ClearImageButton
      // 
      this.ClearImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ClearImageButton.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.ClearImageButton.Location = new System.Drawing.Point(430, 87);
      this.ClearImageButton.Name = "ClearImageButton";
      this.ClearImageButton.Size = new System.Drawing.Size(27, 27);
      this.ClearImageButton.TabIndex = 4;
      this.ClearImageButton.Text = "r";
      this.ClearImageButton.UseVisualStyleBackColor = true;
      this.ClearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
      // 
      // SetImageButton
      // 
      this.SetImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.SetImageButton.Location = new System.Drawing.Point(430, 54);
      this.SetImageButton.Name = "SetImageButton";
      this.SetImageButton.Size = new System.Drawing.Size(27, 27);
      this.SetImageButton.TabIndex = 3;
      this.SetImageButton.Text = "...";
      this.SetImageButton.UseVisualStyleBackColor = true;
      this.SetImageButton.Click += new System.EventHandler(this.SetImageButton_Click);
      // 
      // ImageLabel
      // 
      this.ImageLabel.AutoSize = true;
      this.ImageLabel.Location = new System.Drawing.Point(18, 54);
      this.ImageLabel.Name = "ImageLabel";
      this.ImageLabel.Size = new System.Drawing.Size(43, 13);
      this.ImageLabel.TabIndex = 2;
      this.ImageLabel.Text = "Εικόνα:";
      // 
      // QuestionImage
      // 
      this.QuestionImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.QuestionImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.QuestionImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.QuestionBindingSource, "QS04_Image", true));
      this.QuestionImage.Location = new System.Drawing.Point(100, 54);
      this.QuestionImage.Name = "QuestionImage";
      this.QuestionImage.Size = new System.Drawing.Size(324, 144);
      this.QuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.QuestionImage.TabIndex = 2;
      this.QuestionImage.TabStop = false;
      // 
      // QuestionText
      // 
      this.QuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.QuestionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.QuestionBindingSource, "QS04_Question", true));
      this.QuestionText.Location = new System.Drawing.Point(100, 27);
      this.QuestionText.Name = "QuestionText";
      this.QuestionText.Size = new System.Drawing.Size(357, 21);
      this.QuestionText.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ερώτηση:";
      // 
      // CancelBtn
      // 
      this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(394, 287);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(75, 23);
      this.CancelBtn.TabIndex = 0;
      this.CancelBtn.Text = "Άκυρο";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // OkButton
      // 
      this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OkButton.Location = new System.Drawing.Point(313, 287);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(75, 23);
      this.OkButton.TabIndex = 2;
      this.OkButton.Text = "OK";
      this.OkButton.UseVisualStyleBackColor = true;
      // 
      // EditQuestion
      // 
      this.AcceptButton = this.OkButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(475, 316);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.CancelBtn);
      this.Controls.Add(this.QuestionPropertiesGroupBox);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
      this.Name = "EditQuestion";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ερώτηση";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditQuestion_FormClosing);
      this.Load += new System.EventHandler(this.EditQuestion_Load);
      ((System.ComponentModel.ISupportInitialize)(this.QuestionBindingSource)).EndInit();
      this.QuestionPropertiesGroupBox.ResumeLayout(false);
      this.QuestionPropertiesGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.QuestionImage)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.BindingSource QuestionBindingSource;
    private System.Windows.Forms.GroupBox QuestionPropertiesGroupBox;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.Button OkButton;
    private System.Windows.Forms.TextBox QuestionText;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox QuestionImage;
    private System.Windows.Forms.Label ImageLabel;
    private System.Windows.Forms.Button SetImageButton;
    private System.Windows.Forms.Button PlaySoundButton;
    private System.Windows.Forms.Button SetAudioButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button ClearImageButton;
    private System.Windows.Forms.Button ClearSoundButton;
  }
}