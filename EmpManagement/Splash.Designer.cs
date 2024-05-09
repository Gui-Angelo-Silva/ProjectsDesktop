namespace EmpManagement
{
	partial class Splash
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
			label1 = new Label();
			MyProgress = new ProgressBar();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Mongolian Baiti", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.OrangeRed;
			label1.Location = new Point(84, 27);
			label1.Name = "label1";
			label1.Size = new Size(470, 23);
			label1.TabIndex = 0;
			label1.Text = "SISTEMA GERENCIADOR DE EMPREGADOS";
			// 
			// MyProgress
			// 
			MyProgress.ForeColor = Color.OrangeRed;
			MyProgress.Location = new Point(84, 220);
			MyProgress.Name = "MyProgress";
			MyProgress.Size = new Size(470, 23);
			MyProgress.TabIndex = 1;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(246, 77);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(147, 111);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.OrangeRed;
			label2.Location = new Point(199, 274);
			label2.Name = "label2";
			label2.Size = new Size(241, 16);
			label2.TabIndex = 3;
			label2.Text = "Desenvolvido por: GuigasSOFT";
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// Splash
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(638, 321);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(MyProgress);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Splash";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ProgressBar MyProgress;
		private PictureBox pictureBox1;
		private Label label2;
		private System.Windows.Forms.Timer timer1;
	}
}