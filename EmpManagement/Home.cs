using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpManagement
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Employee emp = new Employee();
			emp.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Employee emp = new Employee();
			emp.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			ViewEmployee viewEmployee = new ViewEmployee();
			viewEmployee.Show();
			this.Hide();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			ViewEmployee viewEmployee = new ViewEmployee();
			viewEmployee.Show();
			this.Hide();
		}

		private void pbSalary_Click(object sender, EventArgs e)
		{
			SalaryEmployee emp = new SalaryEmployee();
			emp.Show();
			this.Hide();
		}

		private void lblSalary_Click(object sender, EventArgs e)
		{
			SalaryEmployee emp = new SalaryEmployee();
			emp.Show();
			this.Hide();
		}
	}
}
