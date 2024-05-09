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
	public partial class ViewEmployee : Form
	{
		public ViewEmployee()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-QA5LC4CN;Initial Catalog=DBSisGEP;Integrated Security=True;TrustServerCertificate=True");

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
				Empidlbl.Text = dr["EmpId"].ToString();
				Empnamelbl.Text = dr["EmpName"].ToString();
				Empaddlbl.Text = dr["EmpAdd"].ToString();
				Empposlbl.Text = dr["EmpPos"].ToString();
				Empphonelbl.Text = dr["EmPhone"].ToString();
				Empedulbl.Text = dr["EmpEdu"].ToString();
				Empgenlbl.Text = dr["EmpGen"].ToString();
				Empdoblbl.Text = dr["EmpDOB"].ToString();
				Empidlbl.Visible = true;
				Empnamelbl.Visible = true;
				Empaddlbl.Visible = true;
				Empposlbl.Visible = true;
				Empphonelbl.Visible = true;
				Empedulbl.Visible = true;
				Empgenlbl.Visible = true;
				Empdoblbl.Visible = true;
			}

		}

		private void ViewEmployee_Load(object sender, EventArgs e)
		{

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

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			fetchempdata();
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
			e.Graphics.DrawString("=======RELATÓRIO EMPREGADO=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));
			e.Graphics.DrawString("Empregado ID: " + Empidlbl.Text + "\t Nome Empregado: " + Empnamelbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
			e.Graphics.DrawString("Endereço Empregado: " + Empaddlbl.Text + "\t Gênero: " + Empgenlbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
			e.Graphics.DrawString("Cargo Empregado: " + Empposlbl.Text + "\t Data de Nascimento: " + Empdoblbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
			e.Graphics.DrawString("Telefone Empregado: " + Empphonelbl.Text + "\t Nível de Estudo: " + Empedulbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));

			e.Graphics.DrawString("=======GuigasSOFT=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(200, 280));
		}
		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
