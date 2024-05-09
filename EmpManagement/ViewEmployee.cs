﻿using System;
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
	}
}
