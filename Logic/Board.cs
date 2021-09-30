using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Board
    {
        private char[,] m_GameBoard;
        public readonly int r_Rows;
        public readonly int r_Cols;

        public Board(int i_Rows, int i_Cols)
        {
            r_Cols = i_Cols;
            r_Rows = i_Rows;
            InitializeGameBoard(i_Rows, i_Cols);
        }

        public char[,] GameBoard
        {
            get { return m_GameBoard; }
            set { m_GameBoard = value; }
        }

        public int Rows
        {
            get { return r_Rows; }
        }

        public int Cols
        {
            get { return r_Cols; }
        }

        private void InitializeGameBoard(int i_Rows, int i_Cols)
        {
            m_GameBoard = new char[i_Rows, i_Cols];
            for (int i = 0; i < i_Rows; i++)
            {
                for (int j = 0; j < i_Cols; j++)
                {
                    m_GameBoard[i, j] = ' ';
                }
            }
        }
    }
}
