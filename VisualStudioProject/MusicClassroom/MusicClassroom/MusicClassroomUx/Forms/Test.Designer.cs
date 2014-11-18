namespace Papi.Negkas.MusicClassroom.Ux
{
    partial class Test
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.QuestionPicture = new System.Windows.Forms.PictureBox();
            this.QuestionsPanel = new System.Windows.Forms.Panel();
            this.HelpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuestionLabel.Location = new System.Drawing.Point(73, 14);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(593, 49);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PreviousButton.Location = new System.Drawing.Point(12, 12);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(55, 51);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "3";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.NextButton.Location = new System.Drawing.Point(672, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(55, 51);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "4";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(12, 69);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.QuestionPicture);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.QuestionsPanel);
            this.SplitContainer.Size = new System.Drawing.Size(715, 401);
            this.SplitContainer.SplitterDistance = 107;
            this.SplitContainer.TabIndex = 3;
            // 
            // QuestionPicture
            // 
            this.QuestionPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionPicture.Location = new System.Drawing.Point(0, 0);
            this.QuestionPicture.Name = "QuestionPicture";
            this.QuestionPicture.Size = new System.Drawing.Size(715, 107);
            this.QuestionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuestionPicture.TabIndex = 0;
            this.QuestionPicture.TabStop = false;
            // 
            // QuestionsPanel
            // 
            this.QuestionsPanel.AutoScroll = true;
            this.QuestionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionsPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionsPanel.Name = "QuestionsPanel";
            this.QuestionsPanel.Size = new System.Drawing.Size(715, 290);
            this.QuestionsPanel.TabIndex = 0;
            // 
            // HelpLabel
            // 
            this.HelpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HelpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelpLabel.Location = new System.Drawing.Point(12, 473);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(715, 47);
            this.HelpLabel.TabIndex = 4;
            this.HelpLabel.Text = "label1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 529);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.PictureBox QuestionPicture;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Panel QuestionsPanel;
    }
}