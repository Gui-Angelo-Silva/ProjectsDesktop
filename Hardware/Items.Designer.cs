﻿namespace Hardware
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
			panel1 = new Panel();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(244, 589);
			panel1.TabIndex = 1;
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
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
	}
}