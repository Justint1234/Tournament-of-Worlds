namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerlabel = new System.Windows.Forms.Label();
            this.teamOneScoreText = new System.Windows.Forms.TextBox();
            this.tournamentNameValue = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.torunamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.torunamentPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prizeListLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerlabel.Location = new System.Drawing.Point(12, 9);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(498, 68);
            this.headerlabel.TabIndex = 1;
            this.headerlabel.Text = "Create Tournament ";
            // 
            // teamOneScoreText
            // 
            this.teamOneScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreText.Location = new System.Drawing.Point(24, 118);
            this.teamOneScoreText.Name = "teamOneScoreText";
            this.teamOneScoreText.Size = new System.Drawing.Size(274, 40);
            this.teamOneScoreText.TabIndex = 10;
            this.teamOneScoreText.TextChanged += new System.EventHandler(this.teamOneScoreText_TextChanged);
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.AutoSize = true;
            this.tournamentNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentNameValue.Location = new System.Drawing.Point(29, 77);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(189, 25);
            this.tournamentNameValue.TabIndex = 9;
            this.tournamentNameValue.Text = "Tournament Name";
            this.tournamentNameValue.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeValue.Location = new System.Drawing.Point(155, 191);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(143, 40);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EntryFeeLabel.Location = new System.Drawing.Point(19, 206);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(105, 25);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(24, 300);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(274, 39);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamLabel.Location = new System.Drawing.Point(17, 263);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(208, 41);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team ";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(222, 284);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(66, 13);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New ";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Teal;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTeamButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(82, 355);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(165, 41);
            this.addTeamButton.TabIndex = 17;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Prize";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // torunamentPlayerListBox
            // 
            this.torunamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.torunamentPlayerListBox.FormattingEnabled = true;
            this.torunamentPlayerListBox.Location = new System.Drawing.Point(358, 105);
            this.torunamentPlayerListBox.Name = "torunamentPlayerListBox";
            this.torunamentPlayerListBox.Size = new System.Drawing.Size(241, 106);
            this.torunamentPlayerListBox.TabIndex = 19;
            // 
            // torunamentPlayersLabel
            // 
            this.torunamentPlayersLabel.AutoSize = true;
            this.torunamentPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torunamentPlayersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.torunamentPlayersLabel.Location = new System.Drawing.Point(353, 77);
            this.torunamentPlayersLabel.Name = "torunamentPlayersLabel";
            this.torunamentPlayersLabel.Size = new System.Drawing.Size(155, 25);
            this.torunamentPlayersLabel.TabIndex = 20;
            this.torunamentPlayersLabel.Text = "Teams/Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            this.DeleteSelectedPlayersButton.BackColor = System.Drawing.Color.LawnGreen;
            this.DeleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSelectedPlayersButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedPlayersButton.Location = new System.Drawing.Point(635, 105);
            this.DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            this.DeleteSelectedPlayersButton.Size = new System.Drawing.Size(114, 84);
            this.DeleteSelectedPlayersButton.TabIndex = 21;
            this.DeleteSelectedPlayersButton.Text = "Delete Selected";
            this.DeleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(635, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 73);
            this.button2.TabIndex = 24;
            this.button2.Text = "Delete Selected";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // prizeListLabel
            // 
            this.prizeListLabel.AutoSize = true;
            this.prizeListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeListLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prizeListLabel.Location = new System.Drawing.Point(353, 262);
            this.prizeListLabel.Name = "prizeListLabel";
            this.prizeListLabel.Size = new System.Drawing.Size(155, 25);
            this.prizeListLabel.TabIndex = 23;
            this.prizeListLabel.Text = "Teams/Players";
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.Location = new System.Drawing.Point(358, 290);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(241, 106);
            this.prizeListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Teal;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTournamentButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.Location = new System.Drawing.Point(213, 547);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(271, 78);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 762);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prizeListLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.DeleteSelectedPlayersButton);
            this.Controls.Add(this.torunamentPlayersLabel);
            this.Controls.Add(this.torunamentPlayerListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.teamOneScoreText);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.headerlabel);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.TextBox teamOneScoreText;
        private System.Windows.Forms.Label tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox torunamentPlayerListBox;
        private System.Windows.Forms.Label torunamentPlayersLabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label prizeListLabel;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}