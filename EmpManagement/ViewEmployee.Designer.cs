namespace EmpManagement
{
	partial class ViewEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
			pictureBox2 = new PictureBox();
			btnExit = new PictureBox();
			label1 = new Label();
			panel1 = new Panel();
			btnHome = new Button();
			btnPrint = new Button();
			Empdoblbl = new Label();
			Empedulbl = new Label();
			Empgenlbl = new Label();
			Empnamelbl = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			Empphonelbl = new Label();
			Empposlbl = new Label();
			Empaddlbl = new Label();
			Empidlbl = new Label();
			label7 = new Label();
			label6 = new Label();
			label4 = new Label();
			label3 = new Label();
			btnRefresh = new Button();
			EmpIdTb = new TextBox();
			label2 = new Label();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			printPreviewDialog1 = new PrintPreviewDialog();
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
			pictureBox2.Size = new Size(68, 74);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 9;
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
			btnExit.TabIndex = 8;
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
			label1.Size = new Size(252, 23);
			label1.TabIndex = 7;
			label1.Text = "Detalhes dos Empregados";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(btnHome);
			panel1.Controls.Add(btnPrint);
			panel1.Controls.Add(Empdoblbl);
			panel1.Controls.Add(Empedulbl);
			panel1.Controls.Add(Empgenlbl);
			panel1.Controls.Add(Empnamelbl);
			panel1.Controls.Add(label11);
			panel1.Controls.Add(label12);
			panel1.Controls.Add(label13);
			panel1.Controls.Add(label14);
			panel1.Controls.Add(Empphonelbl);
			panel1.Controls.Add(Empposlbl);
			panel1.Controls.Add(Empaddlbl);
			panel1.Controls.Add(Empidlbl);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(btnRefresh);
			panel1.Controls.Add(EmpIdTb);
			panel1.Controls.Add(label2);
			panel1.Location = new Point(-2, 83);
			panel1.Name = "panel1";
			panel1.Size = new Size(1189, 535);
			panel1.TabIndex = 10;
			// 
			// btnHome
			// 
			btnHome.BackColor = Color.OrangeRed;
			btnHome.Cursor = Cursors.Hand;
			btnHome.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnHome.ForeColor = Color.White;
			btnHome.Location = new Point(446, 451);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(115, 37);
			btnHome.TabIndex = 42;
			btnHome.Text = "Página Inicial";
			btnHome.UseVisualStyleBackColor = false;
			btnHome.Click += btnHome_Click;
			// 
			// btnPrint
			// 
			btnPrint.BackColor = Color.OrangeRed;
			btnPrint.Cursor = Cursors.Hand;
			btnPrint.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnPrint.ForeColor = Color.White;
			btnPrint.Location = new Point(646, 451);
			btnPrint.Name = "btnPrint";
			btnPrint.Size = new Size(96, 37);
			btnPrint.TabIndex = 41;
			btnPrint.Text = "Imprimir";
			btnPrint.UseVisualStyleBackColor = false;
			btnPrint.Click += btnPrint_Click;
			// 
			// Empdoblbl
			// 
			Empdoblbl.AutoSize = true;
			Empdoblbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empdoblbl.ForeColor = Color.DarkBlue;
			Empdoblbl.Location = new Point(854, 244);
			Empdoblbl.Name = "Empdoblbl";
			Empdoblbl.Size = new Size(153, 16);
			Empdoblbl.TabIndex = 40;
			Empdoblbl.Text = "Data de Nascimento";
			// 
			// Empedulbl
			// 
			Empedulbl.AutoSize = true;
			Empedulbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empedulbl.ForeColor = Color.DarkBlue;
			Empedulbl.Location = new Point(854, 320);
			Empedulbl.Name = "Empedulbl";
			Empedulbl.Size = new Size(210, 16);
			Empedulbl.TabIndex = 39;
			Empedulbl.Text = "Escolaridade do Empregado";
			// 
			// Empgenlbl
			// 
			Empgenlbl.AutoSize = true;
			Empgenlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empgenlbl.ForeColor = Color.DarkBlue;
			Empgenlbl.Location = new Point(854, 175);
			Empgenlbl.Name = "Empgenlbl";
			Empgenlbl.Size = new Size(43, 16);
			Empgenlbl.TabIndex = 38;
			Empgenlbl.Text = "Sexo";
			// 
			// Empnamelbl
			// 
			Empnamelbl.AutoSize = true;
			Empnamelbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empnamelbl.ForeColor = Color.DarkBlue;
			Empnamelbl.Location = new Point(854, 109);
			Empnamelbl.Name = "Empnamelbl";
			Empnamelbl.Size = new Size(160, 16);
			Empnamelbl.TabIndex = 37;
			Empnamelbl.Text = "Nome do Empregado";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label11.ForeColor = Color.OrangeRed;
			label11.Location = new Point(610, 244);
			label11.Name = "label11";
			label11.Size = new Size(153, 16);
			label11.TabIndex = 36;
			label11.Text = "Data de Nascimento";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label12.ForeColor = Color.OrangeRed;
			label12.Location = new Point(610, 320);
			label12.Name = "label12";
			label12.Size = new Size(210, 16);
			label12.TabIndex = 35;
			label12.Text = "Escolaridade do Empregado";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label13.ForeColor = Color.OrangeRed;
			label13.Location = new Point(610, 175);
			label13.Name = "label13";
			label13.Size = new Size(43, 16);
			label13.TabIndex = 34;
			label13.Text = "Sexo";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label14.ForeColor = Color.OrangeRed;
			label14.Location = new Point(610, 109);
			label14.Name = "label14";
			label14.Size = new Size(160, 16);
			label14.TabIndex = 33;
			label14.Text = "Nome do Empregado";
			// 
			// Empphonelbl
			// 
			Empphonelbl.AutoSize = true;
			Empphonelbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empphonelbl.ForeColor = Color.DarkBlue;
			Empphonelbl.Location = new Point(367, 320);
			Empphonelbl.Name = "Empphonelbl";
			Empphonelbl.Size = new Size(181, 16);
			Empphonelbl.TabIndex = 32;
			Empphonelbl.Text = "Telefone do Empregado";
			// 
			// Empposlbl
			// 
			Empposlbl.AutoSize = true;
			Empposlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empposlbl.ForeColor = Color.DarkBlue;
			Empposlbl.Location = new Point(367, 244);
			Empposlbl.Name = "Empposlbl";
			Empposlbl.Size = new Size(161, 16);
			Empposlbl.TabIndex = 31;
			Empposlbl.Text = "Cargo do Empregado";
			// 
			// Empaddlbl
			// 
			Empaddlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empaddlbl.ForeColor = Color.DarkBlue;
			Empaddlbl.Location = new Point(367, 175);
			Empaddlbl.Name = "Empaddlbl";
			Empaddlbl.Size = new Size(185, 16);
			Empaddlbl.TabIndex = 30;
			Empaddlbl.Text = "Endereço do Empregado";
			// 
			// Empidlbl
			// 
			Empidlbl.AutoSize = true;
			Empidlbl.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			Empidlbl.ForeColor = Color.DarkBlue;
			Empidlbl.Location = new Point(367, 109);
			Empidlbl.Name = "Empidlbl";
			Empidlbl.Size = new Size(136, 16);
			Empidlbl.TabIndex = 29;
			Empidlbl.Text = "ID do Empregado";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.OrangeRed;
			label7.Location = new Point(124, 320);
			label7.Name = "label7";
			label7.Size = new Size(181, 16);
			label7.TabIndex = 28;
			label7.Text = "Telefone do Empregado";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.OrangeRed;
			label6.Location = new Point(124, 244);
			label6.Name = "label6";
			label6.Size = new Size(161, 16);
			label6.TabIndex = 27;
			label6.Text = "Cargo do Empregado";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.OrangeRed;
			label4.Location = new Point(124, 175);
			label4.Name = "label4";
			label4.Size = new Size(185, 16);
			label4.TabIndex = 26;
			label4.Text = "Endereço do Empregado";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.OrangeRed;
			label3.Location = new Point(124, 109);
			label3.Name = "label3";
			label3.Size = new Size(136, 16);
			label3.TabIndex = 25;
			label3.Text = "ID do Empregado";
			// 
			// btnRefresh
			// 
			btnRefresh.BackColor = Color.OrangeRed;
			btnRefresh.Cursor = Cursors.Hand;
			btnRefresh.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnRefresh.ForeColor = Color.White;
			btnRefresh.Location = new Point(717, 7);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(96, 37);
			btnRefresh.TabIndex = 24;
			btnRefresh.Text = "Buscar";
			btnRefresh.UseVisualStyleBackColor = false;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// EmpIdTb
			// 
			EmpIdTb.Location = new Point(517, 15);
			EmpIdTb.Name = "EmpIdTb";
			EmpIdTb.Size = new Size(181, 23);
			EmpIdTb.TabIndex = 9;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.OrangeRed;
			label2.Location = new Point(375, 17);
			label2.Name = "label2";
			label2.Size = new Size(136, 16);
			label2.TabIndex = 8;
			label2.Text = "ID do Empregado";
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog1.ClientSize = new Size(400, 300);
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.Enabled = true;
			printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
			printPreviewDialog1.Name = "printPreviewDialog1";
			printPreviewDialog1.Visible = false;
			printPreviewDialog1.Load += printPreviewDialog1_Load;
			// 
			// ViewEmployee
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.OrangeRed;
			ClientSize = new Size(1181, 650);
			Controls.Add(panel1);
			Controls.Add(pictureBox2);
			Controls.Add(btnExit);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ViewEmployee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ViewEmployee";
			Load += ViewEmployee_Load;
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
		private TextBox EmpIdTb;
		private Label label2;
		private Button btnRefresh;
		private Label Empphonelbl;
		private Label Empposlbl;
		private Label Empaddlbl;
		private Label Empidlbl;
		private Label label7;
		private Label label6;
		private Label label4;
		private Label label3;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label Empdoblbl;
		private Label Empedulbl;
		private Label Empgenlbl;
		private Label Empnamelbl;
		private Button btnHome;
		private Button btnPrint;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
	}
}