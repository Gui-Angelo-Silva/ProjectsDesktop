namespace Hardware
{
	partial class Items
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
			panel1 = new Panel();
			panel2 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(244, 589);
			panel1.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkCyan;
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(label1);
			panel2.Location = new Point(0, 531);
			panel2.Name = "panel2";
			panel2.Size = new Size(244, 58);
			panel2.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(83, 17);
			label1.Name = "label1";
			label1.Size = new Size(44, 25);
			label1.TabIndex = 0;
			label1.Text = "Sair";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(25, 8);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(45, 41);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// Items
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1009, 589);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Items";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Items";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private PictureBox pictureBox1;
	}
}