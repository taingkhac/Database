using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestOnlineV1
{
	public class DataProcess
	{
		public SqlConnection GetConnection()
		{
			SqlConnection conn = null;
			conn = new SqlConnection("server=ASUSK401U\\SQLEXPRESS01;database=myDemo;uid=sa;pwd=taicuibap");
			return conn;
		}
		public bool login(string user, string pass)
		{
			string sql = "SELECT * FROM nguoidung WHERE user__name = @u and pass_word = @p";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@u", user);
			cmd.Parameters.AddWithValue("@p", pass);
			SqlDataReader reader = cmd.ExecuteReader();
			bool re = reader.HasRows;
			reader.Close();
			cmd.Connection.Close();
			return re;
		}
		public bool AddQuestion(string id, string type, string content, string a, string b, string c, string d, string asw)
		{
			string sql = "INSERT INTO cauhoi VALUES(@i,@t,@ct,@a,@b,@c,@d,@asw)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@t", type);
			cmd.Parameters.AddWithValue("@ct", content);
			cmd.Parameters.AddWithValue("@a", a);
			cmd.Parameters.AddWithValue("@b", b);
			cmd.Parameters.AddWithValue("@c", c);
			cmd.Parameters.AddWithValue("@d", d);
			cmd.Parameters.AddWithValue("@asw", asw);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public bool AddQuestion2Exam(string id, string question)
		{
			string sql = "INSERT INTO de_thi VALUES(@i,@qs)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@qs", question);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public bool AddExam(string id, string date)
		{
			string sql = "INSERT INTO ky_thi(ma_kithi,ngay_thi,tinh_trang) VALUES(@i,@qs,@tt)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@qs", date);
			cmd.Parameters.AddWithValue("@tt", "W");
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public Question GetQuestionByID(string id)
		{
			Question qs = new Question();
			string sql = "SELECT * FROM cauhoi WHERE ma_cauhoi=@id";
			SqlCommand cmd = new SqlCommand(sql,GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("id", id);
			SqlDataReader red = cmd.ExecuteReader();
			while(red.Read())
			{
				qs.ID = red.GetString(0);
				qs.Content = red.GetString(2);
				qs.A = red.GetString(3);
				qs.B = red.GetString(4);
				qs.C = red.GetString(5);
				qs.D = red.GetString(6);
				qs.Correct = red.GetString(7);
			}
			cmd.Connection.Close();
			return qs;
		}
		public List<Question> GetQuestionsByExam(string examID)
		{
			List<Question> list = new List<Question>();
			string sql = "SELECT * FROM de_thi WHERE ma_dethi = @mt";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@mt", examID);
			SqlDataReader red = cmd.ExecuteReader();
			while (red.Read())
			{
				//Question qs = new Question();
				Question q = GetQuestionByID(red.GetString(1));
				list.Add(q);
			}
			red.Close();
			cmd.Connection.Close();
			return list;
		}
		public bool CheckExam(string id)
		{
			bool result = false;
			string sql = "SELECT * FROM ky_thi WHERE ma_kithi=@kt";
			//string sql = "SELECT * FROM de_thi WHERE ma_dethi = @mt";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@kt", id);
			SqlDataReader red = cmd.ExecuteReader();
			while(red.Read())
			{
				string tt = red.GetString(3);
				result = tt.Equals("D");

			}
			cmd.Connection.Close();
			return result;
		}
		public DataTable Getexam(string ex)
		{
			string sql = "SELECT de_thi.ma_dethi,de_thi.ma_cauhoi,cauhoi.noi_dung,cauhoi.dapan_1,cauhoi.dapan_2,cauhoi.dapan_3,cauhoi.dapan_4 FROM de_thi, cauhoi WHERE (ma_dethi = @ex AND de_thi.ma_cauhoi = cauhoi.ma_cauhoi)";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.Add("@ex", SqlDbType.VarChar, 10);
			cmd.Parameters["@ex"].Value = ex;
			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			DataTable dsa = new DataTable();
			ad.Fill(dsa);
			return dsa;
		}
		public DataTable GetQs()
		{
			DataTable dt = new DataTable();
			string sql = "SELECT * FROM cauhoi";
			SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
			da.Fill(dt);
			return dt;
		}
		public List<Question> GetQuestions(string type)
		{
			List<Question> list = new List<Question>();
			string sql = "SELECT * FROM cauhoi WHERE mon_thi = @mt";
			SqlCommand cmd = new SqlCommand(sql, GetConnection());
			cmd.Connection.Open();
			cmd.Parameters.AddWithValue("@mt", type);
			SqlDataReader red = cmd.ExecuteReader();
			while (red.Read())
			{
				Question qs = new Question();
				qs.ID = red.GetString(0);
				qs.Content = red.GetString(2);
				qs.A = red.GetString(3);
				qs.B = red.GetString(4);
				qs.C = red.GetString(5);
				qs.D = red.GetString(6);
				qs.Correct = red.GetString(7);
				list.Add(qs);
			}
			red.Close();
			cmd.Connection.Close();
			return list;
		}
		public bool CheckExist(string id, List<Question> list)
		{
			foreach (var item in list)
				if (item.ID.Equals(id))
					return false;
			return true;
		}
		public List<Question> Get25Questions(string type)
		{
			List<Question> q25 = new List<Question>();
			int count = 0;
			while (count < 10)
			{
				Random random = new Random();
				int i = random.Next(0, GetQuestions(type).Count - 1);
				Question q = GetQuestions(type)[i];
				if (CheckExist(q.ID, q25))
				{
					q25.Add(q);
					count++;
				}
			}
			return q25;
		}
		public DataTable SearchData(string id)
		{
			string sql = "SELECT * FROM cauhoi WHERE ma_cauhoi = @i";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.Add("@i", SqlDbType.VarChar, 10);
			cmd.Parameters["@i"].Value = id;
			SqlDataAdapter ad = new SqlDataAdapter(cmd);
			DataTable dsa = new DataTable();
			ad.Fill(dsa);
			return dsa;
		}
		public bool UpdateQuestion(string id, string type, string content, string a, string b, string c, string d, string asw)
		{
			string sql = "UPDATE cauhoi SET mon_thi = @t, noi_dung = @ct, dapan_1 = @a, dapan_2 = @b, dapan_3 = @c, dapan_4 = @d, dapan_dung = @asw WHERE ma_cauhoi=@i ";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			cmd.Parameters.AddWithValue("@t", type);
			cmd.Parameters.AddWithValue("@ct", content);
			cmd.Parameters.AddWithValue("@a", a);
			cmd.Parameters.AddWithValue("@b", b);
			cmd.Parameters.AddWithValue("@c", c);
			cmd.Parameters.AddWithValue("@d", d);
			cmd.Parameters.AddWithValue("@asw", asw);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
		public bool DeleteQuestion(string id)
		{
			string sql = "DELETE FROM cauhoi WHERE ma_cauhoi = @i";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = GetConnection();
			cmd.Connection.Open();
			cmd.CommandText = sql;
			cmd.Parameters.AddWithValue("@i", id);
			int result = cmd.ExecuteNonQuery();
			cmd.Connection.Close();
			return result > 0;
		}
	}
}
