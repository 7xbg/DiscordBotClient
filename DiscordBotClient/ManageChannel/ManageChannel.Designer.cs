namespace DiscordBotClient.ManageChannel
{
    partial class ManageChannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageChannel));
            this.label1 = new System.Windows.Forms.Label();
            this.channelName = new System.Windows.Forms.TextBox();
            this.setNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.channelDescription = new System.Windows.Forms.TextBox();
            this.setDescriptionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.setTimeoutButton = new System.Windows.Forms.Button();
            this.nsfwCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel Name:";
            // 
            // channelName
            // 
            this.channelName.Location = new System.Drawing.Point(98, 6);
            this.channelName.Name = "channelName";
            this.channelName.Size = new System.Drawing.Size(172, 20);
            this.channelName.TabIndex = 1;
            // 
            // setNameButton
            // 
            this.setNameButton.Enabled = false;
            this.setNameButton.Location = new System.Drawing.Point(276, 2);
            this.setNameButton.Name = "setNameButton";
            this.setNameButton.Size = new System.Drawing.Size(80, 26);
            this.setNameButton.TabIndex = 2;
            this.setNameButton.Text = "Set Name";
            this.setNameButton.UseVisualStyleBackColor = true;
            this.setNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Channel Description:";
            // 
            // channelDescription
            // 
            this.channelDescription.Location = new System.Drawing.Point(123, 34);
            this.channelDescription.Name = "channelDescription";
            this.channelDescription.Size = new System.Drawing.Size(233, 20);
            this.channelDescription.TabIndex = 4;
            // 
            // setDescriptionButton
            // 
            this.setDescriptionButton.Enabled = false;
            this.setDescriptionButton.Location = new System.Drawing.Point(362, 30);
            this.setDescriptionButton.Name = "setDescriptionButton";
            this.setDescriptionButton.Size = new System.Drawing.Size(96, 26);
            this.setDescriptionButton.TabIndex = 5;
            this.setDescriptionButton.Text = "Set Description";
            this.setDescriptionButton.UseVisualStyleBackColor = true;
            this.setDescriptionButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Channel Chat Timeout:";
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.Location = new System.Drawing.Point(133, 62);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(93, 20);
            this.timeoutTextBox.TabIndex = 7;
            this.timeoutTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // setTimeoutButton
            // 
            this.setTimeoutButton.Enabled = false;
            this.setTimeoutButton.Location = new System.Drawing.Point(232, 60);
            this.setTimeoutButton.Name = "setTimeoutButton";
            this.setTimeoutButton.Size = new System.Drawing.Size(85, 26);
            this.setTimeoutButton.TabIndex = 8;
            this.setTimeoutButton.Text = "Set Timeout";
            this.setTimeoutButton.UseVisualStyleBackColor = true;
            this.setTimeoutButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // nsfwCheckBox
            // 
            this.nsfwCheckBox.AutoSize = true;
            this.nsfwCheckBox.Location = new System.Drawing.Point(15, 91);
            this.nsfwCheckBox.Name = "nsfwCheckBox";
            this.nsfwCheckBox.Size = new System.Drawing.Size(58, 17);
            this.nsfwCheckBox.TabIndex = 9;
            this.nsfwCheckBox.Text = "NSFW";
            this.nsfwCheckBox.UseVisualStyleBackColor = true;
            this.nsfwCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ManageChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 116);
            this.Controls.Add(this.nsfwCheckBox);
            this.Controls.Add(this.setTimeoutButton);
            this.Controls.Add(this.timeoutTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setDescriptionButton);
            this.Controls.Add(this.channelDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setNameButton);
            this.Controls.Add(this.channelName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageChannel";
            this.Text = "Manage Channel";
            this.Load += new System.EventHandler(this.ManageChannel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox channelName;
        private System.Windows.Forms.Button setNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox channelDescription;
        private System.Windows.Forms.Button setDescriptionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.Button setTimeoutButton;
        private System.Windows.Forms.CheckBox nsfwCheckBox;
    }
}