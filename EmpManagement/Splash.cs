namespace EmpManagement
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		int startpoint = 0;

		private void timer1_Tick(object sender, EventArgs e)
		{
			startpoint += 1;
			MyProgress.Value = startpoint;

			if (MyProgress.Value == 100)
			{
				MyProgress.Value = 0;
				timer1.Stop();
				this.Hide();
				Login log = new Login();
				log.Show();
			}
		}
	}
}