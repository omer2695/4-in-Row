namespace Ex05.UI
{
    public partial class GameSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayersText = new System.Windows.Forms.Label();
            this.PlayerOneText = new System.Windows.Forms.Label();
            this.PlayerTwoCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayerOneTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoTextBox = new System.Windows.Forms.TextBox();
            this.BoardSizeText = new System.Windows.Forms.Label();
            this.RowsText = new System.Windows.Forms.Label();
            this.ColsText = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.RowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersText
            // 
            this.PlayersText.AutoSize = true;
            this.PlayersText.Location = new System.Drawing.Point(10, 10);
            this.PlayersText.Name = "PlayersText";
            this.PlayersText.Size = new System.Drawing.Size(59, 17);
            this.PlayersText.TabIndex = 0;
            this.PlayersText.Text = "Players:";
            this.PlayersText.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerOneText
            // 
            this.PlayerOneText.AutoSize = true;
            this.PlayerOneText.Location = new System.Drawing.Point(31, 42);
            this.PlayerOneText.Name = "PlayerOneText";
            this.PlayerOneText.Size = new System.Drawing.Size(64, 17);
            this.PlayerOneText.TabIndex = 1;
            this.PlayerOneText.Text = "Player 1:";
            // 
            // PlayerTwoCheckBox
            // 
            this.PlayerTwoCheckBox.AutoSize = true;
            this.PlayerTwoCheckBox.Location = new System.Drawing.Point(13, 77);
            this.PlayerTwoCheckBox.Name = "PlayerTwoCheckBox";
            this.PlayerTwoCheckBox.Size = new System.Drawing.Size(86, 21);
            this.PlayerTwoCheckBox.TabIndex = 2;
            this.PlayerTwoCheckBox.Text = "Player 2:";
            this.PlayerTwoCheckBox.UseVisualStyleBackColor = true;
            this.PlayerTwoCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PlayerOneTextBox
            // 
            this.PlayerOneTextBox.Location = new System.Drawing.Point(129, 42);
            this.PlayerOneTextBox.Name = "PlayerOneTextBox";
            this.PlayerOneTextBox.Size = new System.Drawing.Size(193, 22);
            this.PlayerOneTextBox.TabIndex = 3;
            // 
            // PlayerTwoTextBox
            // 
            this.PlayerTwoTextBox.Enabled = false;
            this.PlayerTwoTextBox.Location = new System.Drawing.Point(129, 77);
            this.PlayerTwoTextBox.Name = "PlayerTwoTextBox";
            this.PlayerTwoTextBox.Size = new System.Drawing.Size(193, 22);
            this.PlayerTwoTextBox.TabIndex = 4;
            // 
            // BoardSizeText
            // 
            this.BoardSizeText.AutoSize = true;
            this.BoardSizeText.Location = new System.Drawing.Point(10, 114);
            this.BoardSizeText.Name = "BoardSizeText";
            this.BoardSizeText.Size = new System.Drawing.Size(81, 17);
            this.BoardSizeText.TabIndex = 5;
            this.BoardSizeText.Text = "Board Size:";
            this.BoardSizeText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RowsText
            // 
            this.RowsText.AutoSize = true;
            this.RowsText.Location = new System.Drawing.Point(31, 144);
            this.RowsText.Name = "RowsText";
            this.RowsText.Size = new System.Drawing.Size(46, 17);
            this.RowsText.TabIndex = 6;
            this.RowsText.Text = "Rows:";
            // 
            // ColsText
            // 
            this.ColsText.AutoSize = true;
            this.ColsText.Location = new System.Drawing.Point(231, 144);
            this.ColsText.Name = "ColsText";
            this.ColsText.Size = new System.Drawing.Size(39, 17);
            this.ColsText.TabIndex = 7;
            this.ColsText.Text = "Cols:";
            this.ColsText.Click += new System.EventHandler(this.ColsText_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 192);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(309, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // RowsNumericUpDown
            // 
            this.RowsNumericUpDown.Location = new System.Drawing.Point(84, 142);
            this.RowsNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.RowsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.RowsNumericUpDown.Name = "RowsNumericUpDown";
            this.RowsNumericUpDown.Size = new System.Drawing.Size(36, 22);
            this.RowsNumericUpDown.TabIndex = 9;
            this.RowsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ColsNumericUpDown
            // 
            this.ColsNumericUpDown.Location = new System.Drawing.Point(286, 142);
            this.ColsNumericUpDown.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ColsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.ColsNumericUpDown.Name = "ColsNumericUpDown";
            this.ColsNumericUpDown.Size = new System.Drawing.Size(36, 22);
            this.ColsNumericUpDown.TabIndex = 10;
            this.ColsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 240);
            this.Controls.Add(this.ColsNumericUpDown);
            this.Controls.Add(this.RowsNumericUpDown);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ColsText);
            this.Controls.Add(this.RowsText);
            this.Controls.Add(this.BoardSizeText);
            this.Controls.Add(this.PlayerTwoTextBox);
            this.Controls.Add(this.PlayerOneTextBox);
            this.Controls.Add(this.PlayerTwoCheckBox);
            this.Controls.Add(this.PlayerOneText);
            this.Controls.Add(this.PlayersText);
            this.Name = "GameSettingsForm";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayersText;
        private System.Windows.Forms.Label PlayerOneText;
        private System.Windows.Forms.CheckBox PlayerTwoCheckBox;
        private System.Windows.Forms.TextBox PlayerOneTextBox;
        private System.Windows.Forms.TextBox PlayerTwoTextBox;
        private System.Windows.Forms.Label BoardSizeText;
        private System.Windows.Forms.Label RowsText;
        private System.Windows.Forms.Label ColsText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown RowsNumericUpDown;
        private System.Windows.Forms.NumericUpDown ColsNumericUpDown;
    }
}