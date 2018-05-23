using B18_Ex02_1;
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
        Button[,] m_DamkaBoardButtons;
        int m_SizeOfBoard;
        const int k_TileSize = 40;
        const int k_Spaces = 12;
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }

        public GameManager GameManager { get; set; }
        Position m_currentPos ;
        Position m_desiredPos ;


        public DamkaForm(int i_SizeOfBoard, string i_PlayerOneName, string i_PlayerTwoName)
        {
            InitializeComponent();
            m_SizeOfBoard = i_SizeOfBoard;
            PlayerOneName = i_PlayerOneName;
            PlayerTwoName = i_PlayerTwoName;
            GameManager = new GameManager(PlayerOneName, PlayerTwoName, m_SizeOfBoard);
        }

        private void DamkaForm_Load(object sender, EventArgs e)
        {
            CreateBoard();
            CreateTopPanel();
        }

        private void CreateTopPanel()
        {
            int spaces = m_SizeOfBoard / 3;
            Label nameOfPlayerOne = new Label() { Text = $"{PlayerOneName}:" };
            Controls.Add(nameOfPlayerOne);
            nameOfPlayerOne.Location = new Point((((m_SizeOfBoard - (spaces * 2) - 1) / 2) * k_TileSize) + k_Spaces, k_Spaces);
            nameOfPlayerOne.Size = new System.Drawing.Size(80, 80);
            //nameOfPlayerOne.BackColor = Color.LightGreen;
            nameOfPlayerOne.Show();

            Label nameOfPlayerTwo = new Label() { Text = $"{PlayerTwoName}:" };
            Controls.Add(nameOfPlayerTwo);
            nameOfPlayerTwo.Location = new Point(this.ClientSize.Width - 92, 12);
            nameOfPlayerTwo.Size = new System.Drawing.Size(80, 80);
            //nameOfPlayerTwo.BackColor = Color.LightGreen;
            nameOfPlayerTwo.Show();
        }

        private void CreateBoard()
        {
            var color1 = Color.Black;
            var color2 = Color.White;

            this.ClientSize = new System.Drawing.Size(k_TileSize * m_SizeOfBoard + 2 * k_Spaces,
                k_TileSize * m_SizeOfBoard + k_TileSize + k_Spaces);


            m_DamkaBoardButtons = new Button[m_SizeOfBoard, m_SizeOfBoard];

            for (var n = 0; n < m_SizeOfBoard; n++)
            {
                for (var m = 0; m < m_SizeOfBoard; m++)
                {
                    ButtonWithPosition cellBoard = new ButtonWithPosition(n,m)
                    {
                        Size = new Size(k_TileSize, k_TileSize),
                        Location = new Point(k_TileSize * n + k_Spaces, k_TileSize * m + k_TileSize)
                    };

                    cellBoard.Click += OnCellBoardClick;
                    Controls.Add(cellBoard);

                    m_DamkaBoardButtons[n, m] = cellBoard;

                    if (n % 2 == 0)
                    {
                        if (m % 2 != 0)
                        {
                            cellBoard.BackColor = color2;
                        }
                        else
                        {
                            cellBoard.BackColor = color1;
                            cellBoard.Enabled = false;
                        }
                    }

                    else
                    {
                        if (m % 2 != 0)
                        {
                            cellBoard.BackColor = color1;
                            cellBoard.Enabled = false;
                        }
                        else
                        {
                            cellBoard.BackColor = color2;
                        }
                    }
                }
            }

            showCeckersInBoard(GameManager.m_Board.GetBoard());

        }

        private void OnCellBoardClick(object sender, EventArgs e)
        {
            //TODO: finish impliment

            //current select
            if(m_currentPos.m_Col == null || m_currentPos.m_Row == null)
            {
                if(((ButtonWithPosition)sender).Text != "")
                {
                    m_currentPos = new Position(
                        ((ButtonWithPosition)sender).XPosition,
                        ((ButtonWithPosition)sender).YPosition);

                    ((ButtonWithPosition)sender).BackColor = Color.LightBlue;
                }
            }

            //desired move
            else
            {
                m_desiredPos = new Position(
                    ((ButtonWithPosition)sender).XPosition,
                    ((ButtonWithPosition)sender).YPosition);

                if((m_currentPos.m_Col == m_desiredPos.m_Col) && 
                    (m_currentPos.m_Row == m_desiredPos.m_Row))
                {
                    // cancle selection
                    ((ButtonWithPosition)sender).BackColor = Color.White;
                    m_currentPos.m_Row = null;
                    m_currentPos.m_Col = null;
                    m_desiredPos.m_Row = null;
                    m_desiredPos.m_Col = null;
                }
            }
        }

        private void showCeckersInBoard(eCheckerType?[,] i_Board)
        {
            for (int i = 0; i< m_SizeOfBoard ; i++)
            {
                for( int j=0; j < m_SizeOfBoard; j++)
                {
                    m_DamkaBoardButtons[i, j].Text = convertECheckerTypeToString(i_Board[j, i]);
                }
            }
        }

        private string convertECheckerTypeToString(eCheckerType? i_EcheckerType)
        {
            string o_result;

            if(i_EcheckerType == null)
            {
                o_result = "";
            }

            else if(i_EcheckerType == eCheckerType.Team1_King)
            {
                o_result = "K";
            }

            else if (i_EcheckerType == eCheckerType.Team1_Man)
            {
                o_result = "X";
            }

            else if( i_EcheckerType == eCheckerType.Team2_King)
            {
                o_result = "U";
            }

            else // i_EcheckerType == eCheckerType.Team2_Man)
            {
                o_result = "O";
            }

            return o_result;
        }
    }
}
