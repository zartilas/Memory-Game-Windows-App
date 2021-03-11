namespace FinalErgasia1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLeaderboards = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStats = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelUserRules = new System.Windows.Forms.Label();
            this.labelSelectUser = new System.Windows.Forms.Label();
            this.buttonCreateUserConf = new System.Windows.Forms.Button();
            this.textBoxEnterUser = new System.Windows.Forms.TextBox();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.labelEnterUser = new System.Windows.Forms.Label();
            this.panelMenuButtons = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(15, 252);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(160, 54);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(15, 110);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 54);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeaderboards
            // 
            this.buttonLeaderboards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLeaderboards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaderboards.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLeaderboards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaderboards.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboards.ForeColor = System.Drawing.Color.White;
            this.buttonLeaderboards.Location = new System.Drawing.Point(15, 182);
            this.buttonLeaderboards.Name = "buttonLeaderboards";
            this.buttonLeaderboards.Size = new System.Drawing.Size(160, 54);
            this.buttonLeaderboards.TabIndex = 1;
            this.buttonLeaderboards.Text = "Leaderboards";
            this.buttonLeaderboards.UseVisualStyleBackColor = false;
            this.buttonLeaderboards.Click += new System.EventHandler(this.buttonLeaderboards_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.buttonStats);
            this.panelMenu.Controls.Add(this.comboBoxUsers);
            this.panelMenu.Controls.Add(this.labelUserRules);
            this.panelMenu.Controls.Add(this.labelSelectUser);
            this.panelMenu.Controls.Add(this.buttonCreateUserConf);
            this.panelMenu.Controls.Add(this.textBoxEnterUser);
            this.panelMenu.Controls.Add(this.buttonCreateUser);
            this.panelMenu.Controls.Add(this.labelEnterUser);
            this.panelMenu.Location = new System.Drawing.Point(0, -2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(586, 180);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.buttonStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStats.Location = new System.Drawing.Point(12, 63);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(121, 31);
            this.buttonStats.TabIndex = 25;
            this.buttonStats.Text = "Stats";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.Visible = false;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.ItemHeight = 16;
            this.comboBoxUsers.Location = new System.Drawing.Point(12, 31);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUsers.TabIndex = 19;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // labelUserRules
            // 
            this.labelUserRules.AutoSize = true;
            this.labelUserRules.BackColor = System.Drawing.Color.Transparent;
            this.labelUserRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRules.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUserRules.Location = new System.Drawing.Point(139, 126);
            this.labelUserRules.Name = "labelUserRules";
            this.labelUserRules.Size = new System.Drawing.Size(321, 39);
            this.labelUserRules.TabIndex = 24;
            this.labelUserRules.Text = "* The username cannot contain any special characters.\r\n* The username cannot cont" +
    "ain spaces.\r\n* The username character limit is 16.";
            this.labelUserRules.Visible = false;
            // 
            // labelSelectUser
            // 
            this.labelSelectUser.AutoSize = true;
            this.labelSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSelectUser.Location = new System.Drawing.Point(12, 11);
            this.labelSelectUser.Name = "labelSelectUser";
            this.labelSelectUser.Size = new System.Drawing.Size(65, 13);
            this.labelSelectUser.TabIndex = 20;
            this.labelSelectUser.Text = "Select User:";
            // 
            // buttonCreateUserConf
            // 
            this.buttonCreateUserConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateUserConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateUserConf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCreateUserConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonCreateUserConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonCreateUserConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUserConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUserConf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateUserConf.Location = new System.Drawing.Point(254, 91);
            this.buttonCreateUserConf.Name = "buttonCreateUserConf";
            this.buttonCreateUserConf.Size = new System.Drawing.Size(78, 23);
            this.buttonCreateUserConf.TabIndex = 23;
            this.buttonCreateUserConf.Text = "Create";
            this.buttonCreateUserConf.UseVisualStyleBackColor = false;
            this.buttonCreateUserConf.Visible = false;
            this.buttonCreateUserConf.Click += new System.EventHandler(this.buttonCreateUserConf_Click);
            // 
            // textBoxEnterUser
            // 
            this.textBoxEnterUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEnterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEnterUser.Location = new System.Drawing.Point(142, 92);
            this.textBoxEnterUser.MaxLength = 16;
            this.textBoxEnterUser.Name = "textBoxEnterUser";
            this.textBoxEnterUser.ShortcutsEnabled = false;
            this.textBoxEnterUser.Size = new System.Drawing.Size(106, 21);
            this.textBoxEnterUser.TabIndex = 21;
            this.textBoxEnterUser.Visible = false;
            this.textBoxEnterUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterUser_KeyDown);
            this.textBoxEnterUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnterUser_KeyPress);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCreateUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.buttonCreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateUser.Location = new System.Drawing.Point(140, 30);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(122, 26);
            this.buttonCreateUser.TabIndex = 18;
            this.buttonCreateUser.Text = "Create a new user";
            this.buttonCreateUser.UseVisualStyleBackColor = false;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // labelEnterUser
            // 
            this.labelEnterUser.AutoSize = true;
            this.labelEnterUser.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEnterUser.Location = new System.Drawing.Point(139, 75);
            this.labelEnterUser.Name = "labelEnterUser";
            this.labelEnterUser.Size = new System.Drawing.Size(86, 13);
            this.labelEnterUser.TabIndex = 22;
            this.labelEnterUser.Text = "Enter Username:";
            this.labelEnterUser.Visible = false;
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenuButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenuButtons.Controls.Add(this.pictureBox1);
            this.panelMenuButtons.Controls.Add(this.buttonLeaderboards);
            this.panelMenuButtons.Controls.Add(this.buttonSettings);
            this.panelMenuButtons.Controls.Add(this.buttonStart);
            this.panelMenuButtons.Location = new System.Drawing.Point(199, 178);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(191, 330);
            this.panelMenuButtons.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FinalErgasia1.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 98);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::FinalErgasia1.Properties.Resources.Background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 530);
            this.Controls.Add(this.panelMenuButtons);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMenuButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLeaderboards;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonStats;
        public System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label labelUserRules;
        private System.Windows.Forms.Label labelSelectUser;
        private System.Windows.Forms.Button buttonCreateUserConf;
        private System.Windows.Forms.TextBox textBoxEnterUser;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label labelEnterUser;
        private System.Windows.Forms.Panel panelMenuButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

