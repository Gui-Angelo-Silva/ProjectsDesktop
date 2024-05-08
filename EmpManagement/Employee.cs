using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpManagement
{
	public partial class Employee : Form
	{
		public Employee()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-QA5LC4CN;Initial Catalog=DBSisGEP;Integrated Security=True;TrustServerCertificate=True");

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpAddTb.Text == "" || EmpPhoneTb.Text == "")
			{
				MessageBox.Show("Está faltando informações");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "insert into EmployeeTbl values ('" + EmpIdTb.Text + "','" + EmpNameTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosCb.SelectedItem.ToString() + "', '" + EmpDob.Value.Date + "', '" + EmpPhoneTb.Text + "', '" + EmpEduCb.SelectedItem.ToString() + "', '" + EmpGenCb.SelectedItem.ToString() + "')";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Empregado Cadastrado com Sucesso!");
					Con.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//private void populate()
		//{
		//	Con.Open();
		//	string query = "select * from EmployeeTbl";
		//	SqlDataAdapter sda = new SqlDataAdapter(query, Con);
		//	SqlCommandBuilder builder = new 
		//	Con.Close();
		//}

		private void Employee_Load(object sender, EventArgs e)
		{

		}
	}
}
