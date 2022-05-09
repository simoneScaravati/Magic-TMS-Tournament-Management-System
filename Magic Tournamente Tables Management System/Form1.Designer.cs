﻿namespace Magic_Tournamente_Tables_Management_System
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.textBoxAddPlayer = new System.Windows.Forms.TextBox();
            this.buttonRemovePlayer = new System.Windows.Forms.Button();
            this.buttonRemoveTable = new System.Windows.Forms.Button();
            this.textBoxAddTable = new System.Windows.Forms.TextBox();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonEditTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlayerAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonRound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PairWon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BuyWon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelRound = new System.Windows.Forms.Label();
            this.labelCurrentRound = new System.Windows.Forms.Label();
            this.buttonNextRound = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameTODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelScore = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonOnBigTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WonOnSmallTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.Score,
            this.WonOnBigTable,
            this.WonOnSmallTable,
            this.Buy});
            this.dataGridView.Location = new System.Drawing.Point(13, 534);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1176, 260);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddPlayer.Location = new System.Drawing.Point(13, 335);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(226, 35);
            this.buttonAddPlayer.TabIndex = 6;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = false;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // textBoxAddPlayer
            // 
            this.textBoxAddPlayer.Location = new System.Drawing.Point(12, 384);
            this.textBoxAddPlayer.Name = "textBoxAddPlayer";
            this.textBoxAddPlayer.PlaceholderText = "(default PlayerXXX)";
            this.textBoxAddPlayer.Size = new System.Drawing.Size(227, 25);
            this.textBoxAddPlayer.TabIndex = 7;
            this.textBoxAddPlayer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.textBoxAddTable.Location = new System.Drawing.Point(265, 384);
            this.textBoxAddTable.Name = "textBoxAddTable";
            this.textBoxAddTable.PlaceholderText = "(default TableXXX)";
            this.textBoxAddTable.Size = new System.Drawing.Size(230, 25);
            this.textBoxAddTable.TabIndex = 10;
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddTable.Location = new System.Drawing.Point(265, 335);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(228, 35);
            this.buttonAddTable.TabIndex = 9;
            this.buttonAddTable.Text = "Add Table";
            this.buttonAddTable.UseVisualStyleBackColor = false;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditPlayer.Location = new System.Drawing.Point(12, 415);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(73, 63);
            this.buttonEditPlayer.TabIndex = 12;
            this.buttonEditPlayer.Text = "Edit Player";
            this.buttonEditPlayer.UseVisualStyleBackColor = false;
            // 
            // buttonEditTable
            // 
            this.buttonEditTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditTable.Location = new System.Drawing.Point(265, 415);
            this.buttonEditTable.Name = "buttonEditTable";
            this.buttonEditTable.Size = new System.Drawing.Size(92, 63);
            this.buttonEditTable.TabIndex = 13;
            this.buttonEditTable.Text = "Edit Table";
            this.buttonEditTable.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerAssign,
            this.TableAssign,
            this.WonRound,
            this.PairWon,
            this.BuyWon});
            this.dataGridView1.Location = new System.Drawing.Point(586, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(603, 395);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.WonRound.HeaderText = "Won Round";
            this.WonRound.Name = "WonRound";
            this.WonRound.ReadOnly = true;
            // 
            // PairWon
            // 
            this.PairWon.HeaderText = "Pair";
            this.PairWon.Name = "PairWon";
            this.PairWon.ReadOnly = true;
            // 
            // BuyWon
            // 
            this.BuyWon.HeaderText = "Buy Won";
            this.BuyWon.Name = "BuyWon";
            this.BuyWon.ReadOnly = true;
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.labelCurrentRound.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentRound.Location = new System.Drawing.Point(772, 41);
            this.labelCurrentRound.Name = "labelCurrentRound";
            this.labelCurrentRound.Size = new System.Drawing.Size(48, 28);
            this.labelCurrentRound.TabIndex = 17;
            this.labelCurrentRound.Text = "0/0";
            // 
            // buttonNextRound
            // 
            this.buttonNextRound.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.saveTODOToolStripMenuItem,
            this.openGameTODOToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveTODOToolStripMenuItem
            // 
            this.saveTODOToolStripMenuItem.Name = "saveTODOToolStripMenuItem";
            this.saveTODOToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveTODOToolStripMenuItem.Text = "Save Game (TODO)";
            this.saveTODOToolStripMenuItem.Click += new System.EventHandler(this.saveTODOToolStripMenuItem_Click);
            // 
            // openGameTODOToolStripMenuItem
            // 
            this.openGameTODOToolStripMenuItem.Name = "openGameTODOToolStripMenuItem";
            this.openGameTODOToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openGameTODOToolStripMenuItem.Text = "Open Game (TODO)";
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
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            this.infoToolStripMenuItem1.Click += new System.EventHandler(this.infoToolStripMenuItem1_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(552, 511);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(72, 20);
            this.labelScore.TabIndex = 21;
            this.labelScore.Text = "Ranking";
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditTable);
            this.Controls.Add(this.buttonEditPlayer);
            this.Controls.Add(this.buttonRemoveTable);
            this.Controls.Add(this.textBoxAddTable);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonRemovePlayer);
            this.Controls.Add(this.textBoxAddPlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.dataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DataGridView dataGridView;
        private Button buttonAddPlayer;
        private TextBox textBoxAddPlayer;
        private Button buttonRemovePlayer;
        private Button buttonRemoveTable;
        private TextBox textBoxAddTable;
        private Button buttonAddTable;
        private Button buttonEditPlayer;
        private Button buttonEditTable;
        private DataGridView dataGridView1;
        private Label labelRound;
        private Label labelCurrentRound;
        private Button buttonNextRound;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem saveTODOToolStripMenuItem;
        private ToolStripMenuItem openGameTODOToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem1;
        private DataGridViewTextBoxColumn PlayerAssign;
        private DataGridViewTextBoxColumn TableAssign;
        private DataGridViewCheckBoxColumn WonRound;
        private DataGridViewCheckBoxColumn PairWon;
        private DataGridViewCheckBoxColumn BuyWon;
        private Label labelScore;
        private DataGridViewTextBoxColumn Player;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn WonOnBigTable;
        private DataGridViewTextBoxColumn WonOnSmallTable;
        private DataGridViewTextBoxColumn Buy;
    }
}