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
        Label m_NameOfPlayerOne = new Label();
        Label m_NameOfPlayerTwo = new Label();
        int m_SizeOfBoard;
        const int k_TileSize = 40;
        const int k_Spaces = 12;
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }

        public GameManager m_GameManager { get; set; }
        Position m_currentPos;
        Position m_desiredPos;

        public bool IsMoreEat { get; set; } = false;


        public DamkaForm(int i_SizeOfBoard, string i_PlayerOneName, string i_PlayerTwoName)
        {
            InitializeComponent();
            m_SizeOfBoard = i_SizeOfBoard;
            PlayerOneName = i_PlayerOneName;
            PlayerTwoName = i_PlayerTwoName;
            m_GameManager = new GameManager(PlayerOneName, PlayerTwoName, m_SizeOfBoard);
        }

        private void DamkaForm_Load(object sender, EventArgs e)
        {
            CreateBoard();
            CreateTopPanel();
        }

        private void CreateTopPanel()
        {
            int spaces = m_SizeOfBoard / 3;
            m_NameOfPlayerOne.Text = $"{m_GameManager.m_PlayerOne.m_Name}: {m_GameManager.m_PlayerOne.m_Score}";
            Controls.Add(m_NameOfPlayerOne);
            m_NameOfPlayerOne.Location = new Point((((m_SizeOfBoard - (spaces * 2) - 1) / 2) * k_TileSize) + k_Spaces, k_Spaces);
            m_NameOfPlayerOne.Size = new System.Drawing.Size(80, 80);
            m_NameOfPlayerOne.Show();

            m_NameOfPlayerTwo.Text = $"{m_GameManager.m_PlayerTwo.m_Name}: {m_GameManager.m_PlayerTwo.m_Score}";
            Controls.Add(m_NameOfPlayerTwo);
            m_NameOfPlayerTwo.Location = new Point(this.ClientSize.Width - 132, 12);
            m_NameOfPlayerTwo.Size = new System.Drawing.Size(80, 80);
            m_NameOfPlayerTwo.Show();
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
                    ButtonWithPosition cellBoard = new ButtonWithPosition(n, m)
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

            redrawBoard();

        }

        private void OnCellBoardClick(object sender, EventArgs e)
        {
            //Select target
            if (m_currentPos.m_Col == null || m_currentPos.m_Row == null)
            {
                if (((ButtonWithPosition)sender).Text != "")
                {
                    m_currentPos = new Position(
                        ((ButtonWithPosition)sender).YPosition,
                        ((ButtonWithPosition)sender).XPosition);

                    ((ButtonWithPosition)sender).BackColor = Color.LightBlue;
                }
            }

            //desired move
            else
            {
                m_desiredPos = new Position(
                    ((ButtonWithPosition)sender).YPosition,
                    ((ButtonWithPosition)sender).XPosition);

                if ((m_currentPos.m_Col == m_desiredPos.m_Col) &&
                    (m_currentPos.m_Row == m_desiredPos.m_Row))
                {
                    // cancle selection
                    ((ButtonWithPosition)sender).BackColor = Color.White;
                    m_currentPos.m_Row = null;
                    m_currentPos.m_Col = null;
                    m_desiredPos.m_Row = null;
                    m_desiredPos.m_Col = null;
                }

                else
                {
                    doAfterClick();
                }

                if (m_GameManager.m_CurrentUserTurn == eUserTurn.User2 
                    && m_GameManager.m_IsComputerPlaying == true && 
                    m_GameManager.m_GameStatus == eGameStatus.OnPlay)
                {
                    bool isQuit;
                    m_GameManager.GetCurrentTurnFromComputer(out m_currentPos, out m_desiredPos, out isQuit);
                    doAfterClick();
                }
            }
        }

        private void redrawBoard()
        {
            eCheckerType?[,] logicBoard = m_GameManager.m_Board.GetBoard();

            foreach (ButtonWithPosition button in m_DamkaBoardButtons)
            {
                char? currentChar = ((char?)logicBoard[button.YPosition, button.XPosition]);
                if (currentChar == null)
                {
                    button.Text = "";
                }
                else
                {
                    button.Text = currentChar.ToString();
                }
            }
        }

        private void doAfterClick()
        {
            //check if move is valid
            if (m_GameManager.CheckMove(m_currentPos, m_desiredPos))
            {
                //IsDesiredMoveValid = true;
                bool isMoreEat;
                m_GameManager.Move(m_currentPos, m_desiredPos, out isMoreEat);
                if (!isMoreEat)
                {
                    m_GameManager.NextTurn();
                }
                redrawBoard();

                m_GameManager.HandleStatusGame();

                if (m_GameManager.m_GameStatus == eGameStatus.Draw ||
                    m_GameManager.m_GameStatus == eGameStatus.PlayerOneWin ||
                    m_GameManager.m_GameStatus == eGameStatus.PlayerTwoWin)
                {
                    int playerOneScore = 0, playerTwoScore = 0;
                    m_GameManager.CalculatePointAndGameStatus(ref playerOneScore, ref playerTwoScore);
                    DialogResult result = DialogResult.No;

                    switch (m_GameManager.m_GameStatus)
                    {
                        case eGameStatus.Draw:
                            result = MessageBox.Show("Tire!\nAnother Round?", "Damka", MessageBoxButtons.YesNo);
                            break;

                        case eGameStatus.PlayerOneWin:
                            result = MessageBox.Show($"{m_GameManager.m_PlayerOne.m_Name} Won!\nAnother Round?", "Damka", MessageBoxButtons.YesNo);
                            break;

                        case eGameStatus.PlayerTwoWin:
                            result = MessageBox.Show($"{m_GameManager.m_PlayerTwo.m_Name} Won!\nAnother Round?", "Damka", MessageBoxButtons.YesNo);
                            break;

                        default:
                            break;
                    }

                    if(result == DialogResult.Yes)
                    {
                        m_GameManager.m_Board.InitBoard();
                        m_GameManager.m_GameStatus = eGameStatus.OnPlay;
                        m_GameManager.m_CurrentUserTurn = eUserTurn.User1;
                        redrawBoard();
                        CreateTopPanel();
                    }

                    else
                    {
                        this.Close();
                    }

                }

            }

            else
            {
                MessageBox.Show("Invalid Move","Damka",MessageBoxButtons.OK);
            }

            m_DamkaBoardButtons[(int)m_currentPos.m_Col, (int)m_currentPos.m_Row].BackColor = Color.White;
            m_DamkaBoardButtons[(int)m_desiredPos.m_Col, (int)m_desiredPos.m_Row].BackColor = Color.White;
            m_currentPos.m_Row = null;
            m_currentPos.m_Col = null;
            m_desiredPos.m_Row = null;
            m_desiredPos.m_Col = null;
        }
    }
}
