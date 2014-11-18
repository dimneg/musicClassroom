namespace Papi.Negkas.MusicClassroom.Ux
{
    partial class AddAbility
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
      this.AbilityGroup = new System.Windows.Forms.GroupBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SpecialAbilitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.AddAblBtn = new System.Windows.Forms.Button();
      this.CancelAblBtn = new System.Windows.Forms.Button();
      this.AbilityGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SpecialAbilitiesBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // AbilityGroup
      // 
      this.AbilityGroup.Controls.Add(this.CancelAblBtn);
      this.AbilityGroup.Controls.Add(this.AddAblBtn);
      this.AbilityGroup.Controls.Add(this.textBox1);
      this.AbilityGroup.Location = new System.Drawing.Point(12, 40);
      this.AbilityGroup.Name = "AbilityGroup";
      this.AbilityGroup.Size = new System.Drawing.Size(384, 187);
      this.AbilityGroup.TabIndex = 0;
      this.AbilityGroup.TabStop = false;
      this.AbilityGroup.Text = "Ειδική Ικανότητα";
      this.AbilityGroup.Enter += new System.EventHandler(this.AbilityGroup_Enter);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(9, 24);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(242, 20);
      this.textBox1.TabIndex = 0;
      // 
      // SpecialAbilitiesBindingSource
      // 
      this.SpecialAbilitiesBindingSource.DataMember = "SP01_SpecialAbilities";
      // 
      // AddAblBtn
      // 
      this.AddAblBtn.Location = new System.Drawing.Point(257, 22);
      this.AddAblBtn.Name = "AddAblBtn";
      this.AddAblBtn.Size = new System.Drawing.Size(52, 23);
      this.AddAblBtn.TabIndex = 1;
      this.AddAblBtn.Text = "Ok";
      this.AddAblBtn.UseVisualStyleBackColor = true;
      // 
      // CancelAblBtn
      // 
      this.CancelAblBtn.Location = new System.Drawing.Point(315, 22);
      this.CancelAblBtn.Name = "CancelAblBtn";
      this.CancelAblBtn.Size = new System.Drawing.Size(52, 23);
      this.CancelAblBtn.TabIndex = 2;
      this.CancelAblBtn.Text = "Cancel";
      this.CancelAblBtn.UseVisualStyleBackColor = true;
      this.CancelAblBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // AddAbility
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(408, 302);
      this.Controls.Add(this.AbilityGroup);
      this.HelpButton = true;
      this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
      this.Name = "AddAbility";
      this.Text = "Δημιουργία Νέας Ικανότητας";
      this.Load += new System.EventHandler(this.AddAbility_Load);
      this.AbilityGroup.ResumeLayout(false);
      this.AbilityGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SpecialAbilitiesBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AbilityGroup;
        private System.Windows.Forms.BindingSource SpecialAbilitiesBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddAblBtn;
        private System.Windows.Forms.Button CancelAblBtn;
    }
}