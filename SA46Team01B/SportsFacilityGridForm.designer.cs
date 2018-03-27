namespace SA46Team01B
{
    partial class SportsFacilityGridForm
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
            this.dataGridViewSportFac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportFac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSportFac
            // 
            this.dataGridViewSportFac.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridViewSportFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSportFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSportFac.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSportFac.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewSportFac.Name = "dataGridViewSportFac";
            this.dataGridViewSportFac.RowTemplate.Height = 28;
            this.dataGridViewSportFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSportFac.Size = new System.Drawing.Size(940, 708);
            this.dataGridViewSportFac.TabIndex = 0;
            this.dataGridViewSportFac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSportFac_CellClick);

            // 
            // SportsFacilityGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(940, 708);
            this.Controls.Add(this.dataGridViewSportFac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SportsFacilityGridForm";
            this.Text = "SportsFacilityGridForm";
            this.Load += new System.EventHandler(this.SportsFacilityGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSportFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSportFac;
    }
}