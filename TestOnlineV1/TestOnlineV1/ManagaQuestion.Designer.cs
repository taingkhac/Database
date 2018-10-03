namespace TestOnlineV1
{
	partial class ManagaQuestion
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtSearchQSid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rdA = new System.Windows.Forms.RadioButton();
			this.rdB = new System.Windows.Forms.RadioButton();
			this.rdC = new System.Windows.Forms.RadioButton();
			this.rdD = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbBSu = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtD = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtManaQSid = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rtbContent = new System.Windows.Forms.RichTextBox();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-1, 475);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1162, 194);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// txtSearchQSid
			// 
			this.txtSearchQSid.Location = new System.Drawing.Point(141, 45);
			this.txtSearchQSid.Multiline = true;
			this.txtSearchQSid.Name = "txtSearchQSid";
			this.txtSearchQSid.Size = new System.Drawing.Size(302, 31);
			this.txtSearchQSid.TabIndex = 1;
			this.txtSearchQSid.TextChanged += new System.EventHandler(this.txtSearchQSid_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Question Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(531, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Subject";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Content";
			// 
			// rdA
			// 
			this.rdA.AutoSize = true;
			this.rdA.Location = new System.Drawing.Point(576, 151);
			this.rdA.Name = "rdA";
			this.rdA.Size = new System.Drawing.Size(45, 24);
			this.rdA.TabIndex = 3;
			this.rdA.TabStop = true;
			this.rdA.Text = "A";
			this.rdA.UseVisualStyleBackColor = true;
			// 
			// rdB
			// 
			this.rdB.AutoSize = true;
			this.rdB.Location = new System.Drawing.Point(576, 200);
			this.rdB.Name = "rdB";
			this.rdB.Size = new System.Drawing.Size(45, 24);
			this.rdB.TabIndex = 3;
			this.rdB.TabStop = true;
			this.rdB.Text = "B";
			this.rdB.UseVisualStyleBackColor = true;
			// 
			// rdC
			// 
			this.rdC.AutoSize = true;
			this.rdC.Location = new System.Drawing.Point(576, 240);
			this.rdC.Name = "rdC";
			this.rdC.Size = new System.Drawing.Size(45, 24);
			this.rdC.TabIndex = 3;
			this.rdC.TabStop = true;
			this.rdC.Text = "C";
			this.rdC.UseVisualStyleBackColor = true;
			// 
			// rdD
			// 
			this.rdD.AutoSize = true;
			this.rdD.Location = new System.Drawing.Point(576, 286);
			this.rdD.Name = "rdD";
			this.rdD.Size = new System.Drawing.Size(46, 24);
			this.rdD.TabIndex = 3;
			this.rdD.TabStop = true;
			this.rdD.Text = "D";
			this.rdD.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtSearchQSid);
			this.groupBox1.Location = new System.Drawing.Point(188, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(655, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search Question";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(483, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rtbContent);
			this.groupBox2.Controls.Add(this.cbBSu);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtD);
			this.groupBox2.Controls.Add(this.txtC);
			this.groupBox2.Controls.Add(this.txtB);
			this.groupBox2.Controls.Add(this.txtA);
			this.groupBox2.Controls.Add(this.txtManaQSid);
			this.groupBox2.Controls.Add(this.rdD);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.rdC);
			this.groupBox2.Controls.Add(this.rdB);
			this.groupBox2.Controls.Add(this.rdA);
			this.groupBox2.Location = new System.Drawing.Point(188, 118);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(973, 351);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Manage Question";
			// 
			// cbBSu
			// 
			this.cbBSu.FormattingEnabled = true;
			this.cbBSu.Items.AddRange(new object[] {
            "Top Notch 1",
            "Top Notch 2",
            "Top Notch 3",
            "Summit 1"});
			this.cbBSu.Location = new System.Drawing.Point(656, 83);
			this.cbBSu.Name = "cbBSu";
			this.cbBSu.Size = new System.Drawing.Size(302, 28);
			this.cbBSu.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(531, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Question Id";
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(656, 279);
			this.txtD.Multiline = true;
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(302, 31);
			this.txtD.TabIndex = 1;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(656, 233);
			this.txtC.Multiline = true;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(302, 31);
			this.txtC.TabIndex = 1;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(656, 193);
			this.txtB.Multiline = true;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(302, 31);
			this.txtB.TabIndex = 1;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(656, 144);
			this.txtA.Multiline = true;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(302, 31);
			this.txtA.TabIndex = 1;
			// 
			// txtManaQSid
			// 
			this.txtManaQSid.Location = new System.Drawing.Point(656, 38);
			this.txtManaQSid.Multiline = true;
			this.txtManaQSid.Name = "txtManaQSid";
			this.txtManaQSid.Size = new System.Drawing.Size(302, 31);
			this.txtManaQSid.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1167, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 49);
			this.button2.TabIndex = 3;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1167, 302);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 44);
			this.button3.TabIndex = 3;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1167, 388);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 40);
			this.button4.TabIndex = 3;
			this.button4.Text = "Exit";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TestOnlineV1.Properties.Resources.Manager_icon;
			this.pictureBox1.Location = new System.Drawing.Point(22, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 156);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// rtbContent
			// 
			this.rtbContent.Location = new System.Drawing.Point(141, 38);
			this.rtbContent.Name = "rtbContent";
			this.rtbContent.Size = new System.Drawing.Size(371, 307);
			this.rtbContent.TabIndex = 5;
			this.rtbContent.Text = "";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(1167, 151);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(110, 45);
			this.button5.TabIndex = 7;
			this.button5.Text = "Show All";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// ManagaQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 666);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ManagaQuestion";
			this.Text = "ManagaQuestion";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtSearchQSid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdA;
		private System.Windows.Forms.RadioButton rdB;
		private System.Windows.Forms.RadioButton rdC;
		private System.Windows.Forms.RadioButton rdD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtManaQSid;
		private System.Windows.Forms.ComboBox cbBSu;
		private System.Windows.Forms.TextBox txtD;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox rtbContent;
		private System.Windows.Forms.Button button5;
	}
}