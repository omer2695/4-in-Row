using System;

namespace Logic
{
    public class Game
    {
        private Board m_Board;
        private Player m_Player1;
        private Player m_Player2;
        private Player m_CurrentPlayer;
        private int m_Rows;
        private int m_Cols;

        public Game(bool i_Player2, int i_Rows, int i_Cols)
        {
            m_Rows = i_Rows;
            m_Cols = i_Cols;
            this.m_Board = new Board(m_Rows, m_Cols);
            this.m_Player1 = new Player(false, 'X');
            if(i_Player2 == false)
            {
                m_Player2 = new Player(true, 'O');
            }
            else
            {
                m_Player2 = new Player(false, 'O');
            }

            m_CurrentPlayer = m_Player1;
        }

        public bool BoardIsFull(Board i_Board)
        {
            bool isFull = true;
            for (int i = 0; i < i_Board.Rows; i++)
            {
                for (int j = 0; j < i_Board.Cols; j++)
                {
                    if (i_Board.GameBoard[i, j] == ' ')
                    {
                        isFull = false;
                        break;
                    }
                }
            }

            return isFull;
        }

        private bool FourInARow(Board i_Board, Player i_Player)
        {
            int counter = 0;

            for (int i = 0; i < i_Board.Rows; i++)
            {
                for (int j = 0; j < i_Board.Cols; j++)
                {
                    if (i_Board.GameBoard[i, j] == i_Player.Sign)
                    {
                        counter++;
                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < i_Board.Cols; i++)
            {
                for (int j = 0; j < i_Board.Rows; j++)
                {
                    if (i_Board.GameBoard[j, i] == i_Player.Sign)
                    {
                        counter++;
                        if (counter == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < i_Board.Cols - 3; i++)
            {
                for (int j = 0; j < i_Board.Rows - 3; j++)
                {
                    if (i_Board.GameBoard[j, i] == i_Player.Sign && i_Board.GameBoard[j + 1, i + 1] == i_Player.Sign && i_Board.GameBoard[j + 2, i + 2] == i_Player.Sign && i_Board.GameBoard[j + 3, i + 3] == i_Player.Sign)
                    {
                        return true;
                    }
                }
            }

            for (int i = 0; i < i_Board.Cols - 3; i++)
            {
                for (int j = 3; j < i_Board.Rows; j++)
                {
                    if (i_Board.GameBoard[j, i] == i_Player.Sign && i_Board.GameBoard[j - 1, i + 1] == i_Player.Sign && i_Board.GameBoard[j - 2, i + 2] == i_Player.Sign && i_Board.GameBoard[j - 3, i + 3] == i_Player.Sign)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int Rows
        {
            get { return m_Rows; }
        }

        public int Cols
        {
            get { return m_Cols; }
        }

        public Player CurrentPlayer
        {
            get { return m_CurrentPlayer; }
        }

        public Board GameBoard
        {
            get { return m_Board; }
        }

        public void RestartGame()
        {
            this.m_Board = new Board(m_Rows, m_Cols);
            this.m_CurrentPlayer = m_Player1;
        }

        public Player Player2
        {
            get { return m_Player2; }
        }

        public Player Player1
        {
            get { return m_Player1; }
        }

        public eStatusCodes UpdateBoardAndReturnCode(int i_SelectedColumn)
        {
            Board newBoard = m_Board;
            for (int i = 1; i < m_Board.Rows; i++)
            {
                if (m_Board.GameBoard[i, i_SelectedColumn] != ' ')
                {
                    newBoard.GameBoard[i - 1, i_SelectedColumn] = m_CurrentPlayer.Sign;
                    break;
                }

                if (i == m_Board.Rows - 1)
                {
                    newBoard.GameBoard[i, i_SelectedColumn] = m_CurrentPlayer.Sign;
                }
            }

            if (BoardIsFull(m_Board))
            {
                return eStatusCodes.Tie;
            }
            else if (FourInARow(m_Board, m_CurrentPlayer))
            {
                return eStatusCodes.PlayerWon;
            }
            else
            {
                SwitchPlayer();
                return eStatusCodes.ContinueGame;
            }
        }

        public eStatusCodes RandomlyPickAColumn()
        {
            Random rnd = new Random();
            int randomColumn = rnd.Next(0, m_Cols);
            while(m_Board.GameBoard[0, randomColumn] != ' ')
            {
                randomColumn = rnd.Next(0, m_Cols);
            }

            eStatusCodes status = UpdateBoardAndReturnCode(randomColumn);

            return status;
        }

        public void SwitchPlayer()
        {
            if(m_CurrentPlayer == m_Player1)
            {
                m_CurrentPlayer = m_Player2;
            }
            else
            {
                m_CurrentPlayer = m_Player1;
            }
        }
    }
}
