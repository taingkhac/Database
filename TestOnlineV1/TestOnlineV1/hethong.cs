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
	public partial class hethong : Form
	{
		public hethong()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void loginToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddQuestion add = new AddQuestion();
			add.Show();
		}

		private void manageQuestionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ManagaQuestion mq = new ManagaQuestion();
			mq.ShowDialog();
		}

		private void manageExamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ManageExam me = new ManageExam();
			me.ShowDialog();
		}

		private void hethong_Load(object sender, EventArgs e)
		{
		}
	}
}
