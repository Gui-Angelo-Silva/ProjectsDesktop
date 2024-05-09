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
					populate();
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

		private void populate()
		{
			Con.Open();
			string query = "select * from EmployeeTbl";
			SqlDataAdapter sda = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(sda);
			var ds = new DataSet();
			sda.Fill(ds);
			EmpDGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void Employee_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (EmpIdTb.Text == "")
			{
				MessageBox.Show("Insira o Id do funcionário");
			}
			else
			{
				try
				{
					Con.Open();
					string query = "delete from EmployeeTbl where EmpId='" + EmpIdTb.Text + "'";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Empregado deletado com sucesso!");
					Con.Close();
					populate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (EmpDGV.SelectedRows.Count > 0)
				{
					DataGridViewRow row = EmpDGV.SelectedRows[0];

					if (row.Cells.Count >= 8)
					{
						EmpIdTb.Text = row.Cells[0].Value.ToString();
						EmpNameTb.Text = row.Cells[1].Value.ToString();
						EmpAddTb.Text = row.Cells[2].Value.ToString();
						EmpEduCb.Text = row.Cells[6].Value.ToString();
						EmpPosCb.Text = row.Cells[3].Value.ToString();
						EmpPhoneTb.Text = row.Cells[5].Value.ToString();
						EmpGenCb.Text = row.Cells[7].Value.ToString();
					}
					else
					{
						MessageBox.Show("A linha selecionada não tem células suficientes para carregar os dados.");
					}
				}
				else
				{
					MessageBox.Show("Nenhuma linha foi selecionada.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
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
					string query = "update EmployeeTbl set EmpName='" + EmpNameTb.Text + "', EmpAdd='" + EmpAddTb.Text + "', EmpPos='" + EmpPosCb.SelectedItem.ToString() + "', EmpDOB='" + EmpDob.Value.Date + "', EmPhone='" + EmpPhoneTb.Text + "', EmpEdu='" + EmpEduCb.SelectedItem.ToString() + "', EmpGen='" + EmpGenCb.SelectedItem.ToString() + "' where EmpId='" + EmpIdTb.Text + "';";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Empregado Atualizado com Sucesso!");
					Con.Close();
					populate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
			this.Hide();
		}
	}
}
