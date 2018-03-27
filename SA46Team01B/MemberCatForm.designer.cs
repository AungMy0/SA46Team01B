namespace SA46Team01B
{
    partial class MemberCatForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.discountlabel = new System.Windows.Forms.Label();
            this.amountratelabel = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.newbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.discounttextbox = new System.Windows.Forms.TextBox();
            this.amountratetaxbox = new System.Windows.Forms.TextBox();
            this.categorytextbox = new System.Windows.Forms.TextBox();
            this.dislabel = new System.Windows.Forms.Label();
            this.amrlabel = new System.Windows.Forms.Label();
            this.catlabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1031);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1776, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // discountlabel
            // 
            this.discountlabel.AutoSize = true;
            this.discountlabel.Location = new System.Drawing.Point(4, 525);
            this.discountlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.discountlabel.Name = "discountlabel";
            this.discountlabel.Size = new System.Drawing.Size(126, 32);
            this.discountlabel.TabIndex = 18;
            this.discountlabel.Text = "Discount";
            // 
            // amountratelabel
            // 
            this.amountratelabel.AutoSize = true;
            this.amountratelabel.Location = new System.Drawing.Point(4, 300);
            this.amountratelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amountratelabel.Name = "amountratelabel";
            this.amountratelabel.Size = new System.Drawing.Size(180, 32);
            this.amountratelabel.TabIndex = 17;
            this.amountratelabel.Text = "Amount Rate";
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Location = new System.Drawing.Point(4, 60);
            this.categorylabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(130, 32);
            this.categorylabel.TabIndex = 16;
            this.categorylabel.Text = "Category";
            // 
            // newbtn
            // 
            this.newbtn.BackColor = System.Drawing.Color.Wheat;
            this.newbtn.Location = new System.Drawing.Point(360, 869);
            this.newbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(204, 88);
            this.newbtn.TabIndex = 15;
            this.newbtn.Text = "new";
            this.newbtn.UseVisualStyleBackColor = false;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Wheat;
            this.savebtn.Location = new System.Drawing.Point(1213, 869);
            this.savebtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(178, 88);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(484, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 822);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // discounttextbox
            // 
            this.discounttextbox.Location = new System.Drawing.Point(256, 519);
            this.discounttextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.Size = new System.Drawing.Size(196, 38);
            this.discounttextbox.TabIndex = 25;
            this.discounttextbox.Visible = false;
            this.discounttextbox.TextChanged += new System.EventHandler(this.discounttextbox_TextChanged);
            this.discounttextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discounttextbox_KeyDown);
            // 
            // amountratetaxbox
            // 
            this.amountratetaxbox.CausesValidation = false;
            this.amountratetaxbox.Location = new System.Drawing.Point(256, 294);
            this.amountratetaxbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.amountratetaxbox.Name = "amountratetaxbox";
            this.amountratetaxbox.Size = new System.Drawing.Size(196, 38);
            this.amountratetaxbox.TabIndex = 24;
            this.amountratetaxbox.Visible = false;
            this.amountratetaxbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amountratetaxbox_KeyDown);
            // 
            // categorytextbox
            // 
            this.categorytextbox.Location = new System.Drawing.Point(256, 54);
            this.categorytextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.categorytextbox.Name = "categorytextbox";
            this.categorytextbox.Size = new System.Drawing.Size(196, 38);
            this.categorytextbox.TabIndex = 23;
            this.categorytextbox.Visible = false;
            // 
            // dislabel
            // 
            this.dislabel.AutoSize = true;
            this.dislabel.Location = new System.Drawing.Point(250, 525);
            this.dislabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dislabel.Name = "dislabel";
            this.dislabel.Size = new System.Drawing.Size(168, 32);
            this.dislabel.TabIndex = 22;
            this.dislabel.Text = "discounttext";
            // 
            // amrlabel
            // 
            this.amrlabel.AutoSize = true;
            this.amrlabel.Location = new System.Drawing.Point(250, 300);
            this.amrlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amrlabel.Name = "amrlabel";
            this.amrlabel.Size = new System.Drawing.Size(157, 32);
            this.amrlabel.TabIndex = 21;
            this.amrlabel.Text = "amtratetext";
            // 
            // catlabel
            // 
            this.catlabel.AutoSize = true;
            this.catlabel.Location = new System.Drawing.Point(250, 60);
            this.catlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.catlabel.Name = "catlabel";
            this.catlabel.Size = new System.Drawing.Size(170, 32);
            this.catlabel.TabIndex = 20;
            this.catlabel.Text = "categorytext";
            // 
            // MemberCatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1776, 1053);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.discountlabel);
            this.Controls.Add(this.amountratelabel);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.discounttextbox);
            this.Controls.Add(this.amountratetaxbox);
            this.Controls.Add(this.categorytextbox);
            this.Controls.Add(this.dislabel);
            this.Controls.Add(this.amrlabel);
            this.Controls.Add(this.catlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MemberCatForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Label discountlabel;
        private System.Windows.Forms.Label amountratelabel;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox discounttextbox;
        private System.Windows.Forms.TextBox amountratetaxbox;
        private System.Windows.Forms.TextBox categorytextbox;
        private System.Windows.Forms.Label dislabel;
        private System.Windows.Forms.Label amrlabel;
        private System.Windows.Forms.Label catlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

