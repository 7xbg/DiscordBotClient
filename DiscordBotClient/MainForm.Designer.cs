namespace DiscordBotClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serverList = new System.Windows.Forms.ListBox();
            this.selectedServerLabel = new System.Windows.Forms.Label();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setChatBoxZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setWindowDimensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBotStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBotWatchingStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setBotStatusOtherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBotNicknameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botGuildInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(11, 51);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(199, 394);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // selectedServerLabel
            // 
            this.selectedServerLabel.AutoSize = true;
            this.selectedServerLabel.Location = new System.Drawing.Point(11, 35);
            this.selectedServerLabel.Name = "selectedServerLabel";
            this.selectedServerLabel.Size = new System.Drawing.Size(46, 13);
            this.selectedServerLabel.TabIndex = 1;
            this.selectedServerLabel.Text = "Servers:";
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(221, 51);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(598, 395);
            this.chatBox.TabIndex = 2;
            this.chatBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chat:";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(221, 449);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(517, 20);
            this.messageBox.TabIndex = 4;
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(743, 449);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(11, 451);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(199, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miscToolStripMenuItem,
            this.botToolStripMenuItem,
            this.guildToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setChatBoxZoomToolStripMenuItem,
            this.setWindowDimensionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // setChatBoxZoomToolStripMenuItem
            // 
            this.setChatBoxZoomToolStripMenuItem.Name = "setChatBoxZoomToolStripMenuItem";
            this.setChatBoxZoomToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setChatBoxZoomToolStripMenuItem.Text = "Set Chat Box Zoom";
            this.setChatBoxZoomToolStripMenuItem.Click += new System.EventHandler(this.setChatBoxZoomToolStripMenuItem_Click);
            // 
            // setWindowDimensionsToolStripMenuItem
            // 
            this.setWindowDimensionsToolStripMenuItem.Name = "setWindowDimensionsToolStripMenuItem";
            this.setWindowDimensionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setWindowDimensionsToolStripMenuItem.Text = "Set Window Dimensions";
            this.setWindowDimensionsToolStripMenuItem.Click += new System.EventHandler(this.setWindowDimensionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // botToolStripMenuItem
            // 
            this.botToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBotStatusToolStripMenuItem,
            this.setBotWatchingStatusToolStripMenuItem1,
            this.setBotStatusOtherToolStripMenuItem1,
            this.setBotNicknameToolStripMenuItem1,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator2,
            this.secretToolStripMenuItem});
            this.botToolStripMenuItem.Name = "botToolStripMenuItem";
            this.botToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.botToolStripMenuItem.Text = "Bot";
            // 
            // setBotStatusToolStripMenuItem
            // 
            this.setBotStatusToolStripMenuItem.Name = "setBotStatusToolStripMenuItem";
            this.setBotStatusToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.setBotStatusToolStripMenuItem.Text = "Set Bot Status";
            this.setBotStatusToolStripMenuItem.Click += new System.EventHandler(this.setBotStatusToolStripMenuItem_Click);
            // 
            // setBotWatchingStatusToolStripMenuItem1
            // 
            this.setBotWatchingStatusToolStripMenuItem1.Name = "setBotWatchingStatusToolStripMenuItem1";
            this.setBotWatchingStatusToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.setBotWatchingStatusToolStripMenuItem1.Text = "Set Bot Watching Status";
            this.setBotWatchingStatusToolStripMenuItem1.Click += new System.EventHandler(this.setBotWatchingStatusToolStripMenuItem1_Click);
            // 
            // setBotStatusOtherToolStripMenuItem1
            // 
            this.setBotStatusOtherToolStripMenuItem1.Name = "setBotStatusOtherToolStripMenuItem1";
            this.setBotStatusOtherToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.setBotStatusOtherToolStripMenuItem1.Text = "Set Bot Status Other";
            this.setBotStatusOtherToolStripMenuItem1.Click += new System.EventHandler(this.setBotStatusOtherToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // setBotNicknameToolStripMenuItem1
            // 
            this.setBotNicknameToolStripMenuItem1.Name = "setBotNicknameToolStripMenuItem1";
            this.setBotNicknameToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.setBotNicknameToolStripMenuItem1.Text = "Set Bot Nickname";
            this.setBotNicknameToolStripMenuItem1.Click += new System.EventHandler(this.setBotNicknameToolStripMenuItem1_Click);
            // 
            // secretToolStripMenuItem
            // 
            this.secretToolStripMenuItem.Name = "secretToolStripMenuItem";
            this.secretToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.secretToolStripMenuItem.Text = "Secret...";
            this.secretToolStripMenuItem.Click += new System.EventHandler(this.secretToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(752, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Spammer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // guildToolStripMenuItem
            // 
            this.guildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.botGuildInfoToolStripMenuItem});
            this.guildToolStripMenuItem.Name = "guildToolStripMenuItem";
            this.guildToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.guildToolStripMenuItem.Text = "Guild";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click_1);
            // 
            // botGuildInfoToolStripMenuItem
            // 
            this.botGuildInfoToolStripMenuItem.Name = "botGuildInfoToolStripMenuItem";
            this.botGuildInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.botGuildInfoToolStripMenuItem.Text = "Bot Guild Info";
            this.botGuildInfoToolStripMenuItem.Click += new System.EventHandler(this.botGuildInfoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.selectedServerLabel);
            this.Controls.Add(this.serverList);
            this.Controls.Add(this.menuStrip1);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "thtc main - w = 850 | h = 520";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Label selectedServerLabel;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setChatBoxZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setWindowDimensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBotStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBotWatchingStatusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setBotStatusOtherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setBotNicknameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem guildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botGuildInfoToolStripMenuItem;
    }
}