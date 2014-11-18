using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Papi.Negkas.MusicClassroom.Ux
{
    public partial class ViewImage : Form
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public ViewImage(Image image)
        {
            InitializeComponent();
            PictureBox.Image = image;

            StartTime = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndTime = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
