using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Ex05.UI
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartButton.Click += new EventHandler(StartButton_Click);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(PlayerTwoTextBox.Enabled, (int)RowsNumericUpDown.Value, (int)ColsNumericUpDown.Value);
            GameplayForm gameplayForm = new GameplayForm(game);
            this.Hide();
            gameplayForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PlayerTwoTextBox.Enabled)
            {
                PlayerTwoTextBox.Enabled = false;
            }
            else
            {
                PlayerTwoTextBox.Enabled = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void ColsText_Click(object sender, EventArgs e)
        {
        }
    }
}
