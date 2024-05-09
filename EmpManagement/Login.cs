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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (UIdTb.Text == "" || PassTb.Text == "")
			{
				MessageBox.Show("Insira Informações para o Acesso!");
			}
			else if (UIdTb.Text == "Admin" && PassTb.Text == "Admin123")
			{
				this.Hide();
				Home home = new Home();
				home.Show();
			}
			else
			{
				MessageBox.Show("Nome de Usuário ou Senha Incorretos!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UIdTb.Text = "";
			PassTb.Text = "";
		}
	}
}
