namespace SA46Team01B
{
    partial class MemberReport
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
            this.MemberCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MemberCRV
            // 
            this.MemberCRV.ActiveViewIndex = -1;
            this.MemberCRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberCRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemberCRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberCRV.Location = new System.Drawing.Point(0, 0);
            this.MemberCRV.Name = "MemberCRV";
            this.MemberCRV.Size = new System.Drawing.Size(1736, 784);
            this.MemberCRV.TabIndex = 0;
            // 
            // MemberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 784);
            this.Controls.Add(this.MemberCRV);
            this.Name = "MemberReport";
            this.Text = "MemberReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MemberCRV;
    }
}