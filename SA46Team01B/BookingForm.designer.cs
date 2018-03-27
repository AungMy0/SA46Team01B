namespace SA46Team01B
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingnolabel = new System.Windows.Forms.Label();
            this.memberIDlabel = new System.Windows.Forms.Label();
            this.membernamelabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sessionbox = new System.Windows.Forms.ComboBox();
            this.Session = new System.Windows.Forms.Label();
            this.cancellbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.facilitynamebox = new System.Windows.Forms.ComboBox();
            this.facilityIDbox = new System.Windows.Forms.ComboBox();
            this.amtlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.submitbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booknolabel = new System.Windows.Forms.Label();
            this.memidbox = new System.Windows.Forms.ComboBox();
            this.membnbox = new System.Windows.Forms.ComboBox();
            this.girdviewstatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // bookingnolabel
            // 
            this.bookingnolabel.AutoSize = true;
            this.bookingnolabel.Location = new System.Drawing.Point(76, 126);
            this.bookingnolabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bookingnolabel.Name = "bookingnolabel";
            this.bookingnolabel.Size = new System.Drawing.Size(162, 32);
            this.bookingnolabel.TabIndex = 1;
            this.bookingnolabel.Text = "Booking No";
            // 
            // memberIDlabel
            // 
            this.memberIDlabel.AutoSize = true;
            this.memberIDlabel.Location = new System.Drawing.Point(76, 203);
            this.memberIDlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.memberIDlabel.Name = "memberIDlabel";
            this.memberIDlabel.Size = new System.Drawing.Size(152, 32);
            this.memberIDlabel.TabIndex = 2;
            this.memberIDlabel.Text = "Member ID";
            // 
            // membernamelabel
            // 
            this.membernamelabel.AutoSize = true;
            this.membernamelabel.Location = new System.Drawing.Point(76, 285);
            this.membernamelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.membernamelabel.Name = "membernamelabel";
            this.membernamelabel.Size = new System.Drawing.Size(200, 32);
            this.membernamelabel.TabIndex = 3;
            this.membernamelabel.Text = "Member Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sessionbox);
            this.groupBox1.Controls.Add(this.Session);
            this.groupBox1.Controls.Add(this.cancellbtn);
            this.groupBox1.Controls.Add(this.Searchbtn);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.facilitynamebox);
            this.groupBox1.Controls.Add(this.facilityIDbox);
            this.groupBox1.Controls.Add(this.amtlabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.removebtn);
            this.groupBox1.Location = new System.Drawing.Point(66, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1608, 544);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Detail";
            // 
            // sessionbox
            // 
            this.sessionbox.FormattingEnabled = true;
            this.sessionbox.Location = new System.Drawing.Point(416, 349);
            this.sessionbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sessionbox.Name = "sessionbox";
            this.sessionbox.Size = new System.Drawing.Size(238, 39);
            this.sessionbox.TabIndex = 24;
            this.sessionbox.SelectedIndexChanged += new System.EventHandler(this.sessionbox_SelectedIndexChanged);
            // 
            // Session
            // 
            this.Session.AutoSize = true;
            this.Session.Location = new System.Drawing.Point(70, 355);
            this.Session.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(117, 32);
            this.Session.TabIndex = 23;
            this.Session.Text = "Session";
            // 
            // cancellbtn
            // 
            this.cancellbtn.BackColor = System.Drawing.Color.LightBlue;
            this.cancellbtn.Location = new System.Drawing.Point(1134, 355);
            this.cancellbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancellbtn.Name = "cancellbtn";
            this.cancellbtn.Size = new System.Drawing.Size(348, 83);
            this.cancellbtn.TabIndex = 22;
            this.cancellbtn.Text = "Cancellation";
            this.cancellbtn.UseVisualStyleBackColor = false;
            this.cancellbtn.Click += new System.EventHandler(this.cancellbtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.LightBlue;
            this.Searchbtn.Location = new System.Drawing.Point(1134, 60);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(348, 83);
            this.Searchbtn.TabIndex = 17;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker2.Location = new System.Drawing.Point(416, 250);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker2.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 38);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // facilitynamebox
            // 
            this.facilitynamebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.facilitynamebox.FormattingEnabled = true;
            this.facilitynamebox.Location = new System.Drawing.Point(416, 60);
            this.facilitynamebox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.facilitynamebox.Name = "facilitynamebox";
            this.facilitynamebox.Size = new System.Drawing.Size(414, 39);
            this.facilitynamebox.TabIndex = 15;
            this.facilitynamebox.SelectedIndexChanged += new System.EventHandler(this.facilitynamebox_SelectedIndexChanged);
            // 
            // facilityIDbox
            // 
            this.facilityIDbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.facilityIDbox.FormattingEnabled = true;
            this.facilityIDbox.Location = new System.Drawing.Point(416, 151);
            this.facilityIDbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.facilityIDbox.Name = "facilityIDbox";
            this.facilityIDbox.Size = new System.Drawing.Size(414, 39);
            this.facilityIDbox.TabIndex = 12;
            this.facilityIDbox.SelectedIndexChanged += new System.EventHandler(this.facilityIDbox_SelectedIndexChanged);
            // 
            // amtlabel
            // 
            this.amtlabel.AutoSize = true;
            this.amtlabel.Location = new System.Drawing.Point(410, 446);
            this.amtlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amtlabel.Name = "amtlabel";
            this.amtlabel.Size = new System.Drawing.Size(109, 32);
            this.amtlabel.TabIndex = 10;
            this.amtlabel.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 446);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Booking Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sport Facility No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sport Facility Name";
            // 
            // removebtn
            // 
            this.removebtn.BackColor = System.Drawing.Color.LightBlue;
            this.removebtn.Location = new System.Drawing.Point(1132, 209);
            this.removebtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(348, 83);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(564, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 293);
            this.dataGridView1.TabIndex = 20;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.Color.Wheat;
            this.submitbtn.Location = new System.Drawing.Point(644, 949);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(526, 68);
            this.submitbtn.TabIndex = 9;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 23);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 3, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 38);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2018, 3, 24, 0, 0, 0, 0);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(564, 56);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1126, 283);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            // 
            // booknolabel
            // 
            this.booknolabel.AutoSize = true;
            this.booknolabel.Location = new System.Drawing.Point(280, 126);
            this.booknolabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.booknolabel.Name = "booknolabel";
            this.booknolabel.Size = new System.Drawing.Size(93, 32);
            this.booknolabel.TabIndex = 17;
            this.booknolabel.Text = "label2";
            // 
            // memidbox
            // 
            this.memidbox.AutoCompleteCustomSource.AddRange(new string[] {
            "memberID"});
            this.memidbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.memidbox.FormattingEnabled = true;
            this.memidbox.Location = new System.Drawing.Point(286, 203);
            this.memidbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.memidbox.Name = "memidbox";
            this.memidbox.Size = new System.Drawing.Size(238, 39);
            this.memidbox.TabIndex = 18;
            this.memidbox.SelectedIndexChanged += new System.EventHandler(this.memidbox_SelectedIndexChanged);
            // 
            // membnbox
            // 
            this.membnbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.membnbox.FormattingEnabled = true;
            this.membnbox.Location = new System.Drawing.Point(288, 285);
            this.membnbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.membnbox.Name = "membnbox";
            this.membnbox.Size = new System.Drawing.Size(238, 39);
            this.membnbox.TabIndex = 19;
            this.membnbox.SelectedIndexChanged += new System.EventHandler(this.membnbox_SelectedIndexChanged);
            // 
            // girdviewstatus
            // 
            this.girdviewstatus.AutoSize = true;
            this.girdviewstatus.Location = new System.Drawing.Point(558, 17);
            this.girdviewstatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.girdviewstatus.Name = "girdviewstatus";
            this.girdviewstatus.Size = new System.Drawing.Size(93, 32);
            this.girdviewstatus.TabIndex = 21;
            this.girdviewstatus.Text = "label2";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1698, 1040);
            this.Controls.Add(this.girdviewstatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.membnbox);
            this.Controls.Add(this.memidbox);
            this.Controls.Add(this.booknolabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.membernamelabel);
            this.Controls.Add(this.memberIDlabel);
            this.Controls.Add(this.bookingnolabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BookingForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bookingnolabel;
        private System.Windows.Forms.Label memberIDlabel;
        private System.Windows.Forms.Label membernamelabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox facilityIDbox;
        private System.Windows.Forms.Label amtlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label booknolabel;
        private System.Windows.Forms.ComboBox memidbox;
        private System.Windows.Forms.ComboBox membnbox;
        private System.Windows.Forms.ComboBox facilitynamebox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Searchbtn;
       // private SA46Team01BDataSet sA46Team01BDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label girdviewstatus;
        private System.Windows.Forms.Button cancellbtn;
        private System.Windows.Forms.ComboBox sessionbox;
        private System.Windows.Forms.Label Session;
        // private SA46Team01BDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
    }
}