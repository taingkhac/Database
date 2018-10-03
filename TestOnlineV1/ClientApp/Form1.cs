using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
	public partial class Form1 : Form
	{
		int index = 0;
		int timeMax = 100;
		List<Question> list = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoginStudent lg = new LoginStudent();
			lg.ShowDialog();
			DataProcess dt = new DataProcess();
			list= dt.GetQuestions();
			LoadQuestion(index,list);
			timer1.Start();
		}

		private void LoadQuestion(int index, List<Question> list)
		{
			Question q = list[index];
			rtContent.Text = q.Content;
			rdA.Text = q.A;
			rdB.Text = q.B;
			rdC.Text = q.C;
			rdD.Text = q.D;

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			index++;
			LoadQuestion(index, list);
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			index--;
			LoadQuestion(index, list);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timeMax--;
			lblTime.Text = "Time left : "+timeMax;
		}

		private void rdA_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
