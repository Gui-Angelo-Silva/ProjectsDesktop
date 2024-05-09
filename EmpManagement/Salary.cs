using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpManagement
{
	public partial class Salary : Form
	{
		public Salary()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-QA5LC4CN;Initial Catalog=DBSisGEP;Integrated Security=True;TrustServerCertificate=True");

		private void Salary_Load(object sender, EventArgs e)
		{

		}
		private void fetchempdata()
		{
			Con.Open();
			string query = "select * from EmployeeTbl where EmpId='" + EmpIdTb.Text + "'";
			SqlCommand cmd = new SqlCommand(query, Con);
			DataTable dt = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			sda.Fill(dt);

			foreach (DataRow dr in dt.Rows)
			{
				lblNameEmp.Text = dr["EmpName"].ToString();
				EmpPosTb.Text = dr["EmpPos"].ToString();
			}

		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
			home.Hide();
		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			fetchempdata();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
