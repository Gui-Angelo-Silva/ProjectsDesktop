namespace EmpManagement
{
	partial class Employee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
			label1 = new Label();
			panel1 = new Panel();
			dataGridView1 = new DataGridView();
			btnHome = new Button();
			btnDelete = new Button();
			btnEdit = new Button();
			btnAdd = new Button();
			EmpDob = new DateTimePicker();
			label9 = new Label();
			EmpEduCb = new ComboBox();
			label8 = new Label();
			EmpPhoneTb = new TextBox();
			label7 = new Label();
			EmpPosCb = new ComboBox();
			label6 = new Label();
			EmpGenCb = new ComboBox();
			label5 = new Label();
			EmpAddTb = new TextBox();
			label4 = new Label();
			EmpNameTb = new TextBox();
			label3 = new Label();
			EmpIdTb = new TextBox();
			label2 = new Label();
			btnExit = new PictureBox();
			pictureBox2 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(62, 31);
			label1.Name = "label1";
			label1.Size = new Size(223, 23);
			label1.TabIndex = 3;
			label1.Text = "Gerenciar Empregados";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(dataGridView1);
			panel1.Controls.Add(btnHome);
			panel1.Controls.Add(btnDelete);
			panel1.Controls.Add(btnEdit);
			panel1.Controls.Add(btnAdd);
			panel1.Controls.Add(EmpDob);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(EmpEduCb);
			panel1.Controls.Add(label8);
			panel1.Controls.Add(EmpPhoneTb);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(EmpPosCb);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(EmpGenCb);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(EmpAddTb);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(EmpNameTb);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(EmpIdTb);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(0, 83);
			panel1.Name = "panel1";
			panel1.Size = new Size(1180, 494);
			panel1.TabIndex = 4;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(474, 17);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(685, 458);
			dataGridView1.TabIndex = 27;
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
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.OrangeRed;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(133, 382);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(96, 37);
			btnDelete.TabIndex = 25;
			btnDelete.Text = "Excluir";
			btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnEdit
			// 
			btnEdit.BackColor = Color.OrangeRed;
			btnEdit.Cursor = Cursors.Hand;
			btnEdit.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnEdit.ForeColor = Color.White;
			btnEdit.Location = new Point(235, 382);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(96, 37);
			btnEdit.TabIndex = 24;
			btnEdit.Text = "Editar";
			btnEdit.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.OrangeRed;
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(337, 382);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(96, 37);
			btnAdd.TabIndex = 23;
			btnAdd.Text = "Cadastrar";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// EmpDob
			// 
			EmpDob.Location = new Point(223, 226);
			EmpDob.Name = "EmpDob";
			EmpDob.Size = new Size(210, 23);
			EmpDob.TabIndex = 21;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label9.ForeColor = Color.OrangeRed;
			label9.Location = new Point(223, 201);
			label9.Name = "label9";
			label9.Size = new Size(153, 16);
			label9.TabIndex = 20;
			label9.Text = "Data de Nascimento";
			// 
			// EmpEduCb
			// 
			EmpEduCb.FormattingEnabled = true;
			EmpEduCb.Items.AddRange(new object[] { "Doutorado", "Mestrado", "Pós-Graduado", "Especialista", "Técnico", "Médio Completo" });
			EmpEduCb.Location = new Point(223, 305);
			EmpEduCb.Name = "EmpEduCb";
			EmpEduCb.Size = new Size(210, 23);
			EmpEduCb.TabIndex = 19;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = Color.OrangeRed;
			label8.Location = new Point(223, 277);
			label8.Name = "label8";
			label8.Size = new Size(210, 16);
			label8.TabIndex = 18;
			label8.Text = "Escolaridade do Empregado";
			// 
			// EmpPhoneTb
			// 
			EmpPhoneTb.Location = new Point(12, 305);
			EmpPhoneTb.Name = "EmpPhoneTb";
			EmpPhoneTb.Size = new Size(181, 23);
			EmpPhoneTb.TabIndex = 17;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.OrangeRed;
			label7.Location = new Point(12, 277);
			label7.Name = "label7";
			label7.Size = new Size(181, 16);
			label7.TabIndex = 16;
			label7.Text = "Telefone do Empregado";
			// 
			// EmpPosCb
			// 
			EmpPosCb.FormattingEnabled = true;
			EmpPosCb.Items.AddRange(new object[] { "Gerente", "Desenvolvedor Sênior", "Desenvolvedor Pleno", "Desenvolvedor Júnior", "Estagiário" });
			EmpPosCb.Location = new Point(12, 229);
			EmpPosCb.Name = "EmpPosCb";
			EmpPosCb.Size = new Size(181, 23);
			EmpPosCb.TabIndex = 15;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.OrangeRed;
			label6.Location = new Point(12, 201);
			label6.Name = "label6";
			label6.Size = new Size(161, 16);
			label6.TabIndex = 14;
			label6.Text = "Cargo do Empregado";
			// 
			// EmpGenCb
			// 
			EmpGenCb.FormattingEnabled = true;
			EmpGenCb.Items.AddRange(new object[] { "Masculino", "Feminino" });
			EmpGenCb.Location = new Point(223, 160);
			EmpGenCb.Name = "EmpGenCb";
			EmpGenCb.Size = new Size(210, 23);
			EmpGenCb.TabIndex = 13;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.OrangeRed;
			label5.Location = new Point(223, 132);
			label5.Name = "label5";
			label5.Size = new Size(43, 16);
			label5.TabIndex = 12;
			label5.Text = "Sexo";
			// 
			// EmpAddTb
			// 
			EmpAddTb.Location = new Point(12, 160);
			EmpAddTb.Name = "EmpAddTb";
			EmpAddTb.Size = new Size(181, 23);
			EmpAddTb.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.OrangeRed;
			label4.Location = new Point(12, 132);
			label4.Name = "label4";
			label4.Size = new Size(185, 16);
			label4.TabIndex = 10;
			label4.Text = "Endereço do Empregado";
			// 
			// EmpNameTb
			// 
			EmpNameTb.Location = new Point(223, 94);
			EmpNameTb.Name = "EmpNameTb";
			EmpNameTb.Size = new Size(210, 23);
			EmpNameTb.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.OrangeRed;
			label3.Location = new Point(223, 66);
			label3.Name = "label3";
			label3.Size = new Size(160, 16);
			label3.TabIndex = 8;
			label3.Text = "Nome do Empregado";
			// 
			// EmpIdTb
			// 
			EmpIdTb.Location = new Point(12, 94);
			EmpIdTb.Name = "EmpIdTb";
			EmpIdTb.Size = new Size(181, 23);
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
			// btnExit
			// 
			btnExit.Cursor = Cursors.Hand;
			btnExit.Image = (Image)resources.GetObject("btnExit.Image");
			btnExit.Location = new Point(1130, 12);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(32, 42);
			btnExit.SizeMode = PictureBoxSizeMode.Zoom;
			btnExit.TabIndex = 5;
			btnExit.TabStop = false;
			btnExit.Click += btnExit_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, 3);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(68, 74);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 6;
			pictureBox2.TabStop = false;
			// 
			// Employee
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(1181, 604);
			Controls.Add(pictureBox2);
			Controls.Add(btnExit);
			Controls.Add(panel1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Employee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gerenciar Empregados";
			Load += Employee_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Label label2;
		private TextBox EmpNameTb;
		private Label label3;
		private TextBox EmpIdTb;
		private TextBox EmpAddTb;
		private Label label4;
		private DateTimePicker EmpDob;
		private Label label9;
		private ComboBox EmpEduCb;
		private Label label8;
		private TextBox EmpPhoneTb;
		private Label label7;
		private ComboBox EmpPosCb;
		private Label label6;
		private ComboBox EmpGenCb;
		private Label label5;
		private Button btnDelete;
		private Button btnEdit;
		private Button btnAdd;
		private DataGridView dataGridView1;
		private Button btnHome;
		private PictureBox btnExit;
		private PictureBox pictureBox2;
	}
}