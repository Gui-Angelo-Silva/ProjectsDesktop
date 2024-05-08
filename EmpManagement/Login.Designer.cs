namespace EmpManagement
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			label1 = new Label();
			pictureBox1 = new PictureBox();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.OrangeRed;
			label1.Location = new Point(341, 30);
			label1.Name = "label1";
			label1.Size = new Size(82, 23);
			label1.TabIndex = 1;
			label1.Text = "SisGEP";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(43, 74);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(118, 129);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(281, 90);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(199, 23);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.BorderStyle = BorderStyle.FixedSingle;
			textBox2.Location = new Point(281, 149);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(199, 23);
			textBox2.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.OrangeRed;
			label2.Location = new Point(164, 91);
			label2.Name = "label2";
			label2.Size = new Size(111, 16);
			label2.TabIndex = 5;
			label2.Text = "ID do Usuário";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.OrangeRed;
			label3.Location = new Point(214, 150);
			label3.Name = "label3";
			label3.Size = new Size(51, 16);
			label3.TabIndex = 6;
			label3.Text = "Senha";
			// 
			// button1
			// 
			button1.BackColor = Color.OrangeRed;
			button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(405, 204);
			button1.Name = "button1";
			button1.Size = new Size(75, 33);
			button1.TabIndex = 7;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.OrangeRed;
			button2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.White;
			button2.Location = new Point(324, 204);
			button2.Name = "button2";
			button2.Size = new Size(75, 33);
			button2.TabIndex = 8;
			button2.Text = "Limpar";
			button2.UseVisualStyleBackColor = false;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(516, 261);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private PictureBox pictureBox1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
	}
}