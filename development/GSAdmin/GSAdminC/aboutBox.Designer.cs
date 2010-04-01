namespace GSAdminC
{
    partial class aboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutBox));
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Location = new System.Drawing.Point(0, 408);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(403, 17);
            this.LinkLabel1.TabIndex = 17;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Found a bug? Want Updates? Visit http://aa3rdpartymaps.googlecode.com";
            this.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(1, 265);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(395, 112);
            this.Label5.TabIndex = 15;
            this.Label5.Text = resources.GetString("Label5.Text");
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(155, 248);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(241, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Alien Arena image courtesy of COR Entertainment";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(0, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(226, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Game server administration tool for Alien Arena";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(-2, 5);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(197, 19);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "GS Admin v0.9b STABLE";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(303, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(93, 24);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Okay";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(-2, 377);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(409, 53);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "This software is provided as-is with no warranty. Use this software at your own r" +
                "isk, 3PM will not be held responsible for loss or damage to files, or settings b" +
                "oth locally and remotely.";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(0, 433);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(403, 17);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Need Help? Visit http://www.arenawiki.com/GSAdmin";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::GSAdminC.Properties.Resources._3pm;
            this.PictureBox2.Location = new System.Drawing.Point(193, 264);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(211, 88);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 16;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::GSAdminC.Properties.Resources.aalogobig;
            this.PictureBox1.Location = new System.Drawing.Point(-3, 45);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(410, 200);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // aboutBox
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 456);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "aboutBox";
            this.ShowInTaskbar = false;
            this.Text = "About GSAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.LinkLabel linkLabel2;
    }
}