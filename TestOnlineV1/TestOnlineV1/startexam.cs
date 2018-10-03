using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOnlineV1
{
	public partial class startexam : Form
	{
		int index = 0;
		int gio, phut, giay;
		List<Question> list = new List<Question>();
		//List<Question> list = null;
		public startexam()
		{
			InitializeComponent();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void startexam_Load(object sender, EventArgs e)
		{
			//DataProcess dp = new DataProcess();
			//list = dp.Get25Questions();
			//LoadQuestion(index, list);
		 
		}
		private void LoadQuestion(int index, List<Question> list)
		{
			Question q = list[index];
			Rtstartconten.Text = q.Content;
			rdstarta.Text = q.A;
			rdstartB.Text = q.B;
			rdstartC.Text = q.C;
			rdstartD.Text = q.D;
		}
		int th = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			th--;
			giay--;
			if (giay == 0)
			{
				phut--;
				if (phut == 0)
				{
					giay = 60;
					th = giay;
				}
				giay = 60;

			}
			if(phut==0 && giay ==0)
			{
				timer1.Stop();
				ShowMark();
				this.Enabled = false;
			}
			if(phut == 5 && giay == 0)
			{
				label2.ForeColor = Color.Red;
				lbtime.ForeColor = Color.Red;
			}
			label2.Text = gio.ToString() + " : " + phut.ToString() + " : " + giay.ToString();
		}

		private void rdstarta_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string type = txtex.Text;
			DataProcess dp = new DataProcess();
			if(!dp.CheckExam(type))
				MessageBox.Show("Exam not started!!");
			else
			{
				MessageBox.Show("Load data ok!!");
				list = dp.GetQuestionsByExam(type);
				BindingData2List();
				LoadQuestion(index, list);
				timer1.Start();
				giay = 1;
				phut = 40;
				gio = 0;
			}
			
		
		}

		private void BindingData2List()
		{
			foreach (var item in list)
			{
				listBox1.Items.Add(item.ID);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ShowMark();
		}

		private void ShowMark()
		{
			int mark = 0;
			foreach (var item in list)
			{
				if(item.Correct.Equals(item.Choice))
				{
					mark++;
				}
			}
			MessageBox.Show("Your Mark: " + mark);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = listBox1.SelectedIndex;
			LoadQuestion(index, list);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Question q = list[index];
			if (rdstarta.Checked)
				q.Choice = "_a";
			if (rdstartB.Checked)
				q.Choice = "_b";
			if (rdstartC.Checked)
				q.Choice = "_c";
			if (rdstartD.Checked)
				q.Choice = "_d";
			index++;
			LoadQuestion(index, list);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Question q = list[index];
			if (rdstarta.Checked)
				q.Choice = "_a";
			if (rdstartB.Checked)
				q.Choice = "_b";
			if (rdstartC.Checked)
				q.Choice = "_c";
			if (rdstartD.Checked)
				q.Choice = "_d";
			index--;
			LoadQuestion(index, list);
		}
	}	
}
