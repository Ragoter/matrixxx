using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixxx
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//dataGridView1.DataSource = new List<int[]> { 1, 2, 3, 4 };
		}

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
			var About = new About();
			About.Show();
        }
    }
}
