namespace GSAdminC
{
    partial class broadcastMessage
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(82, 207);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(72, 26);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Deselect All";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(4, 207);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(72, 26);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Select All";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(406, 26);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Broadcast Message. Enter what you want to say below, then choose the servers you\r" +
                "\nwant to broadcast to, and press send.";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(4, 36);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(411, 20);
            this.TextBox1.TabIndex = 4;
            // 
            // OK_Button
            // 
            this.OK_Button.Enabled = false;
            this.OK_Button.Location = new System.Drawing.Point(264, 207);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(72, 26);
            this.OK_Button.TabIndex = 4;
            this.OK_Button.Text = "Send";
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(4, 78);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(411, 124);
            this.chkList.TabIndex = 6;
            this.chkList.ThreeDCheckBoxes = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(342, 207);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(72, 26);
            this.Cancel_Button.TabIndex = 5;
            this.Cancel_Button.Text = "Close";
            // 
            // broadcastMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 240);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.chkList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "broadcastMessage";
            this.Text = "broadcastMessage";
            this.Load += new System.EventHandler(this.broadcastMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.CheckedListBox chkList;
        internal System.Windows.Forms.Button Cancel_Button;
    }
}