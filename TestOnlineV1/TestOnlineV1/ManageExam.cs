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
	public partial class ManageExam : Form
	{
		private List<Question> lt = null;
		public ManageExam()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void ManageExam_Load(object sender, EventArgs e)
		{

		}
		private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			string type = comboBox1.SelectedItem.ToString();
			type = comboBox1.Text;
			if (type.Equals("Top Notch 1"))
				type = "TN1";
			if (type.Equals("Top Notch 2"))
				type = "TN2";
			if (type.Equals("Top Notch 3"))
				type = "TN3";
			if (type.Equals("Summit 1"))
				type = "S1";
			DataProcess dp = new DataProcess();
			lt = dp.Get25Questions(type);
			dataGridView1.DataSource = lt;
			button2.Enabled = true;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			DataProcess dp = new DataProcess();
			string id = txtidexam.Text;
			//for (int i = 0; i < dataGridView1.Rows.Count; i++)
			//{
			//	string question = dataGridView1.Rows[i].Cells[0].Value.ToString();
			//	dp.AddExam(id, question);
			//}
			for(int i=0;i<lt.Count;i++)
			{
				dp.AddQuestion2Exam(id, lt[i].ID);
			}
			dp.AddExam(id, txtDate.Text);
			MessageBox.Show("Added");
		}
		private void txtquestionadd_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
