namespace EmpManagement
{
	partial class Salary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
			pictureBox2 = new PictureBox();
			btnExit = new PictureBox();
			label1 = new Label();
			panel1 = new Panel();
			SalarySlip = new RichTextBox();
			btnHome = new Button();
			btnSearch = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			EmpDaysTb = new TextBox();
			label7 = new Label();
			label6 = new Label();
			EmpNameTb = new TextBox();
			EmpPosTb = new TextBox();
			lblNameEmp = new Label();
			EmpIdTb = new TextBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(7, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(56, 65);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 12;
			pictureBox2.TabStop = false;
			// 
			// btnExit
			// 
			btnExit.Cursor = Cursors.Hand;
			btnExit.Image = (Image)resources.GetObject("btnExit.Image");
			btnExit.Location = new Point(1137, 12);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(32, 42);
			btnExit.SizeMode = PictureBoxSizeMode.Zoom;
			btnExit.TabIndex = 11;
			btnExit.TabStop = false;
			btnExit.Click += btnExit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(69, 31);
			label1.Name = "label1";
			label1.Size = new Size(238, 23);
			label1.TabIndex = 10;
			label1.Text = "Salário dos Empregados";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(SalarySlip);
			panel1.Controls.Add(btnHome);
			panel1.Controls.Add(btnSearch);
			panel1.Controls.Add(btnEdit);
			panel1.Controls.Add(btnAdd);
			panel1.Controls.Add(EmpDaysTb);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(EmpNameTb);
			panel1.Controls.Add(EmpPosTb);
			panel1.Controls.Add(lblNameEmp);
			panel1.Controls.Add(EmpIdTb);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(0, 78);
			panel1.Name = "panel1";
			panel1.Size = new Size(1180, 523);
			panel1.TabIndex = 13;
			// 
			// SalarySlip
			// 
			SalarySlip.BorderStyle = BorderStyle.None;
			SalarySlip.Location = new Point(473, 52);
			SalarySlip.Name = "SalarySlip";
			SalarySlip.Size = new Size(663, 397);
			SalarySlip.TabIndex = 27;
			SalarySlip.Text = "";
			// 
			// btnHome
			// 
			btnHome.BackColor = Color.OrangeRed;
			btnHome.Cursor = Cursors.Hand;
			btnHome.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnHome.ForeColor = Color.White;
			btnHome.Location = new Point(12, 382);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(115, 37);
			btnHome.TabIndex = 26;
			btnHome.Text = "Página Inicial";
			btnHome.UseVisualStyleBackColor = false;
			btnHome.Click += btnHome_Click;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = Color.OrangeRed;
			btnSearch.Cursor = Cursors.Hand;
			btnSearch.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSearch.ForeColor = Color.White;
			btnSearch.Location = new Point(252, 86);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(96, 37);
			btnSearch.TabIndex = 25;
			btnSearch.Text = "Buscar";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.OrangeRed;
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(135, 382);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(96, 37);
			btnEdit.TabIndex = 24;
			btnEdit.Text = "Visualizar";
			btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.OrangeRed;
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(761, 470);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(96, 37);
			btnAdd.TabIndex = 23;
			btnAdd.Text = "Imprimir";
			btnAdd.UseVisualStyleBackColor = false;
			// 
			// EmpDaysTb
			// 
			EmpDaysTb.Location = new Point(12, 307);
			EmpDaysTb.Name = "EmpDaysTb";
			EmpDaysTb.Size = new Size(219, 23);
			EmpDaysTb.TabIndex = 17;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.OrangeRed;
			label7.Location = new Point(12, 279);
			label7.Name = "label7";
			label7.Size = new Size(134, 16);
			label7.TabIndex = 16;
			label7.Text = "Dias Trabalhados";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.OrangeRed;
			label6.Location = new Point(12, 205);
			label6.Name = "label6";
			label6.Size = new Size(161, 16);
			label6.TabIndex = 14;
			label6.Text = "Cargo do Empregado";
			// 
			// EmpNameTb
			// 
			EmpNameTb.Enabled = false;
			EmpNameTb.Location = new Point(12, 160);
			EmpNameTb.Name = "EmpNameTb";
			EmpNameTb.Size = new Size(219, 23);
			EmpNameTb.TabIndex = 11;
			// 
			// EmpPosTb
			// 
			EmpPosTb.Enabled = false;
			EmpPosTb.Location = new Point(12, 233);
			EmpPosTb.Name = "EmpPosTb";
			EmpPosTb.Size = new Size(219, 23);
			EmpPosTb.TabIndex = 9;
			// 
			// lblNameEmp
			// 
			lblNameEmp.AutoSize = true;
			lblNameEmp.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblNameEmp.ForeColor = Color.OrangeRed;
			lblNameEmp.Location = new Point(13, 131);
			lblNameEmp.Name = "lblNameEmp";
			lblNameEmp.Size = new Size(160, 16);
			lblNameEmp.TabIndex = 8;
			lblNameEmp.Text = "Nome do Empregado";
			// 
			// EmpIdTb
			// 
			EmpIdTb.Location = new Point(12, 94);
			EmpIdTb.Name = "EmpIdTb";
			EmpIdTb.Size = new Size(219, 23);
			EmpIdTb.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.OrangeRed;
			label2.Location = new Point(12, 66);
			label2.Name = "label2";
			label2.Size = new Size(136, 16);
			label2.TabIndex = 6;
			label2.Text = "ID do Empregado";
			// 
			// Salary
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(1181, 635);
			Controls.Add(panel1);
			Controls.Add(pictureBox2);
			Controls.Add(btnExit);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Salary";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Salary";
			Load += Salary_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox2;
		private PictureBox btnExit;
		private Label label1;
		private Panel panel1;
		private Button btnHome;
		private Button btnSearch;
		private Button btnEdit;
		private Button btnAdd;
		private TextBox EmpDaysTb;
		private Label label7;
		private Label label6;
		private TextBox EmpNameTb;
		private TextBox EmpPosTb;
		private Label lblNameEmp;
		private TextBox EmpIdTb;
		private Label label2;
		private RichTextBox SalarySlip;
	}
}