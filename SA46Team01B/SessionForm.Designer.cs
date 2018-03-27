namespace SA46Team01B
{
    partial class SessionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SessionNolabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Firstbutton = new System.Windows.Forms.Button();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Newbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Session:";
            // 
            // SessionNolabel
            // 
            this.SessionNolabel.AutoSize = true;
            this.SessionNolabel.Location = new System.Drawing.Point(258, 96);
            this.SessionNolabel.Name = "SessionNolabel";
            this.SessionNolabel.Size = new System.Drawing.Size(93, 32);
            this.SessionNolabel.TabIndex = 1;
            this.SessionNolabel.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EnddateTimePicker);
            this.groupBox1.Controls.Add(this.StartdateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(134, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(240, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Please change only Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(622, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "*End time is a read-only, updates will be ignored";
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Location = new System.Drawing.Point(246, 232);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(355, 38);
            this.EnddateTimePicker.TabIndex = 3;
            this.EnddateTimePicker.ValueChanged += new System.EventHandler(this.EnddateTimePicker_ValueChanged);
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(246, 131);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(355, 38);
            this.StartdateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "EndTime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "StartTime:";
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.LightBlue;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.Maroon;
            this.Updatebutton.Location = new System.Drawing.Point(1005, 129);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(271, 72);
            this.Updatebutton.TabIndex = 6;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Firstbutton
            // 
            this.Firstbutton.BackColor = System.Drawing.Color.Wheat;
            this.Firstbutton.Location = new System.Drawing.Point(152, 669);
            this.Firstbutton.Name = "Firstbutton";
            this.Firstbutton.Size = new System.Drawing.Size(156, 72);
            this.Firstbutton.TabIndex = 7;
            this.Firstbutton.Text = "<<";
            this.Firstbutton.UseVisualStyleBackColor = false;
            this.Firstbutton.Click += new System.EventHandler(this.FirstRecordbutton_Click);
            // 
            // Lastbutton
            // 
            this.Lastbutton.BackColor = System.Drawing.Color.Wheat;
            this.Lastbutton.Location = new System.Drawing.Point(1120, 669);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(156, 72);
            this.Lastbutton.TabIndex = 8;
            this.Lastbutton.Text = ">>";
            this.Lastbutton.UseVisualStyleBackColor = false;
            this.Lastbutton.Click += new System.EventHandler(this.LastRecordbutton_Click);
            // 
            // Previousbutton
            // 
            this.Previousbutton.BackColor = System.Drawing.Color.Wheat;
            this.Previousbutton.Location = new System.Drawing.Point(338, 669);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(156, 72);
            this.Previousbutton.TabIndex = 9;
            this.Previousbutton.Text = "<";
            this.Previousbutton.UseVisualStyleBackColor = false;
            this.Previousbutton.Click += new System.EventHandler(this.PreviousRecordbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.BackColor = System.Drawing.Color.Wheat;
            this.Nextbutton.Location = new System.Drawing.Point(929, 669);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(156, 72);
            this.Nextbutton.TabIndex = 10;
            this.Nextbutton.Text = ">";
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Click += new System.EventHandler(this.NextRecordbutton_Click);
            // 
            // Newbutton
            // 
            this.Newbutton.BackColor = System.Drawing.Color.LightBlue;
            this.Newbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newbutton.ForeColor = System.Drawing.Color.Maroon;
            this.Newbutton.Location = new System.Drawing.Point(1005, 32);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(271, 72);
            this.Newbutton.TabIndex = 11;
            this.Newbutton.Text = "Create New";
            this.Newbutton.UseVisualStyleBackColor = false;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1405, 818);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.Lastbutton);
            this.Controls.Add(this.Firstbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SessionNolabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SessionForm";
            this.Text = "SessionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SessionNolabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Firstbutton;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}