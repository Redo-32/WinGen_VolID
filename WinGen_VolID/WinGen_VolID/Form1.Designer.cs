namespace WinGen_VolID
{
    partial class Form1
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
            this.GenHWID = new System.Windows.Forms.Button();
            this.HWID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeHWID = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenHWID
            // 
            this.GenHWID.Location = new System.Drawing.Point(119, 56);
            this.GenHWID.Name = "GenHWID";
            this.GenHWID.Size = new System.Drawing.Size(74, 30);
            this.GenHWID.TabIndex = 0;
            this.GenHWID.Text = "Generate";
            this.GenHWID.UseVisualStyleBackColor = true;
            this.GenHWID.Click += new System.EventHandler(this.GenHWID_Click);
            // 
            // HWID
            // 
            this.HWID.BackColor = System.Drawing.SystemColors.Window;
            this.HWID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWID.Location = new System.Drawing.Point(20, 27);
            this.HWID.MaxLength = 10;
            this.HWID.Name = "HWID";
            this.HWID.ReadOnly = true;
            this.HWID.Size = new System.Drawing.Size(174, 23);
            this.HWID.TabIndex = 1;
            this.HWID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HWID);
            this.groupBox1.Controls.Add(this.ChangeHWID);
            this.groupBox1.Controls.Add(this.GenHWID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Volume ID";
            // 
            // ChangeHWID
            // 
            this.ChangeHWID.Location = new System.Drawing.Point(20, 56);
            this.ChangeHWID.Name = "ChangeHWID";
            this.ChangeHWID.Size = new System.Drawing.Size(74, 30);
            this.ChangeHWID.TabIndex = 0;
            this.ChangeHWID.Text = "Change";
            this.ChangeHWID.UseVisualStyleBackColor = true;
            this.ChangeHWID.Click += new System.EventHandler(this.ChangeHWID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 121);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WinOS VolumeID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenHWID;
        private System.Windows.Forms.TextBox HWID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangeHWID;
    }
}

