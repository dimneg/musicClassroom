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
    public partial class AddAbility : Form
    {
        #region public methods
       /// <summary>
       /// constructor
       /// </summary>

       public  AddAbility()
        {
            InitializeComponent();

            DataSet.SP01_SpecialAbilitiesRow SpRow = 
                              Program.Tables.SP01_SpecialAbilities.NewSP01_SpecialAbilitiesRow();

            SpRow.SP01_Id = 0;
            SpRow.SP01_Name = string.Empty;

            Init(SpRow);
        }
        private void Init(DataSet.SP01_SpecialAbilitiesRow SpRow)
        {
            SpecialAbilitiesBindingSource.DataSource = SpRow;
        }
        public AddAbility(DataSet.SP01_SpecialAbilitiesRow SpRow)
            : this()
        {
            Init(SpRow);

            // Disable the user name field
            //UserNameTextBox.Enabled = false;
        }

        #endregion Public Methods

        private void AddAbility_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AbilityGroup_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
