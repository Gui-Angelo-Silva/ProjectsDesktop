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
	public partial class SalaryEmployee : Form
	{
		public SalaryEmployee()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-QA5LC4CN;Initial Catalog=DBSisGEP;Integrated Security=True;TrustServerCertificate=True");

		private void Salary_Load(object sender, EventArgs e)
		{

		}
		private void fetchempdata()
		{
			if (EmpIdTb.Text == "")
			{
				MessageBox.Show("Informe o ID do Empregado");
			}
			else
			{
				Con.Open();
				string query = "select * from EmployeeTbl where EmpId='" + EmpIdTb.Text + "'";
				SqlCommand cmd = new SqlCommand(query, Con);
				DataTable dt = new DataTable();
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				sda.Fill(dt);

				foreach (DataRow dr in dt.Rows)
				{
					EmpNameTb.Text = dr["EmpName"].ToString();
					EmpPosTb.Text = dr["EmpPos"].ToString();
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			fetchempdata();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
			this.Hide();
		}

		int Dailybase, total;
		private void btnView_Click(object sender, EventArgs e)
		{
			if (EmpIdTb.Text == "")
			{
				MessageBox.Show("Selecione um Empregado");
			}
			else if (EmpDaysTb.Text == "" || Convert.ToInt32(EmpDaysTb.Text) < 20)
			{
				MessageBox.Show("Insira Números de Dias Válidos de Trabalho");
			}
			else
			{
				if (EmpPosTb.Text == "Gerente")
				{
					Dailybase = 1200;
				}
				else if (EmpPosTb.Text == "Desenvolver Sênior")
				{
					Dailybase = 1000;
				}
				else if (EmpPosTb.Text == "Desenvolvedor Júnior")
				{
					Dailybase = 950;
				}
				else
				{
					Dailybase = 850;
				}

				total = Dailybase * Convert.ToInt32(EmpDaysTb.Text);
				SalarySlip.Text = "Id do Empregado: " + EmpIdTb.Text + "\n" + "Nome Empregado: " + EmpNameTb.Text + "\n" + "Cargo Empregado: " + EmpPosTb.Text + "\n" + "Dias Trabalhados: " + EmpDaysTb.Text + "\n" + "Salário por dia R$" + Dailybase + "\n" + "Salário Total R$" + total;
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("=======SALÁRIO=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
			e.Graphics.DrawString("Empregado ID: " + EmpIdTb.Text + "\t Nome Empregado: " + EmpNameTb.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
			e.Graphics.DrawString("Cargo Empregado: " + EmpPosTb.Text + "\t Dias Trabalhados: " + EmpDaysTb.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
			e.Graphics.DrawString("\"Salário por dia R$: " + Dailybase + "\t Data de Salário Total R$: " + total, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
			
			e.Graphics.DrawString("=======GuigasSOFT=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(200, 280));
		}
	}
}
