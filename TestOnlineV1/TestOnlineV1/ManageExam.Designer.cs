namespace TestOnlineV1
{
	partial class ManageExam
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtidexam = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font(".VnArial NarrowH", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(516, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manage Exam";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(87, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Exam ID";
			// 
			// txtidexam
			// 
			this.txtidexam.Location = new System.Drawing.Point(188, 126);
			this.txtidexam.Name = "txtidexam";
			this.txtidexam.Size = new System.Drawing.Size(142, 26);
			this.txtidexam.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(207, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(1103, 241);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 54);
			this.button2.TabIndex = 3;
			this.button2.Text = "Add Exam";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Location = new System.Drawing.Point(974, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 155);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Question To Exam";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(203, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Subject";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Top Notch 1",
            "Top Notch 2",
            "Top Notch 3",
            "Summit 1"});
			this.comboBox1.Location = new System.Drawing.Point(28, 102);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(148, 28);
			this.comboBox1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "ID Question";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(2, 211);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1071, 390);
			this.dataGridView1.TabIndex = 6;
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(501, 126);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(207, 26);
			this.txtDate.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(400, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Exam Date";
			// 
			// ManageExam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1346, 737);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.txtidexam);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Name = "ManageExam";
			this.Text = "ManageExam";
			this.Load += new System.EventHandler(this.ManageExam_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtidexam;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Label label5;
	}
}