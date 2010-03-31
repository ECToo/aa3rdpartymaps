namespace GSAdminC
{
    partial class programSettings
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
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.chkBots = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkJoin = new System.Windows.Forms.CheckBox();
            this.chkNotify = new System.Windows.Forms.CheckBox();
            this.chkMinimize = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.gameBrowse = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.Enabled = false;
            this.txtPlayer.Location = new System.Drawing.Point(124, 175);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(210, 20);
            this.txtPlayer.TabIndex = 27;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 178);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Default Player Name:";
            // 
            // chkBots
            // 
            this.chkBots.AutoSize = true;
            this.chkBots.Location = new System.Drawing.Point(12, 105);
            this.chkBots.Name = "chkBots";
            this.chkBots.Size = new System.Drawing.Size(133, 17);
            this.chkBots.TabIndex = 25;
            this.chkBots.Text = "Show bots in player list";
            this.chkBots.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(340, 146);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 23);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(124, 148);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(210, 20);
            this.txtLocation.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 151);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Alien Arena Directory:";
            // 
            // chkJoin
            // 
            this.chkJoin.AutoSize = true;
            this.chkJoin.Location = new System.Drawing.Point(12, 127);
            this.chkJoin.Name = "chkJoin";
            this.chkJoin.Size = new System.Drawing.Size(163, 17);
            this.chkJoin.TabIndex = 21;
            this.chkJoin.Text = "Enable \"Join Game\" function";
            this.chkJoin.UseVisualStyleBackColor = true;
            this.chkJoin.CheckedChanged += new System.EventHandler(this.chkJoin_CheckedChanged);
            // 
            // chkNotify
            // 
            this.chkNotify.AutoSize = true;
            this.chkNotify.Location = new System.Drawing.Point(12, 82);
            this.chkNotify.Name = "chkNotify";
            this.chkNotify.Size = new System.Drawing.Size(225, 17);
            this.chkNotify.TabIndex = 20;
            this.chkNotify.Text = "Notify me when a server is non responsive";
            this.chkNotify.UseVisualStyleBackColor = true;
            // 
            // chkMinimize
            // 
            this.chkMinimize.AutoSize = true;
            this.chkMinimize.Location = new System.Drawing.Point(12, 59);
            this.chkMinimize.Name = "chkMinimize";
            this.chkMinimize.Size = new System.Drawing.Size(132, 17);
            this.chkMinimize.TabIndex = 19;
            this.chkMinimize.Text = "Minimize to tray on exit";
            this.chkMinimize.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(173, 201);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(101, 23);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Delete Settings";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(173, 33);
            this.numMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(33, 20);
            this.numMin.TabIndex = 17;
            this.numMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(12, 36);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(246, 17);
            this.chkAuto.TabIndex = 16;
            this.chkAuto.Text = "Automatically Refresh Every                 Minutes";
            this.chkAuto.UseVisualStyleBackColor = true;
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(12, 13);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(170, 17);
            this.chkStart.TabIndex = 15;
            this.chkStart.Text = "Refresh Server List On Startup";
            this.chkStart.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(280, 201);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(67, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(353, 201);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            // 
            // gameBrowse
            // 
            this.gameBrowse.Description = "Location of Alien Arena";
            // 
            // programSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 236);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.chkBots);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.chkJoin);
            this.Controls.Add(this.chkNotify);
            this.Controls.Add(this.chkMinimize);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.chkStart);
            this.Name = "programSettings";
            this.ShowInTaskbar = false;
            this.Text = "programSettings";
            this.Load += new System.EventHandler(this.programSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPlayer;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.CheckBox chkBots;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtLocation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkJoin;
        internal System.Windows.Forms.CheckBox chkNotify;
        internal System.Windows.Forms.CheckBox chkMinimize;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.NumericUpDown numMin;
        internal System.Windows.Forms.CheckBox chkAuto;
        internal System.Windows.Forms.CheckBox chkStart;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.FolderBrowserDialog gameBrowse;
    }
}