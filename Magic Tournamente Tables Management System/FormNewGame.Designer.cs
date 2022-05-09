namespace Magic_Tournamente_Tables_Management_System
{
    partial class FormNewGame
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
            this.buttonStartNewGame = new System.Windows.Forms.Button();
            this.labelNewGameTotalRounds = new System.Windows.Forms.Label();
            this.numericUpDownRounds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTables = new System.Windows.Forms.NumericUpDown();
            this.labelNewGameTotalTables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTables)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartNewGame
            // 
            this.buttonStartNewGame.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonStartNewGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStartNewGame.Location = new System.Drawing.Point(0, 152);
            this.buttonStartNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartNewGame.Name = "buttonStartNewGame";
            this.buttonStartNewGame.Size = new System.Drawing.Size(359, 63);
            this.buttonStartNewGame.TabIndex = 0;
            this.buttonStartNewGame.Text = "START";
            this.buttonStartNewGame.UseVisualStyleBackColor = false;
            this.buttonStartNewGame.Click += new System.EventHandler(this.buttonStartNewGame_Click);
            // 
            // labelNewGameTotalRounds
            // 
            this.labelNewGameTotalRounds.AutoSize = true;
            this.labelNewGameTotalRounds.Location = new System.Drawing.Point(43, 63);
            this.labelNewGameTotalRounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewGameTotalRounds.Name = "labelNewGameTotalRounds";
            this.labelNewGameTotalRounds.Size = new System.Drawing.Size(127, 21);
            this.labelNewGameTotalRounds.TabIndex = 1;
            this.labelNewGameTotalRounds.Text = "Total Rounds:";
            this.labelNewGameTotalRounds.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownRounds
            // 
            this.numericUpDownRounds.Location = new System.Drawing.Point(191, 63);
            this.numericUpDownRounds.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRounds.Name = "numericUpDownRounds";
            this.numericUpDownRounds.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownRounds.TabIndex = 2;
            this.numericUpDownRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRounds.ValueChanged += new System.EventHandler(this.numericUpDownRounds_ValueChanged);
            // 
            // numericUpDownTables
            // 
            this.numericUpDownTables.Location = new System.Drawing.Point(191, 99);
            this.numericUpDownTables.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericUpDownTables.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTables.Name = "numericUpDownTables";
            this.numericUpDownTables.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownTables.TabIndex = 4;
            this.numericUpDownTables.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTables.Visible = false;
            // 
            // labelNewGameTotalTables
            // 
            this.labelNewGameTotalTables.AutoSize = true;
            this.labelNewGameTotalTables.Location = new System.Drawing.Point(43, 104);
            this.labelNewGameTotalTables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewGameTotalTables.Name = "labelNewGameTotalTables";
            this.labelNewGameTotalTables.Size = new System.Drawing.Size(127, 21);
            this.labelNewGameTotalTables.TabIndex = 3;
            this.labelNewGameTotalTables.Text = "Total Tables:";
            this.labelNewGameTotalTables.Visible = false;
            this.labelNewGameTotalTables.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 215);
            this.Controls.Add(this.numericUpDownTables);
            this.Controls.Add(this.labelNewGameTotalTables);
            this.Controls.Add(this.numericUpDownRounds);
            this.Controls.Add(this.labelNewGameTotalRounds);
            this.Controls.Add(this.buttonStartNewGame);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.FormNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStartNewGame;
        private Label labelNewGameTotalRounds;
        private NumericUpDown numericUpDownRounds;
        private NumericUpDown numericUpDownTables;
        private Label labelNewGameTotalTables;
    }
}