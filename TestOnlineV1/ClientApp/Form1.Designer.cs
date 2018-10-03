namespace ClientApp
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
			this.components = new System.ComponentModel.Container();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.rtContent = new System.Windows.Forms.RichTextBox();
			this.rdA = new System.Windows.Forms.RadioButton();
			this.rdB = new System.Windows.Forms.RadioButton();
			this.rdC = new System.Windows.Forms.RadioButton();
			this.rdD = new System.Windows.Forms.RadioButton();
			this.lblTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(197, 551);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(97, 32);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "Pr&evious";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(613, 551);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(89, 32);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Ne&xt";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// rtContent
			// 
			this.rtContent.Location = new System.Drawing.Point(13, 60);
			this.rtContent.Name = "rtContent";
			this.rtContent.Size = new System.Drawing.Size(894, 213);
			this.rtContent.TabIndex = 1;
			this.rtContent.Text = "";
			// 
			// rdA
			// 
			this.rdA.AutoSize = true;
			this.rdA.Location = new System.Drawing.Point(65, 279);
			this.rdA.Name = "rdA";
			this.rdA.Size = new System.Drawing.Size(339, 24);
			this.rdA.TabIndex = 2;
			this.rdA.TabStop = true;
			this.rdA.Text = "this is sample answer for testing application";
			this.rdA.UseVisualStyleBackColor = true;
			this.rdA.CheckedChanged += new System.EventHandler(this.rdA_CheckedChanged);
			// 
			// rdB
			// 
			this.rdB.AutoSize = true;
			this.rdB.Location = new System.Drawing.Point(65, 344);
			this.rdB.Name = "rdB";
			this.rdB.Size = new System.Drawing.Size(126, 24);
			this.rdB.TabIndex = 2;
			this.rdB.TabStop = true;
			this.rdB.Text = "radioButton1";
			this.rdB.UseVisualStyleBackColor = true;
			// 
			// rdC
			// 
			this.rdC.AutoSize = true;
			this.rdC.Location = new System.Drawing.Point(65, 419);
			this.rdC.Name = "rdC";
			this.rdC.Size = new System.Drawing.Size(126, 24);
			this.rdC.TabIndex = 2;
			this.rdC.TabStop = true;
			this.rdC.Text = "radioButton1";
			this.rdC.UseVisualStyleBackColor = true;
			// 
			// rdD
			// 
			this.rdD.AutoSize = true;
			this.rdD.Location = new System.Drawing.Point(65, 485);
			this.rdD.Name = "rdD";
			this.rdD.Size = new System.Drawing.Size(126, 24);
			this.rdD.TabIndex = 2;
			this.rdD.TabStop = true;
			this.rdD.Text = "radioButton1";
			this.rdD.UseVisualStyleBackColor = true;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(630, 13);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(143, 20);
			this.lblTime.TabIndex = 3;
			this.lblTime.Text = "Time left : 40:00:00";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 611);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.rdD);
			this.Controls.Add(this.rdC);
			this.Controls.Add(this.rdB);
			this.Controls.Add(this.rdA);
			this.Controls.Add(this.rtContent);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.RichTextBox rtContent;
		private System.Windows.Forms.RadioButton rdA;
		private System.Windows.Forms.RadioButton rdB;
		private System.Windows.Forms.RadioButton rdC;
		private System.Windows.Forms.RadioButton rdD;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer1;
	}
}

