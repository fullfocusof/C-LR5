using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media; // fff

namespace LR5._2
{
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
        }

        private void buttonSunAndClouds_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(1);
            temp.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRecSquare_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(2);
            temp.ShowDialog();
        }

        private void buttonChess_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(3);
            temp.ShowDialog();
        }

        private void buttonSinX_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(4);
            temp.ShowDialog();
        }

        private void buttonSnowflakeRec_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(5);
            temp.ShowDialog();
        }

        private void buttonFallSnowflake_Click(object sender, EventArgs e)
        {
            FallSnowflakeForm temp = new FallSnowflakeForm();
            temp.ShowDialog();
        }

        private void buttonRecEllipse_Click(object sender, EventArgs e)
        {
            ExtraForm temp = new ExtraForm(6);
            temp.ShowDialog();
        }
    }
}
