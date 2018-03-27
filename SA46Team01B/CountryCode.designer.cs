namespace SA46Team01B
{
    partial class CountryCode
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
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnQSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(197, 119);
            this.lblCountryCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(189, 32);
            this.lblCountryCode.TabIndex = 0;
            this.lblCountryCode.Text = "Country Code";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(197, 239);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(196, 32);
            this.lblCountryName.TabIndex = 1;
            this.lblCountryName.Text = "Country Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(827, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnQSearch
            // 
            this.btnQSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnQSearch.Location = new System.Drawing.Point(827, 223);
            this.btnQSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQSearch.Name = "btnQSearch";
            this.btnQSearch.Size = new System.Drawing.Size(258, 62);
            this.btnQSearch.TabIndex = 5;
            this.btnQSearch.Text = "Quick Search";
            this.btnQSearch.UseVisualStyleBackColor = false;
            this.btnQSearch.Click += new System.EventHandler(this.btnQSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Wheat;
            this.btnAdd.Location = new System.Drawing.Point(514, 459);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 76);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Wheat;
            this.btnUpdate.Location = new System.Drawing.Point(827, 459);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(252, 76);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(500, 226);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(267, 39);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Wheat;
            this.btnClear.Location = new System.Drawing.Point(204, 459);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(260, 76);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CountryCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1326, 696);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnQSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblCountryCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CountryCode";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CountryCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnQSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnClear;
    }
}

