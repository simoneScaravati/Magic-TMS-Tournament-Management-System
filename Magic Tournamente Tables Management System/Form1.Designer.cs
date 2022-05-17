namespace Magic_Tournamente_Tables_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelTables = new System.Windows.Forms.Label();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonOnBigTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonOnSmallTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.textBoxAddPlayer = new System.Windows.Forms.TextBox();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.buttonRemoveTable = new System.Windows.Forms.Button();
            this.textBoxAddTable = new System.Windows.Forms.TextBox();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonRemoveAllPlayer = new System.Windows.Forms.Button();
            this.buttonRemoveAllTable = new System.Windows.Forms.Button();
            this.dataGridViewMatching = new System.Windows.Forms.DataGridView();
            this.PlayerAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonRound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TieWon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelRound = new System.Windows.Forms.Label();
            this.labelCurrentRound = new System.Windows.Forms.Label();
            this.buttonNextRound = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatching)).BeginInit();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.HorizontalScrollbar = true;
            this.listBoxPlayers.ItemHeight = 21;
            this.listBoxPlayers.Location = new System.Drawing.Point(13, 50);
            this.listBoxPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(226, 277);
            this.listBoxPlayers.TabIndex = 1;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayers.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlayers.Location = new System.Drawing.Point(13, 25);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(72, 20);
            this.labelPlayers.TabIndex = 2;
            this.labelPlayers.Text = "Players";
            this.labelPlayers.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.BackColor = System.Drawing.Color.Transparent;
            this.labelTables.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTables.Location = new System.Drawing.Point(265, 25);
            this.labelTables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(63, 20);
            this.labelTables.TabIndex = 4;
            this.labelTables.Text = "Tables";
            // 
            // listBoxTables
            // 
            this.listBoxTables.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.HorizontalScrollbar = true;
            this.listBoxTables.ItemHeight = 21;
            this.listBoxTables.Location = new System.Drawing.Point(265, 50);
            this.listBoxTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(230, 277);
            this.listBoxTables.TabIndex = 3;
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.AllowUserToAddRows = false;
            this.dataGridViewRanking.AllowUserToDeleteRows = false;
            this.dataGridViewRanking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.Score,
            this.WonOnBigTable,
            this.WonOnSmallTable,
            this.Buy});
            this.dataGridViewRanking.Location = new System.Drawing.Point(13, 534);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.ReadOnly = true;
            this.dataGridViewRanking.RowTemplate.Height = 25;
            this.dataGridViewRanking.Size = new System.Drawing.Size(1176, 260);
            this.dataGridViewRanking.TabIndex = 5;
            this.dataGridViewRanking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Player
            // 
            this.Player.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // WonOnBigTable
            // 
            this.WonOnBigTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WonOnBigTable.HeaderText = "Big Tables";
            this.WonOnBigTable.Name = "WonOnBigTable";
            this.WonOnBigTable.ReadOnly = true;
            // 
            // WonOnSmallTable
            // 
            this.WonOnSmallTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WonOnSmallTable.HeaderText = "Small tables";
            this.WonOnSmallTable.Name = "WonOnSmallTable";
            this.WonOnSmallTable.ReadOnly = true;
            // 
            // Buy
            // 
            this.Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Buy.HeaderText = "Buy";
            this.Buy.Name = "Buy";
            this.Buy.ReadOnly = true;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddPlayer.Location = new System.Drawing.Point(13, 374);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(226, 35);
            this.buttonAddPlayer.TabIndex = 6;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = false;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // textBoxAddPlayer
            // 
            this.textBoxAddPlayer.Location = new System.Drawing.Point(12, 335);
            this.textBoxAddPlayer.Name = "textBoxAddPlayer";
            this.textBoxAddPlayer.PlaceholderText = "PlayerXXX";
            this.textBoxAddPlayer.Size = new System.Drawing.Size(227, 25);
            this.textBoxAddPlayer.TabIndex = 7;
            this.textBoxAddPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAddPlayer_KeyDown);
            this.textBoxAddPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddPlayer_KeyPress);
            this.textBoxAddPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAddPlayer_KeyUp);
            // 
            // buttonRemovePlayer
            // 
            this.buttonRemovePlayer.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemovePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemovePlayer.FlatAppearance.BorderSize = 10;
            this.buttonRemovePlayer.Location = new System.Drawing.Point(91, 415);
            this.buttonRemovePlayer.Name = "buttonRemovePlayer";
            this.buttonRemovePlayer.Size = new System.Drawing.Size(148, 63);
            this.buttonRemovePlayer.TabIndex = 8;
            this.buttonRemovePlayer.Text = "Remove Player";
            this.buttonRemovePlayer.UseVisualStyleBackColor = false;
            this.buttonRemovePlayer.Click += new System.EventHandler(this.buttonRemovePlayer_Click);
            // 
            // buttonRemoveTable
            // 
            this.buttonRemoveTable.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemoveTable.Location = new System.Drawing.Point(363, 413);
            this.buttonRemoveTable.Name = "buttonRemoveTable";
            this.buttonRemoveTable.Size = new System.Drawing.Size(132, 65);
            this.buttonRemoveTable.TabIndex = 11;
            this.buttonRemoveTable.Text = "Remove Table";
            this.buttonRemoveTable.UseVisualStyleBackColor = false;
            this.buttonRemoveTable.Click += new System.EventHandler(this.buttonRemoveTable_Click);
            // 
            // textBoxAddTable
            // 
            this.textBoxAddTable.Location = new System.Drawing.Point(265, 335);
            this.textBoxAddTable.Name = "textBoxAddTable";
            this.textBoxAddTable.PlaceholderText = "TableXXX";
            this.textBoxAddTable.Size = new System.Drawing.Size(230, 25);
            this.textBoxAddTable.TabIndex = 10;
            this.textBoxAddTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAddTable_KeyDown);
            this.textBoxAddTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddTable_KeyPress);
            this.textBoxAddTable.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAddTable_KeyUp);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddTable.Location = new System.Drawing.Point(265, 374);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(228, 35);
            this.buttonAddTable.TabIndex = 9;
            this.buttonAddTable.Text = "Add Table";
            this.buttonAddTable.UseVisualStyleBackColor = false;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonRemoveAllPlayer
            // 
            this.buttonRemoveAllPlayer.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemoveAllPlayer.Location = new System.Drawing.Point(12, 415);
            this.buttonRemoveAllPlayer.Name = "buttonRemoveAllPlayer";
            this.buttonRemoveAllPlayer.Size = new System.Drawing.Size(73, 63);
            this.buttonRemoveAllPlayer.TabIndex = 12;
            this.buttonRemoveAllPlayer.Text = "Remove All";
            this.buttonRemoveAllPlayer.UseVisualStyleBackColor = false;
            this.buttonRemoveAllPlayer.Click += new System.EventHandler(this.buttonRemoveAllPlayer_Click);
            // 
            // buttonRemoveAllTable
            // 
            this.buttonRemoveAllTable.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemoveAllTable.Location = new System.Drawing.Point(265, 415);
            this.buttonRemoveAllTable.Name = "buttonRemoveAllTable";
            this.buttonRemoveAllTable.Size = new System.Drawing.Size(92, 63);
            this.buttonRemoveAllTable.TabIndex = 13;
            this.buttonRemoveAllTable.Text = "Remove All";
            this.buttonRemoveAllTable.UseVisualStyleBackColor = false;
            this.buttonRemoveAllTable.Click += new System.EventHandler(this.buttonRemoveAllTable_Click);
            // 
            // dataGridViewMatching
            // 
            this.dataGridViewMatching.AllowUserToAddRows = false;
            this.dataGridViewMatching.AllowUserToDeleteRows = false;
            this.dataGridViewMatching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatching.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerAssign,
            this.TableAssign,
            this.WonRound,
            this.TieWon});
            this.dataGridViewMatching.Location = new System.Drawing.Point(586, 83);
            this.dataGridViewMatching.Name = "dataGridViewMatching";
            this.dataGridViewMatching.ReadOnly = true;
            this.dataGridViewMatching.RowTemplate.Height = 25;
            this.dataGridViewMatching.Size = new System.Drawing.Size(603, 395);
            this.dataGridViewMatching.TabIndex = 14;
            this.dataGridViewMatching.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatching_CellContentClick);
            // 
            // PlayerAssign
            // 
            this.PlayerAssign.HeaderText = "Player";
            this.PlayerAssign.Name = "PlayerAssign";
            this.PlayerAssign.ReadOnly = true;
            // 
            // TableAssign
            // 
            this.TableAssign.HeaderText = "Table";
            this.TableAssign.Name = "TableAssign";
            this.TableAssign.ReadOnly = true;
            // 
            // WonRound
            // 
            this.WonRound.FalseValue = "false";
            this.WonRound.HeaderText = "Won Round";
            this.WonRound.Name = "WonRound";
            this.WonRound.ReadOnly = true;
            this.WonRound.TrueValue = "true";
            // 
            // TieWon
            // 
            this.TieWon.FalseValue = "false";
            this.TieWon.HeaderText = "Tie";
            this.TieWon.Name = "TieWon";
            this.TieWon.ReadOnly = true;
            this.TieWon.TrueValue = "true";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.BackColor = System.Drawing.Color.Transparent;
            this.labelRound.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRound.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelRound.Location = new System.Drawing.Point(586, 41);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(180, 28);
            this.labelRound.TabIndex = 16;
            this.labelRound.Text = "CURRENT ROUND:";
            this.labelRound.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCurrentRound
            // 
            this.labelCurrentRound.AutoSize = true;
            this.labelCurrentRound.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentRound.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentRound.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentRound.Location = new System.Drawing.Point(772, 41);
            this.labelCurrentRound.Name = "labelCurrentRound";
            this.labelCurrentRound.Size = new System.Drawing.Size(48, 28);
            this.labelCurrentRound.TabIndex = 17;
            this.labelCurrentRound.Text = "0/0";
            // 
            // buttonNextRound
            // 
            this.buttonNextRound.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextRound.Location = new System.Drawing.Point(848, 36);
            this.buttonNextRound.Name = "buttonNextRound";
            this.buttonNextRound.Size = new System.Drawing.Size(112, 44);
            this.buttonNextRound.TabIndex = 18;
            this.buttonNextRound.Text = "Next Round";
            this.buttonNextRound.UseVisualStyleBackColor = false;
            this.buttonNextRound.Click += new System.EventHandler(this.buttonNextRound_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuBar.Size = new System.Drawing.Size(1201, 24);
            this.menuBar.TabIndex = 20;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadGameToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveToolStripMenuItem.Text = "Save Game";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelScore.Location = new System.Drawing.Point(42, 510);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 21);
            this.labelScore.TabIndex = 21;
            this.labelScore.Text = "Ranking";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 806);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.buttonNextRound);
            this.Controls.Add(this.labelCurrentRound);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.dataGridViewMatching);
            this.Controls.Add(this.buttonRemoveAllTable);
            this.Controls.Add(this.buttonRemoveAllPlayer);
            this.Controls.Add(this.buttonRemoveTable);
            this.Controls.Add(this.textBoxAddTable);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.textBoxAddPlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.dataGridViewRanking);
            this.Controls.Add(this.labelTables);
            this.Controls.Add(this.listBoxTables);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.listBoxPlayers);
            this.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic Tournament Tables Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatching)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBoxPlayers;
        private Label labelPlayers;
        private Label labelTables;
        private ListBox listBoxTables;
        private DataGridView dataGridViewRanking;
        private Button buttonAddPlayer;
        private TextBox textBoxAddPlayer;
        private Button buttonRemovePlayer;
        private Button buttonRemoveTable;
        private TextBox textBoxAddTable;
        private Button buttonAddTable;
        private Button buttonRemoveAllPlayer;
        private Button buttonRemoveAllTable;
        private DataGridView dataGridViewMatching;
        private Label labelRound;
        private Label labelCurrentRound;
        private Button buttonNextRound;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem1;
        private Label labelScore;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn WonOnBigTable;
        private DataGridViewTextBoxColumn WonOnSmallTable;
        private DataGridViewTextBoxColumn Buy;
        private DataGridViewTextBoxColumn PlayerAssign;
        private DataGridViewTextBoxColumn TableAssign;
        private DataGridViewCheckBoxColumn WonRound;
        private DataGridViewCheckBoxColumn TieWon;
    }
}