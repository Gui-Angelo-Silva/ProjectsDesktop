namespace Hardware
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			textBox2 = new TextBox();
			button1 = new Button();
			label4 = new Label();
			lblClose = new Label();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(244, 494);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(384, 54);
			label1.Name = "label1";
			label1.Size = new Size(226, 37);
			label1.TabIndex = 1;
			label1.Text = "Loja de Hardware\r\n";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(318, 178);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(333, 31);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(314, 143);
			label2.Name = "label2";
			label2.Size = new Size(138, 23);
			label2.TabIndex = 3;
			label2.Text = "Nome do Usuário:";
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(315, 229);
			label3.Name = "label3";
			label3.Size = new Size(59, 23);
			label3.TabIndex = 5;
			label3.Text = "Senha:";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(318, 265);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(333, 31);
			textBox2.TabIndex = 4;
			// 
			// button1
			// 
			button1.BackColor = Color.Teal;
			button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(318, 363);
			button1.Name = "button1";
			button1.Size = new Size(333, 55);
			button1.TabIndex = 6;
			button1.Text = "Entrar";
			button1.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(431, 421);
			label4.Name = "label4";
			label4.Size = new Size(105, 23);
			label4.TabIndex = 7;
			label4.Text = "Limpar Campos";
			// 
			// lblClose
			// 
			lblClose.Cursor = Cursors.Hand;
			lblClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			lblClose.Location = new Point(701, 9);
			lblClose.Name = "lblClose";
			lblClose.Size = new Size(17, 23);
			lblClose.TabIndex = 8;
			lblClose.Text = "X";
			lblClose.Click += lblClose_Click;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(730, 494);
			Controls.Add(lblClose);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private TextBox textBox2;
		private Button button1;
		private Label label4;
		private Label lblClose;
	}
}