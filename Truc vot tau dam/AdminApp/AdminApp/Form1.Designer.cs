namespace AdminApp
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grvExam = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.txtSearchCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLoad = new System.Windows.Forms.Button();
			this.cboSubject = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtExam = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grvExam)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1730, 653);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1722, 620);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Question Manager";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1722, 620);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Exam Manager";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.grvExam);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.txtSearchCode);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(656, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(822, 591);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Exam List";
			// 
			// grvExam
			// 
			this.grvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grvExam.Location = new System.Drawing.Point(6, 152);
			this.grvExam.Name = "grvExam";
			this.grvExam.RowTemplate.Height = 28;
			this.grvExam.Size = new System.Drawing.Size(784, 424);
			this.grvExam.TabIndex = 3;
			this.grvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvExam_CellClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(513, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Search Exam";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtSearchCode
			// 
			this.txtSearchCode.Location = new System.Drawing.Point(119, 31);
			this.txtSearchCode.Name = "txtSearchCode";
			this.txtSearchCode.Size = new System.Drawing.Size(332, 26);
			this.txtSearchCode.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Exam Code";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtStatus);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnLoad);
			this.groupBox1.Controls.Add(this.cboSubject);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnCheck);
			this.groupBox1.Controls.Add(this.txtExam);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(647, 594);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Exam Detail";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(151, 355);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(210, 26);
			this.txtStatus.TabIndex = 10;
			this.txtStatus.Text = "W";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 355);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Exam Status";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(151, 254);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(210, 26);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Exam Date";
			// 
			// btnLoad
			// 
			this.btnLoad.Enabled = false;
			this.btnLoad.Location = new System.Drawing.Point(411, 172);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(165, 37);
			this.btnLoad.TabIndex = 6;
			this.btnLoad.Text = "Load Questions";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// cboSubject
			// 
			this.cboSubject.FormattingEnabled = true;
			this.cboSubject.Items.AddRange(new object[] {
            "Top lot 1",
            "Top lot 2",
            "Top lot ba",
            "Sum mit 1"});
			this.cboSubject.Location = new System.Drawing.Point(151, 172);
			this.cboSubject.Name = "cboSubject";
			this.cboSubject.Size = new System.Drawing.Size(210, 28);
			this.cboSubject.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Subject";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(411, 84);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(103, 33);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check Exist";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// txtExam
			// 
			this.txtExam.Location = new System.Drawing.Point(151, 90);
			this.txtExam.Name = "txtExam";
			this.txtExam.Size = new System.Drawing.Size(210, 26);
			this.txtExam.TabIndex = 2;
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(465, 485);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 34);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Location = new System.Drawing.Point(286, 485);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 34);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(84, 485);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 34);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add Exam";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Exam Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1754, 668);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grvExam)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView grvExam;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSearchCode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ComboBox cboSubject;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtExam;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label2;
	}
}

