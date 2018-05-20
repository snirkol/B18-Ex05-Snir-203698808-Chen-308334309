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
    }
}
