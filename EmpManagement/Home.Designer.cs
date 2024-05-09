namespace EmpManagement
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			panel1 = new Panel();
			lblSalary = new Label();
			pbSalary = new PictureBox();
			label4 = new Label();
			pictureBox3 = new PictureBox();
			label3 = new Label();
			pictureBox2 = new PictureBox();
			pictureBox5 = new PictureBox();
			label6 = new Label();
			btnExit = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbSalary).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(66, 58);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(94, 31);
			label1.Name = "label1";
			label1.Size = new Size(82, 23);
			label1.TabIndex = 2;
			label1.Text = "SisGEP";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.OrangeRed;
			label2.Location = new Point(351, 20);
			label2.Name = "label2";
			label2.Size = new Size(141, 23);
			label2.TabIndex = 2;
			label2.Text = "Página Inicial";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(lblSalary);
			panel1.Controls.Add(pbSalary);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(-3, 88);
			panel1.Name = "panel1";
			panel1.Size = new Size(803, 315);
			panel1.TabIndex = 0;
			// 
			// lblSalary
			// 
			lblSalary.AutoSize = true;
			lblSalary.Cursor = Cursors.Hand;
			lblSalary.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			lblSalary.ForeColor = Color.OrangeRed;
			lblSalary.Location = new Point(598, 221);
			lblSalary.Name = "lblSalary";
			lblSalary.Size = new Size(77, 23);
			lblSalary.TabIndex = 8;
			lblSalary.Text = "Salário";
			lblSalary.Click += lblSalary_Click;
			// 
			// pbSalary
			// 
			pbSalary.Cursor = Cursors.Hand;
			pbSalary.Image = (Image)resources.GetObject("pbSalary.Image");
			pbSalary.Location = new Point(583, 93);
			pbSalary.Name = "pbSalary";
			pbSalary.Size = new Size(99, 110);
			pbSalary.SizeMode = PictureBoxSizeMode.Zoom;
			pbSalary.TabIndex = 7;
			pbSalary.TabStop = false;
			pbSalary.Click += pbSalary_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Cursor = Cursors.Hand;
			label4.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.OrangeRed;
			label4.Location = new Point(374, 221);
			label4.Name = "label4";
			label4.Size = new Size(106, 23);
			label4.TabIndex = 6;
			label4.Text = "Visualizar";
			label4.Click += label4_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Cursor = Cursors.Hand;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(374, 93);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(99, 110);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Cursor = Cursors.Hand;
			label3.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.OrangeRed;
			label3.Location = new Point(124, 221);
			label3.Name = "label3";
			label3.Size = new Size(126, 23);
			label3.TabIndex = 4;
			label3.Text = "Empregados";
			label3.Click += label3_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Cursor = Cursors.Hand;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(134, 93);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(99, 110);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(21, 409);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(34, 42);
			pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 3;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(61, 419);
			label6.Name = "label6";
			label6.Size = new Size(48, 23);
			label6.TabIndex = 4;
			label6.Text = "Sair";
			label6.Click += label6_Click;
			// 
			// btnExit
			// 
			btnExit.Cursor = Cursors.Hand;
			btnExit.Image = (Image)resources.GetObject("btnExit.Image");
			btnExit.Location = new Point(756, 12);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(32, 42);
			btnExit.SizeMode = PictureBoxSizeMode.Zoom;
			btnExit.TabIndex = 6;
			btnExit.TabStop = false;
			btnExit.Click += btnExit_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(800, 454);
			Controls.Add(btnExit);
			Controls.Add(label6);
			Controls.Add(pictureBox5);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Home";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbSalary).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Panel panel1;
		private Label lblSalary;
		private PictureBox pbSalary;
		private Label label4;
		private PictureBox pictureBox3;
		private Label label3;
		private PictureBox pictureBox2;
		private PictureBox pictureBox5;
		private Label label6;
		private PictureBox btnExit;
	}
}