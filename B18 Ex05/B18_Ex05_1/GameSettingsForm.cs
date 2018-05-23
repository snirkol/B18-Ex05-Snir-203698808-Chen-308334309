using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B18_Ex05_1
{
    public partial class GameSettingsForm : Form
    {
        public int sizeOfBoard { get; set; }
        public string nameOfPlayerOne { get; set; }
        public string nameOfPlayerTwo { get; set; }
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPlayer2.Enabled = CheckBoxPlayer2.Checked;
            TextBoxPlayer2.Text = "";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if(radioButton6X6.Checked)
            {
                sizeOfBoard = 6;
            }
            else if(radioButton8X8.Checked)
            {
                sizeOfBoard = 8;
            }
            else
            {
                sizeOfBoard = 10;
            }

            nameOfPlayerOne = textBoxPlayer1.Text;
            nameOfPlayerTwo = CheckBoxPlayer2.Checked ? TextBoxPlayer2.Text : null;
            this.Close();
        }
    }
}
