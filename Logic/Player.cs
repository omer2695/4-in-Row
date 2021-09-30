namespace Logic
{
    public class Player
    {
        private readonly bool r_IsComputer;
        private readonly char r_Sign;
        private int m_Score;

        public Player(bool i_IsComputer, char i_Sign)
        {
            this.r_IsComputer = i_IsComputer;
            this.m_Score = 0;
            this.r_Sign = i_Sign;
        }

        public bool IsComputer
        {
            get { return r_IsComputer; }
        }

        public int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }

        public char Sign
        {
            get { return r_Sign; }
        }

        public override string ToString()
        {
            if(r_Sign == 'X')
            {
                return "Player 1";
            }
            else
            {
                if(IsComputer == true)
                {
                    return "Computer";
                }

                return "Player 2";
            }
        }
    }
}
