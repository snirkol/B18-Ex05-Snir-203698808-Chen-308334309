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
    public partial class DamkaForm : Form
    {
        Panel[,] m_DamkaBoardPanels;
        int m_SizeOfBoard;

        public DamkaForm(int i_SizeOfBoard)
        {
            InitializeComponent();
            m_SizeOfBoard = i_SizeOfBoard;
        }

        private void DamkaForm_Load(object sender, EventArgs e)
        {
            const int tileSize = 40;
            var color1 = Color.DarkGray;
            var color2 = Color.White;

            this.ClientSize = new System.Drawing.Size(40 * m_SizeOfBoard + 24, 40 * m_SizeOfBoard + 52);

            Label nameOfPlayerOne = new Label();
            Controls.Add(nameOfPlayerOne);


            m_DamkaBoardPanels = new Panel[m_SizeOfBoard, m_SizeOfBoard];

            for (var n = 0; n < m_SizeOfBoard; n++)
            {
                for (var m = 0; m < m_SizeOfBoard; m++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n + 12, tileSize * m + 40)
                    };

                    Controls.Add(newPanel);

                    m_DamkaBoardPanels[n, m] = newPanel;

                    if (n % 2 == 0)
                    {
                        if (m % 2 != 0)
                        {
                            newPanel.BackColor = color1;
                        }
                        else
                        {
                            newPanel.BackColor = color2;
                        }
                    }
                                                
                    else
                    {
                        if (m % 2 != 0)
                        {
                            newPanel.BackColor = color2;
                        }
                        else
                        {
                            newPanel.BackColor = color1;
                        }
                    }
                }
            }
        }
    }
}
