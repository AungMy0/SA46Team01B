namespace SA46Team01B
{
    partial class Reports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MemberReportbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MemberReportbutton);
            this.groupBox1.Location = new System.Drawing.Point(241, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(745, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "Booking";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MemberReportbutton
            // 
            this.MemberReportbutton.BackColor = System.Drawing.Color.Wheat;
            this.MemberReportbutton.ForeColor = System.Drawing.Color.Black;
            this.MemberReportbutton.Location = new System.Drawing.Point(229, 152);
            this.MemberReportbutton.Name = "MemberReportbutton";
            this.MemberReportbutton.Size = new System.Drawing.Size(289, 115);
            this.MemberReportbutton.TabIndex = 0;
            this.MemberReportbutton.Text = "Member";
            this.MemberReportbutton.UseVisualStyleBackColor = false;
            this.MemberReportbutton.Click += new System.EventHandler(this.MemberReportbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(650, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Reports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(700, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "As of:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1724, 823);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MemberReportbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}