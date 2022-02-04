namespace DiscordBotClient.ManageUsers
{
    partial class ManageUser
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.LinkLabel();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.createdAtLabel = new System.Windows.Forms.Label();
            this.botLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.permissionsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roleList = new System.Windows.Forms.ListBox();
            this.kickButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(188, 12);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(55, 13);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.TabStop = true;
            this.userIdLabel.Text = "linkLabel1";
            this.userIdLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.userIdLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userIdLabel_LinkClicked);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(146, 34);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(61, 13);
            this.nicknameLabel.TabIndex = 3;
            this.nicknameLabel.Text = "Nickname: ";
            // 
            // createdAtLabel
            // 
            this.createdAtLabel.AutoSize = true;
            this.createdAtLabel.Location = new System.Drawing.Point(146, 57);
            this.createdAtLabel.Name = "createdAtLabel";
            this.createdAtLabel.Size = new System.Drawing.Size(106, 13);
            this.createdAtLabel.TabIndex = 4;
            this.createdAtLabel.Text = "Account Created At: ";
            // 
            // botLabel
            // 
            this.botLabel.AutoSize = true;
            this.botLabel.BackColor = System.Drawing.Color.Lime;
            this.botLabel.Location = new System.Drawing.Point(146, 127);
            this.botLabel.Name = "botLabel";
            this.botLabel.Size = new System.Drawing.Size(43, 13);
            this.botLabel.TabIndex = 5;
            this.botLabel.Text = "Not Bot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Permissions:";
            // 
            // permissionsList
            // 
            this.permissionsList.FormattingEnabled = true;
            this.permissionsList.Location = new System.Drawing.Point(15, 159);
            this.permissionsList.Name = "permissionsList";
            this.permissionsList.Size = new System.Drawing.Size(125, 277);
            this.permissionsList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Roles:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roleList
            // 
            this.roleList.FormattingEnabled = true;
            this.roleList.Location = new System.Drawing.Point(466, 25);
            this.roleList.Name = "roleList";
            this.roleList.Size = new System.Drawing.Size(189, 407);
            this.roleList.TabIndex = 9;
            this.roleList.SelectedIndexChanged += new System.EventHandler(this.roleList_SelectedIndexChanged);
            this.roleList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roleList_MouseDown);
            // 
            // kickButton
            // 
            this.kickButton.Location = new System.Drawing.Point(146, 83);
            this.kickButton.Name = "kickButton";
            this.kickButton.Size = new System.Drawing.Size(61, 23);
            this.kickButton.TabIndex = 10;
            this.kickButton.Text = "Kick";
            this.kickButton.UseVisualStyleBackColor = true;
            this.kickButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ban";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kickButton);
            this.Controls.Add(this.roleList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.permissionsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botLabel);
            this.Controls.Add(this.createdAtLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUser";
            this.ShowIcon = false;
            this.Text = "Manage ";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel userIdLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label createdAtLabel;
        private System.Windows.Forms.Label botLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox permissionsList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox roleList;
        private System.Windows.Forms.Button kickButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}