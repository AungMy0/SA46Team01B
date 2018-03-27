namespace SA46Team01B
{
    partial class MemberSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.PhoneNotextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.MemberIDtextBox = new System.Windows.Forms.TextBox();
            this.ResultCountlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategorytextBox = new System.Windows.Forms.TextBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 795);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MemberID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1748, 766);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgetextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddresstextBox);
            this.groupBox1.Controls.Add(this.PhoneNotextBox);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 871);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1336, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contains";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(1008, 60);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(181, 38);
            this.AgetextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(928, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age:";
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(175, 183);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(1138, 38);
            this.AddresstextBox.TabIndex = 9;
            // 
            // PhoneNotextBox
            // 
            this.PhoneNotextBox.Location = new System.Drawing.Point(175, 121);
            this.PhoneNotextBox.Name = "PhoneNotextBox";
            this.PhoneNotextBox.Size = new System.Drawing.Size(372, 38);
            this.PhoneNotextBox.TabIndex = 8;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(175, 57);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(675, 38);
            this.NametextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "PhoneNo.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackColor = System.Drawing.Color.LightBlue;
            this.Searchbutton.ForeColor = System.Drawing.Color.Maroon;
            this.Searchbutton.Location = new System.Drawing.Point(1419, 871);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(265, 100);
            this.Searchbutton.TabIndex = 4;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = false;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // MemberIDtextBox
            // 
            this.MemberIDtextBox.Location = new System.Drawing.Point(206, 789);
            this.MemberIDtextBox.Name = "MemberIDtextBox";
            this.MemberIDtextBox.Size = new System.Drawing.Size(318, 38);
            this.MemberIDtextBox.TabIndex = 5;
            // 
            // ResultCountlabel
            // 
            this.ResultCountlabel.AutoSize = true;
            this.ResultCountlabel.ForeColor = System.Drawing.Color.Blue;
            this.ResultCountlabel.Location = new System.Drawing.Point(1413, 786);
            this.ResultCountlabel.Name = "ResultCountlabel";
            this.ResultCountlabel.Size = new System.Drawing.Size(93, 32);
            this.ResultCountlabel.TabIndex = 6;
            this.ResultCountlabel.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 789);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Category:";
            // 
            // CategorytextBox
            // 
            this.CategorytextBox.Location = new System.Drawing.Point(758, 786);
            this.CategorytextBox.Name = "CategorytextBox";
            this.CategorytextBox.Size = new System.Drawing.Size(181, 38);
            this.CategorytextBox.TabIndex = 12;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.BackColor = System.Drawing.Color.LightBlue;
            this.Cancelbutton.ForeColor = System.Drawing.Color.Maroon;
            this.Cancelbutton.Location = new System.Drawing.Point(1419, 992);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(265, 100);
            this.Cancelbutton.TabIndex = 13;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = false;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // MemberSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1748, 1132);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.CategorytextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultCountlabel);
            this.Controls.Add(this.MemberIDtextBox);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberSearch";
            this.Text = "MemberSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox PhoneNotextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox MemberIDtextBox;
        private System.Windows.Forms.Label ResultCountlabel;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CategorytextBox;
        private System.Windows.Forms.Button Cancelbutton;
    }
}