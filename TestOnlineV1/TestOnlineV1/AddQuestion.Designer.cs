namespace TestOnlineV1
{
	partial class AddQuestion
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
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbContent = new System.Windows.Forms.RichTextBox();
			this.rdA = new System.Windows.Forms.RadioButton();
			this.txtA = new System.Windows.Forms.TextBox();
			this.rdB = new System.Windows.Forms.RadioButton();
			this.txtB = new System.Windows.Forms.TextBox();
			this.rdC = new System.Windows.Forms.RadioButton();
			this.txtC = new System.Windows.Forms.TextBox();
			this.rdD = new System.Windows.Forms.RadioButton();
			this.txtD = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(282, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Question ID";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(410, 12);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(193, 26);
			this.txtID.TabIndex = 1;
			this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(282, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Content";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// rtbContent
			// 
			this.rtbContent.Location = new System.Drawing.Point(367, 149);
			this.rtbContent.Name = "rtbContent";
			this.rtbContent.Size = new System.Drawing.Size(670, 171);
			this.rtbContent.TabIndex = 3;
			this.rtbContent.Text = "";
			this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
			// 
			// rdA
			// 
			this.rdA.AutoSize = true;
			this.rdA.Location = new System.Drawing.Point(286, 360);
			this.rdA.Name = "rdA";
			this.rdA.Size = new System.Drawing.Size(45, 24);
			this.rdA.TabIndex = 4;
			this.rdA.TabStop = true;
			this.rdA.Text = "A";
			this.rdA.UseVisualStyleBackColor = true;
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(367, 348);
			this.txtA.Multiline = true;
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(670, 36);
			this.txtA.TabIndex = 5;
			// 
			// rdB
			// 
			this.rdB.AutoSize = true;
			this.rdB.Location = new System.Drawing.Point(286, 445);
			this.rdB.Name = "rdB";
			this.rdB.Size = new System.Drawing.Size(45, 24);
			this.rdB.TabIndex = 4;
			this.rdB.TabStop = true;
			this.rdB.Text = "B";
			this.rdB.UseVisualStyleBackColor = true;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(367, 425);
			this.txtB.Multiline = true;
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(670, 44);
			this.txtB.TabIndex = 5;
			// 
			// rdC
			// 
			this.rdC.AutoSize = true;
			this.rdC.Location = new System.Drawing.Point(286, 519);
			this.rdC.Name = "rdC";
			this.rdC.Size = new System.Drawing.Size(45, 24);
			this.rdC.TabIndex = 4;
			this.rdC.TabStop = true;
			this.rdC.Text = "C";
			this.rdC.UseVisualStyleBackColor = true;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(367, 500);
			this.txtC.Multiline = true;
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(670, 43);
			this.txtC.TabIndex = 5;
			// 
			// rdD
			// 
			this.rdD.AutoSize = true;
			this.rdD.Location = new System.Drawing.Point(286, 607);
			this.rdD.Name = "rdD";
			this.rdD.Size = new System.Drawing.Size(46, 24);
			this.rdD.TabIndex = 4;
			this.rdD.TabStop = true;
			this.rdD.Text = "D";
			this.rdD.UseVisualStyleBackColor = true;
			// 
			// txtD
			// 
			this.txtD.Location = new System.Drawing.Point(367, 591);
			this.txtD.Multiline = true;
			this.txtD.Name = "txtD";
			this.txtD.Size = new System.Drawing.Size(670, 40);
			this.txtD.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(406, 685);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 56);
			this.button1.TabIndex = 6;
			this.button1.Text = "Add Question";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(826, 686);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 55);
			this.button2.TabIndex = 6;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(282, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Subject";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Top Notch 1",
            "Top Notch 2",
            "Top Notch 3",
            "Summit 1"});
			this.comboBox1.Location = new System.Drawing.Point(410, 61);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 28);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::TestOnlineV1.Properties.Resources.Actions_list_add_font_icon;
			this.pictureBox1.Location = new System.Drawing.Point(27, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(254, 267);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// AddQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 754);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtD);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.rdD);
			this.Controls.Add(this.rdB);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.rdC);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.rdA);
			this.Controls.Add(this.rtbContent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "AddQuestion";
			this.Text = "AddQuestion";
			this.Load += new System.EventHandler(this.AddQuestion_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox rtbContent;
		private System.Windows.Forms.RadioButton rdA;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.RadioButton rdB;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.RadioButton rdC;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.RadioButton rdD;
		private System.Windows.Forms.TextBox txtD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}