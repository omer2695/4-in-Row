using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic;

namespace Ex05.UI
{
    public partial class GameplayForm : Form
    {
        private Game m_Game;

        public GameplayForm(Game i_Game)
        {
            m_Game = i_Game;
            InitializeComponent();
            InitializeFormUI();
        }

        private void InitializeFormUI()
        {
            for (int i = 0; i <= m_Game.Rows; i++)
            {
                for (int j = 0; j < m_Game.Cols; j++)
                {
                    if (i == 0)
                    {
                        Button button = new Button();
                        button.Name = string.Format(string.Format("button{0}", j));
                        button.Location = new System.Drawing.Point((5 * m_Game.Cols) + (j * 35), 10);
                        button.Text = string.Format("{0}", j + 1);
                        button.Click += OnButtonClicked;
                        button.Size = new System.Drawing.Size(30, 20);
                        this.Controls.Add(button);
                    }
                    else
                    {
                        Button button = new Button();
                        button.Name = string.Format("button{0}{1}", i, j);
                        button.Size = new System.Drawing.Size(30, 30);
                        button.Location = new System.Drawing.Point((5 * m_Game.Cols) + (j * 35), 10 + (i * 32));
                        this.Controls.Add(button);
                    }
                }
            }

            Label playerOneLabel = new Label();
            playerOneLabel.Text = string.Format("Player 1: {0}", m_Game.Player1.Score);
            playerOneLabel.Name = "PlayerOneScore";
            playerOneLabel.Size = new System.Drawing.Size(58, 15);
            playerOneLabel.Location = new System.Drawing.Point((m_Game.Cols * 60) / 10, 50 + (m_Game.Rows * 32));
            this.Controls.Add(playerOneLabel);

            Label playerTwoLabel = new Label();
            playerTwoLabel.Location = new System.Drawing.Point((m_Game.Cols * 60) / 3, 50 + (m_Game.Rows * 32));
            playerTwoLabel.Name = "PlayerTwoScore";
            if (m_Game.Player2.IsComputer == true)
            {
                playerTwoLabel.Text = string.Format("Computer: {0}", m_Game.Player2.Score);
            }
            else
            {
                playerTwoLabel.Text = string.Format("Player 2: {0}", m_Game.Player2.Score);
            }

            this.Controls.Add(playerTwoLabel);
        }
      
        private void OnButtonClicked(object sender, EventArgs e)
        {
            eStatusCodes doesTheGameContinue = m_Game.UpdateBoardAndReturnCode(int.Parse(((Button)sender).Text) - 1 );
            SendResultToUi(doesTheGameContinue);

            if(m_Game.Player2.IsComputer == true && doesTheGameContinue == eStatusCodes.ContinueGame)
            {
                eStatusCodes status = m_Game.RandomlyPickAColumn();
                SendResultToUi(status);
            }
        }

        private void SendResultToUi(eStatusCodes result)
        {
            if (result == eStatusCodes.Tie)
            {
                UpdateGameBoard();
                ShowMessageBox("Its a Tie!\nAnother Round?", "A Tie!");
            }
            else if (result == eStatusCodes.PlayerWon)
            {
                UpdateScore();
                UpdateGameBoard();
                ShowMessageBox(string.Format("{0} Won!!\nAnother Round?", m_Game.CurrentPlayer.ToString()), "A Win!");
            }
            else
            {
                UpdateGameBoard();
            }
        }

        private void UpdateGameBoard()
        {
            for (int i = 1; i <= m_Game.Rows; i++)
            {
                for (int j = 0; j < m_Game.Cols; j++)
                {
                    this.Controls[string.Format("button{0}{1}", i, j)].Text = char.ToString(m_Game.GameBoard.GameBoard[i - 1, j]);
                }
            }

            for(int i = 0; i < m_Game.Cols; i++)
            {
                if(m_Game.GameBoard.GameBoard[0, i] != ' ')
                {
                    this.Controls[string.Format("button{0}", i)].Enabled = false;
                }
            }
        }

        public void UpdateScore()
        {
            if(m_Game.CurrentPlayer == m_Game.Player1)
            {
                m_Game.Player1.Score = m_Game.Player1.Score + 1;
                this.Controls["PlayerOneScore"].Text = string.Format("Player 1: {0}", m_Game.Player1.Score);
            }
            else
            {
                m_Game.Player2.Score = m_Game.Player2.Score + 1;
                if (m_Game.Player2.IsComputer == true)
                {
                    this.Controls["PlayerTwoScore"].Text = string.Format("Computer: {0}", m_Game.Player2.Score);
                }
                else
                {
                    this.Controls["PlayerTwoScore"].Text = string.Format("Player 2: {0}", m_Game.Player2.Score);
                }
            }
        }

        public void RestartButtons()
        {
            for (int i = 0; i < m_Game.Cols; i++)
            {
                    this.Controls[string.Format("button{0}", i)].Enabled = true;
            }
        }

        private void ShowMessageBox(string i_Message, string i_Title)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(i_Message, i_Title, buttons);
            if (result == DialogResult.Yes)
            {
                m_Game.RestartGame();
                UpdateGameBoard();
                RestartButtons();
            }
            else
            {
                this.Close();
            }
        }
    }
}
