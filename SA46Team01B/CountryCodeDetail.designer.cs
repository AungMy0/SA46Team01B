namespace SA46Team01B
{
    partial class CountryCodeDetail
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
            this.dataGridViewCountry = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCountry
            // 
            this.dataGridViewCountry.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCountry.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCountry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridViewCountry.Name = "dataGridViewCountry";
            this.dataGridViewCountry.RowTemplate.Height = 28;
            this.dataGridViewCountry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCountry.Size = new System.Drawing.Size(1682, 741);
            this.dataGridViewCountry.TabIndex = 0;
            this.dataGridViewCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountry_CellClick);
            // 
            // CountryCodeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1682, 915);
            this.Controls.Add(this.dataGridViewCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CountryCodeDetail";
            this.Text = "CountryCodeDetail";
            this.Load += new System.EventHandler(this.CountryCodeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCountry;
    }
}