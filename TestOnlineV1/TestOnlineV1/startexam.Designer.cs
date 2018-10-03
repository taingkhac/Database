using System;

namespace TestOnlineV1
{
	partial class startexam
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
			this.Rtstartconten = new System.Windows.Forms.RichTextBox();
			this.rdstarta = new System.Windows.Forms.RadioButton();
			this.rdstartB = new System.Windows.Forms.RadioButton();
			this.rdstartC = new System.Windows.Forms.RadioButton();
			this.rdstartD = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbtime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.txtex = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Rtstartconten
			// 
			this.Rtstartconten.Location = new System.Drawing.Point(574, 155);
			this.Rtstartconten.Name = "Rtstartconten";
			this.Rtstartconten.Size = new System.Drawing.Size(655, 239);
			this.Rtstartconten.TabIndex = 1;
			this.Rtstartconten.Text = "";
			this.Rtstartconten.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// rdstarta
			// 
			this.rdstarta.AutoSize = true;
			this.rdstarta.Location = new System.Drawing.Point(613, 445);
			this.rdstarta.Name = "rdstarta";
			this.rdstarta.Size = new System.Drawing.Size(126, 24);
			this.rdstarta.TabIndex = 2;
			this.rdstarta.TabStop = true;
			this.rdstarta.Text = "radioButton1";
			this.rdstarta.UseVisualStyleBackColor = true;
			this.rdstarta.CheckedChanged += new System.EventHandler(this.rdstarta_CheckedChanged);
			// 
			// rdstartB
			// 
			this.rdstartB.AutoSize = true;
			this.rdstartB.Location = new System.Drawing.Point(613, 493);
			this.rdstartB.Name = "rdstartB";
			this.rdstartB.Size = new System.Drawing.Size(126, 24);
			this.rdstartB.TabIndex = 2;
			this.rdstartB.TabStop = true;
			this.rdstartB.Text = "radioButton1";
			this.rdstartB.UseVisualStyleBackColor = true;
			this.rdstartB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// rdstartC
			// 
			this.rdstartC.AutoSize = true;
			this.rdstartC.Location = new System.Drawing.Point(613, 542);
			this.rdstartC.Name = "rdstartC";
			this.rdstartC.Size = new System.Drawing.Size(126, 24);
			this.rdstartC.TabIndex = 2;
			this.rdstartC.TabStop = true;
			this.rdstartC.Text = "radioButton1";
			this.rdstartC.UseVisualStyleBackColor = true;
			this.rdstartC.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// rdstartD
			// 
			this.rdstartD.AutoSize = true;
			this.rdstartD.Location = new System.Drawing.Point(613, 589);
			this.rdstartD.Name = "rdstartD";
			this.rdstartD.Size = new System.Drawing.Size(126, 24);
			this.rdstartD.TabIndex = 2;
			this.rdstartD.TabStop = true;
			this.rdstartD.Text = "radioButton1";
			this.rdstartD.UseVisualStyleBackColor = true;
			this.rdstartD.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(480, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Content";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(679, 685);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 43);
			this.button1.TabIndex = 4;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(904, 685);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 43);
			this.button2.TabIndex = 4;
			this.button2.Text = "Next";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbtime
			// 
			this.lbtime.AutoSize = true;
			this.lbtime.Location = new System.Drawing.Point(960, 45);
			this.lbtime.Name = "lbtime";
			this.lbtime.Size = new System.Drawing.Size(84, 20);
			this.lbtime.TabIndex = 5;
			this.lbtime.Text = "Time Max: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1060, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 20);
			this.label2.TabIndex = 6;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(599, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 37);
			this.button3.TabIndex = 7;
			this.button3.Text = "Load Question";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txtex
			// 
			this.txtex.Location = new System.Drawing.Point(425, 54);
			this.txtex.Multiline = true;
			this.txtex.Name = "txtex";
			this.txtex.Size = new System.Drawing.Size(143, 39);
			this.txtex.TabIndex = 8;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1138, 685);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 43);
			this.button4.TabIndex = 9;
			this.button4.Text = "Finish";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(316, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Exam Code";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(50, 121);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(218, 384);
			this.listBox1.TabIndex = 11;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// startexam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1521, 753);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.txtex);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbtime);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rdstartD);
			this.Controls.Add(this.rdstartC);
			this.Controls.Add(this.rdstartB);
			this.Controls.Add(this.rdstarta);
			this.Controls.Add(this.Rtstartconten);
			this.Name = "startexam";
			this.Text = "ExamManager";
			this.Load += new System.EventHandler(this.startexam_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.RichTextBox Rtstartconten;
		private System.Windows.Forms.RadioButton rdstarta;
		private System.Windows.Forms.RadioButton rdstartB;
		private System.Windows.Forms.RadioButton rdstartC;
		private System.Windows.Forms.RadioButton rdstartD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbtime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtex;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox1;
	}
}