using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Papi.Negkas.MusicClassroom.Ux
{
    public partial class Target : UserControl
    {
        /// <summary>
        /// Event raised when the weight value changes
        /// </summary>
        [Browsable(true)]
        public event EventHandler WeightChanged;

        /// <summary>
        /// The group name this control belongs to
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Sets the text of the label
        /// </summary>
        [Browsable(true)]
        public string LabelText
        {
            get { return TitleLabel.Text; }
            set { TitleLabel.Text = value; }
        }

        /// <summary>
        /// Gets/Sets the weight
        /// </summary>
        public float Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
                WeightTextBox.Text = _weight.ToString();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Target()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the textbox value changes
        /// </summary>
        /// <param name="sender">
        /// Event sender
        /// </param>
        /// <param name="e">
        /// Event arguments
        /// </param>
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            float weight;
            if (float.TryParse(WeightTextBox.Text, out weight))
            {
                // Update the weight when the value can be parsed as float
                _weight = weight;

                var handler = WeightChanged;
                if (handler != null)
                {
                    WeightChanged(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// The value asssigned to this target
        /// </summary>
        private float _weight;

        /// <summary>
        /// Called when the weight is validating
        /// </summary>
        /// <param name="sender">
        /// Event sender
        /// </param>
        /// <param name="e">
        /// Event arguments
        /// </param>
        private void WeightTextBox_Validating(object sender, CancelEventArgs e)
        {
            float weight;
            e.Cancel = !(float.TryParse(WeightTextBox.Text, out weight)
                         &&
                         weight >= 0
                        );
        }
    }
}
