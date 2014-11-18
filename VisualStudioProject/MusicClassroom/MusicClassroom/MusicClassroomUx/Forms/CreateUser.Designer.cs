namespace Papi.Negkas.MusicClassroom.Ux
{
  partial class CreateUser
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
      this.UserNameLabel = new System.Windows.Forms.Label();
      this.UserNameTextBox = new System.Windows.Forms.TextBox();
      this.UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.NameLabel = new System.Windows.Forms.Label();
      this.NameTextBox = new System.Windows.Forms.TextBox();
      this.SurnameLabel = new System.Windows.Forms.Label();
      this.SurnameTextBox = new System.Windows.Forms.TextBox();
      this.AgeLabel = new System.Windows.Forms.Label();
      this.AgeTextBox = new System.Windows.Forms.TextBox();
      this.ExperienceLabel = new System.Windows.Forms.Label();
      this.GenderLabel = new System.Windows.Forms.Label();
      this.ExperienceSlider = new System.Windows.Forms.TrackBar();
      this.OkBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.UserDataGroup = new System.Windows.Forms.GroupBox();
      this.adminUserInvtextbox = new System.Windows.Forms.TextBox();
      this.adminUserExptextbox = new System.Windows.Forms.TextBox();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SelectableMusicGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataSet = new Papi.Negkas.MusicClassroom.Ux.DataSet();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.InstrumentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SelectableInstrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.TotalTrainingComboBox = new System.Windows.Forms.ComboBox();
      this.EducationTypeComboBox = new System.Windows.Forms.ComboBox();
      this.us05UserEducationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.InvolvementSlider = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.EducationTypeLabel = new System.Windows.Forms.Label();
      this.IsFemaleCheck = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.VerifyPasswordTextBox = new System.Windows.Forms.TextBox();
      this.AllEduTypebindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iN01InstrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iN01_InstrumentsTableAdapter = new Papi.Negkas.MusicClassroom.Ux.DataSetTableAdapters.IN01_InstrumentsTableAdapter();
      this.us05_User_Education_TypeTableAdapter = new Papi.Negkas.MusicClassroom.Ux.DataSetTableAdapters.Us05_User_Education_TypeTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExperienceSlider)).BeginInit();
      this.UserDataGroup.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectableMusicGenresBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectableInstrumentsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.us05UserEducationTypeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.InvolvementSlider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.AllEduTypebindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iN01InstrumentsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // UserNameLabel
      // 
      this.UserNameLabel.AutoSize = true;
      this.UserNameLabel.Location = new System.Drawing.Point(5, 28);
      this.UserNameLabel.Name = "UserNameLabel";
      this.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.UserNameLabel.Size = new System.Drawing.Size(88, 13);
      this.UserNameLabel.TabIndex = 0;
      this.UserNameLabel.Text = "Όνομα Χρήστη :";
      this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
      // 
      // UserNameTextBox
      // 
      this.UserNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.UserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "US01_UserName", true));
      this.UserNameTextBox.Location = new System.Drawing.Point(159, 25);
      this.UserNameTextBox.Name = "UserNameTextBox";
      this.UserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.UserNameTextBox.Size = new System.Drawing.Size(215, 20);
      this.UserNameTextBox.TabIndex = 1;
      // 
      // UserBindingSource
      // 
      this.UserBindingSource.DataSource = typeof(Papi.Negkas.MusicClassroom.Ux.DataSet.US01_UsersRow);
      this.UserBindingSource.CurrentChanged += new System.EventHandler(this.UserBindingSource_CurrentChanged);
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Location = new System.Drawing.Point(5, 54);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.PasswordLabel.Size = new System.Drawing.Size(50, 13);
      this.PasswordLabel.TabIndex = 2;
      this.PasswordLabel.Text = "Κωδικός:";
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "US01_Password", true));
      this.PasswordTextBox.Location = new System.Drawing.Point(159, 51);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.PasswordTextBox.Size = new System.Drawing.Size(215, 20);
      this.PasswordTextBox.TabIndex = 3;
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(5, 106);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NameLabel.Size = new System.Drawing.Size(44, 13);
      this.NameLabel.TabIndex = 6;
      this.NameLabel.Text = "Όνομα:";
      // 
      // NameTextBox
      // 
      this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "US01_Name", true));
      this.NameTextBox.Location = new System.Drawing.Point(157, 103);
      this.NameTextBox.Name = "NameTextBox";
      this.NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.NameTextBox.Size = new System.Drawing.Size(215, 20);
      this.NameTextBox.TabIndex = 7;
      // 
      // SurnameLabel
      // 
      this.SurnameLabel.AutoSize = true;
      this.SurnameLabel.Location = new System.Drawing.Point(5, 132);
      this.SurnameLabel.Name = "SurnameLabel";
      this.SurnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
      this.SurnameLabel.TabIndex = 8;
      this.SurnameLabel.Text = "Επίθετο:";
      // 
      // SurnameTextBox
      // 
      this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.SurnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "US01_Surname", true));
      this.SurnameTextBox.Location = new System.Drawing.Point(156, 129);
      this.SurnameTextBox.Name = "SurnameTextBox";
      this.SurnameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.SurnameTextBox.Size = new System.Drawing.Size(215, 20);
      this.SurnameTextBox.TabIndex = 9;
      // 
      // AgeLabel
      // 
      this.AgeLabel.AutoSize = true;
      this.AgeLabel.Location = new System.Drawing.Point(5, 158);
      this.AgeLabel.Name = "AgeLabel";
      this.AgeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.AgeLabel.Size = new System.Drawing.Size(40, 13);
      this.AgeLabel.TabIndex = 10;
      this.AgeLabel.Text = "Ηλικία:";
      // 
      // AgeTextBox
      // 
      this.AgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.AgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "US01_Age", true));
      this.AgeTextBox.Location = new System.Drawing.Point(156, 155);
      this.AgeTextBox.Name = "AgeTextBox";
      this.AgeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.AgeTextBox.Size = new System.Drawing.Size(215, 20);
      this.AgeTextBox.TabIndex = 11;
      // 
      // ExperienceLabel
      // 
      this.ExperienceLabel.AutoSize = true;
      this.ExperienceLabel.Location = new System.Drawing.Point(5, 192);
      this.ExperienceLabel.Name = "ExperienceLabel";
      this.ExperienceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.ExperienceLabel.Size = new System.Drawing.Size(53, 13);
      this.ExperienceLabel.TabIndex = 12;
      this.ExperienceLabel.Text = "Εμπειρία:";
      this.ExperienceLabel.Click += new System.EventHandler(this.ExperienceLabel_Click);
      // 
      // GenderLabel
      // 
      this.GenderLabel.AutoSize = true;
      this.GenderLabel.Location = new System.Drawing.Point(5, 225);
      this.GenderLabel.Name = "GenderLabel";
      this.GenderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.GenderLabel.Size = new System.Drawing.Size(37, 13);
      this.GenderLabel.TabIndex = 14;
      this.GenderLabel.Text = "Φύλο:";
      this.GenderLabel.Click += new System.EventHandler(this.GenderLabel_Click);
      // 
      // ExperienceSlider
      // 
      this.ExperienceSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ExperienceSlider.AutoSize = false;
      this.ExperienceSlider.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.UserBindingSource, "US01_TheoryExperience", true));
      this.ExperienceSlider.Location = new System.Drawing.Point(147, 181);
      this.ExperienceSlider.Maximum = 20;
      this.ExperienceSlider.Name = "ExperienceSlider";
      this.ExperienceSlider.Size = new System.Drawing.Size(215, 35);
      this.ExperienceSlider.TabIndex = 13;
      this.ExperienceSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.ExperienceSlider.Scroll += new System.EventHandler(this.ExperienceSlider_Scroll);
      // 
      // OkBtn
      // 
      this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.OkBtn.Location = new System.Drawing.Point(761, 433);
      this.OkBtn.Name = "OkBtn";
      this.OkBtn.Size = new System.Drawing.Size(75, 23);
      this.OkBtn.TabIndex = 1;
      this.OkBtn.Text = "OK";
      this.OkBtn.UseVisualStyleBackColor = true;
      this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
      // 
      // CancelBtn
      // 
      this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(842, 433);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(75, 23);
      this.CancelBtn.TabIndex = 2;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
      // 
      // UserDataGroup
      // 
      this.UserDataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.UserDataGroup.Controls.Add(this.adminUserInvtextbox);
      this.UserDataGroup.Controls.Add(this.adminUserExptextbox);
      this.UserDataGroup.Controls.Add(this.dataGridView2);
      this.UserDataGroup.Controls.Add(this.dataGridView1);
      this.UserDataGroup.Controls.Add(this.TotalTrainingComboBox);
      this.UserDataGroup.Controls.Add(this.EducationTypeComboBox);
      this.UserDataGroup.Controls.Add(this.InvolvementSlider);
      this.UserDataGroup.Controls.Add(this.label4);
      this.UserDataGroup.Controls.Add(this.label3);
      this.UserDataGroup.Controls.Add(this.EducationTypeLabel);
      this.UserDataGroup.Controls.Add(this.IsFemaleCheck);
      this.UserDataGroup.Controls.Add(this.UserNameLabel);
      this.UserDataGroup.Controls.Add(this.UserNameTextBox);
      this.UserDataGroup.Controls.Add(this.label1);
      this.UserDataGroup.Controls.Add(this.PasswordLabel);
      this.UserDataGroup.Controls.Add(this.ExperienceSlider);
      this.UserDataGroup.Controls.Add(this.VerifyPasswordTextBox);
      this.UserDataGroup.Controls.Add(this.PasswordTextBox);
      this.UserDataGroup.Controls.Add(this.NameLabel);
      this.UserDataGroup.Controls.Add(this.GenderLabel);
      this.UserDataGroup.Controls.Add(this.NameTextBox);
      this.UserDataGroup.Controls.Add(this.ExperienceLabel);
      this.UserDataGroup.Controls.Add(this.SurnameLabel);
      this.UserDataGroup.Controls.Add(this.AgeTextBox);
      this.UserDataGroup.Controls.Add(this.SurnameTextBox);
      this.UserDataGroup.Controls.Add(this.AgeLabel);
      this.UserDataGroup.Location = new System.Drawing.Point(32, 12);
      this.UserDataGroup.Name = "UserDataGroup";
      this.UserDataGroup.Size = new System.Drawing.Size(884, 415);
      this.UserDataGroup.TabIndex = 0;
      this.UserDataGroup.TabStop = false;
      this.UserDataGroup.Text = "Στοιχεία Χρήστη";
      // 
      // adminUserInvtextbox
      // 
      this.adminUserInvtextbox.Location = new System.Drawing.Point(377, 368);
      this.adminUserInvtextbox.Name = "adminUserInvtextbox";
      this.adminUserInvtextbox.Size = new System.Drawing.Size(25, 20);
      this.adminUserInvtextbox.TabIndex = 65;
      // 
      // adminUserExptextbox
      // 
      this.adminUserExptextbox.Location = new System.Drawing.Point(380, 197);
      this.adminUserExptextbox.Name = "adminUserExptextbox";
      this.adminUserExptextbox.Size = new System.Drawing.Size(25, 20);
      this.adminUserExptextbox.TabIndex = 64;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn1});
      this.dataGridView2.DataSource = this.SelectableMusicGenresBindingSource;
      this.dataGridView2.Location = new System.Drawing.Point(481, 181);
      this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersVisible = false;
      this.dataGridView2.RowTemplate.Height = 24;
      this.dataGridView2.Size = new System.Drawing.Size(384, 172);
      this.dataGridView2.TabIndex = 63;
      // 
      // Column1
      // 
      this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.Column1.DataPropertyName = "IsSelected";
      this.Column1.HeaderText = "";
      this.Column1.Name = "Column1";
      this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Column1.Width = 21;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn1.HeaderText = "Μουσικα Είδη";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // SelectableMusicGenresBindingSource
      // 
      this.SelectableMusicGenresBindingSource.DataSource = this.dataSet;
      this.SelectableMusicGenresBindingSource.Position = 0;
      // 
      // dataSet
      // 
      this.dataSet.DataSetName = "DataSet";
      this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn,
            this.InstrumentNameColumn});
      this.dataGridView1.DataSource = this.SelectableInstrumentsBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(481, 25);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(384, 120);
      this.dataGridView1.TabIndex = 62;
      // 
      // isSelectedDataGridViewCheckBoxColumn
      // 
      this.isSelectedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
      this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "";
      this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
      this.isSelectedDataGridViewCheckBoxColumn.Width = 5;
      // 
      // InstrumentNameColumn
      // 
      this.InstrumentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.InstrumentNameColumn.DataPropertyName = "Name";
      this.InstrumentNameColumn.HeaderText = "Μουσικα Όργανα";
      this.InstrumentNameColumn.Name = "InstrumentNameColumn";
      this.InstrumentNameColumn.ReadOnly = true;
      // 
      // SelectableInstrumentsBindingSource
      // 
      this.SelectableInstrumentsBindingSource.DataSource = typeof(Papi.Negkas.MusicClassroom.Ux.SelectableInstrument);
      // 
      // TotalTrainingComboBox
      // 
      this.TotalTrainingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.TotalTrainingComboBox.FormattingEnabled = true;
      this.TotalTrainingComboBox.Items.AddRange(new object[] {
            "1-2 χρόνια",
            "3-5 χρόνια",
            "6-9 χρόνια",
            "10+ χρόνια",
            "Είμαι πτυχιούχος κάποιου οργάνου"});
      this.TotalTrainingComboBox.Location = new System.Drawing.Point(156, 288);
      this.TotalTrainingComboBox.Name = "TotalTrainingComboBox";
      this.TotalTrainingComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.TotalTrainingComboBox.Size = new System.Drawing.Size(216, 21);
      this.TotalTrainingComboBox.TabIndex = 61;
      // 
      // EducationTypeComboBox
      // 
      this.EducationTypeComboBox.DataSource = this.us05UserEducationTypeBindingSource;
      this.EducationTypeComboBox.DisplayMember = "Us05_Education_type";
      this.EducationTypeComboBox.FormattingEnabled = true;
      this.EducationTypeComboBox.Location = new System.Drawing.Point(154, 247);
      this.EducationTypeComboBox.Name = "EducationTypeComboBox";
      this.EducationTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.EducationTypeComboBox.Size = new System.Drawing.Size(217, 21);
      this.EducationTypeComboBox.TabIndex = 21;
      this.EducationTypeComboBox.ValueMember = "Us05_id";
      // 
      // us05UserEducationTypeBindingSource
      // 
      this.us05UserEducationTypeBindingSource.DataMember = "Us05_User_Education_Type";
      this.us05UserEducationTypeBindingSource.DataSource = this.dataSet;
      // 
      // InvolvementSlider
      // 
      this.InvolvementSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.InvolvementSlider.AutoSize = false;
      this.InvolvementSlider.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.UserBindingSource, "Us01_TotalMusicYears", true));
      this.InvolvementSlider.Location = new System.Drawing.Point(159, 358);
      this.InvolvementSlider.Maximum = 20;
      this.InvolvementSlider.Name = "InvolvementSlider";
      this.InvolvementSlider.Size = new System.Drawing.Size(212, 35);
      this.InvolvementSlider.TabIndex = 60;
      this.InvolvementSlider.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.InvolvementSlider.Scroll += new System.EventHandler(this.InvolvementSlider_Scroll);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(2, 368);
      this.label4.Name = "label4";
      this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label4.Size = new System.Drawing.Size(161, 13);
      this.label4.TabIndex = 18;
      this.label4.Text = "Συνολικά Χρόνια Ενασχόλησης";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(2, 288);
      this.label3.Name = "label3";
      this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label3.Size = new System.Drawing.Size(160, 13);
      this.label3.TabIndex = 17;
      this.label3.Text = "Συνολικά Χρόνια Εκπαίδευσης:";
      // 
      // EducationTypeLabel
      // 
      this.EducationTypeLabel.AutoSize = true;
      this.EducationTypeLabel.Location = new System.Drawing.Point(2, 253);
      this.EducationTypeLabel.Name = "EducationTypeLabel";
      this.EducationTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.EducationTypeLabel.Size = new System.Drawing.Size(104, 13);
      this.EducationTypeLabel.TabIndex = 16;
      this.EducationTypeLabel.Text = "Είδος Εκπαίδευσης:";
      this.EducationTypeLabel.Click += new System.EventHandler(this.label2_Click);
      // 
      // IsFemaleCheck
      // 
      this.IsFemaleCheck.AutoSize = true;
      this.IsFemaleCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.UserBindingSource, "US01_Gender", true));
      this.IsFemaleCheck.Location = new System.Drawing.Point(153, 221);
      this.IsFemaleCheck.Name = "IsFemaleCheck";
      this.IsFemaleCheck.Size = new System.Drawing.Size(94, 17);
      this.IsFemaleCheck.TabIndex = 15;
      this.IsFemaleCheck.Text = "Είναι Γυναίκα";
      this.IsFemaleCheck.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 80);
      this.label1.Name = "label1";
      this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Επαλ. Κωδικού:";
      // 
      // VerifyPasswordTextBox
      // 
      this.VerifyPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.VerifyPasswordTextBox.Location = new System.Drawing.Point(158, 77);
      this.VerifyPasswordTextBox.Name = "VerifyPasswordTextBox";
      this.VerifyPasswordTextBox.PasswordChar = '*';
      this.VerifyPasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.VerifyPasswordTextBox.Size = new System.Drawing.Size(215, 20);
      this.VerifyPasswordTextBox.TabIndex = 5;
      this.VerifyPasswordTextBox.Text = "/";
      // 
      // iN01InstrumentsBindingSource
      // 
      this.iN01InstrumentsBindingSource.DataMember = "IN01_Instruments";
      this.iN01InstrumentsBindingSource.DataSource = this.dataSet;
      // 
      // iN01_InstrumentsTableAdapter
      // 
      this.iN01_InstrumentsTableAdapter.ClearBeforeFill = true;
      // 
      // us05_User_Education_TypeTableAdapter
      // 
      this.us05_User_Education_TypeTableAdapter.ClearBeforeFill = true;
      // 
      // CreateUser
      // 
      this.AcceptButton = this.OkBtn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelBtn;
      this.ClientSize = new System.Drawing.Size(929, 468);
      this.Controls.Add(this.UserDataGroup);
      this.Controls.Add(this.CancelBtn);
      this.Controls.Add(this.OkBtn);
      this.MinimumSize = new System.Drawing.Size(365, 315);
      this.Name = "CreateUser";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Δημιουργία Νέου Χρήστη";
      this.Load += new System.EventHandler(this.CreateUser_Load);
      ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExperienceSlider)).EndInit();
      this.UserDataGroup.ResumeLayout(false);
      this.UserDataGroup.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectableMusicGenresBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectableInstrumentsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.us05UserEducationTypeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.InvolvementSlider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.AllEduTypebindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iN01InstrumentsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label UserNameLabel;
    private System.Windows.Forms.TextBox UserNameTextBox;
    private System.Windows.Forms.Label PasswordLabel;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.TextBox NameTextBox;
    private System.Windows.Forms.Label SurnameLabel;
    private System.Windows.Forms.TextBox SurnameTextBox;
    private System.Windows.Forms.Label AgeLabel;
    private System.Windows.Forms.TextBox AgeTextBox;
    private System.Windows.Forms.Label ExperienceLabel;
    private System.Windows.Forms.Label GenderLabel;
    private System.Windows.Forms.TrackBar ExperienceSlider;
    private System.Windows.Forms.Button OkBtn;
    private System.Windows.Forms.Button CancelBtn;
    private System.Windows.Forms.GroupBox UserDataGroup;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox VerifyPasswordTextBox;
    private System.Windows.Forms.BindingSource UserBindingSource;
    private System.Windows.Forms.CheckBox IsFemaleCheck;
    private System.Windows.Forms.Label EducationTypeLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TrackBar InvolvementSlider;
    private System.Windows.Forms.ComboBox EducationTypeComboBox;
    private System.Windows.Forms.ComboBox TotalTrainingComboBox;
    private System.Windows.Forms.BindingSource AllEduTypebindingSource;
    private DataSet dataSet;
    private System.Windows.Forms.BindingSource iN01InstrumentsBindingSource;
    private DataSetTableAdapters.IN01_InstrumentsTableAdapter iN01_InstrumentsTableAdapter;
    private System.Windows.Forms.BindingSource us05UserEducationTypeBindingSource;
    private DataSetTableAdapters.Us05_User_Education_TypeTableAdapter us05_User_Education_TypeTableAdapter;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource SelectableInstrumentsBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn InstrumentNameColumn;
    private System.Windows.Forms.BindingSource SelectableMusicGenresBindingSource;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.TextBox adminUserExptextbox;
    private System.Windows.Forms.TextBox adminUserInvtextbox;
  }
}