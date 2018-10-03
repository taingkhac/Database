using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
	public partial class Form1 : Form
	{
		private Staff currentUser = null;
		List<Question> list = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoginForm lg = new LoginForm();
			lg.ShowDialog();
			currentUser = lg.currentUser;
			this.Text = "Welcome to : " + currentUser.UserName;
			this.WindowState = FormWindowState.Maximized;
			LoadExam();
		}

		private void LoadExam()
		{
			AdminModel model = new AdminModel();
			grvExam.DataSource = model.GetExams();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			string id = txtExam.Text;
			AdminModel model = new AdminModel();
			if(model.CheckExist(id)==false)
			{
				MessageBox.Show("this exam is da ton tai!!!");
			}
			else
			{
				//btnAdd.Enabled = true;
				btnLoad.Enabled = true;
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string type = cboSubject.SelectedItem.ToString();
			if (type.Equals("Top lot 1"))
				type = "TN1";
			if (type.Equals("Top lot 2"))
				type = "TN2";
			if (type.Equals("Top lot ba"))
				type = "TN3";
			if (type.Equals("Sum mit 1"))
				type = "SM1";
			type = "TN1";
			AdminModel model = new AdminModel();
			list = model.Get25Questions(type);
			if(list.Count>0)
			{
				btnAdd.Enabled = true;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string id = txtExam.Text;
			string date = dateTimePicker1.Value.ToShortDateString();
			AdminModel model = new AdminModel();
			model.AddExam(id, date);
			for (int i = 0; i < list.Count; i++)
			{
				model.AddQuestion2Exam(id, list[i].ID);
			}
			
			MessageBox.Show("Added");
		}

		private void grvExam_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtExam.Text = grvExam.Rows[e.RowIndex].Cells[0].Value.ToString();
			dateTimePicker1.Text = grvExam.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtStatus.Text = grvExam.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtExam.ReadOnly = true;
			//cboSubject.Enabled = false;
			txtStatus.ReadOnly = false;
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			AdminModel model = new AdminModel();
			string id = txtExam.Text;
			string date = dateTimePicker1.Value.ToShortDateString();
			string status = txtStatus.Text;
			if(model.UpdateExam(id,date,status))
			{
				LoadExam();
				ResetControl();
			}
		}

		private void ResetControl()
		{
			txtExam.Text = "";
			txtExam.ReadOnly = false;
			txtStatus.Text = "";
			dateTimePicker1.Value = DateTime.Now;
		}
	}
}
