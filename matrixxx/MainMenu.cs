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

	

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
			var About = new About();
			About.Show();
        }

        private void bAddNewTab_Click(object sender, EventArgs e)
        {

			Matrix.Matrixes.Add(new Matrix(0, 0, null));
			
			var page = new TabPage();
			page.Text = $"Матрица{tabsControl.TabPages.Count}";

			tabsControl.TabPages.Add(page);
			page.Click += new System.EventHandler(this.MatrixTab_Click);
		}

        private void bDelCurrentTab_Click(object sender, EventArgs e)
        {
			if(tabsControl.SelectedIndex != 0) {
				tabsControl.TabPages.Remove(tabsControl.SelectedTab);
				Matrix.Matrixes.RemoveAt(tabsControl.SelectedIndex);
			}
		}

        private void MatrixTab_Click(object sender, EventArgs e)
        {
			if(tabsControl.SelectedIndex != 0)
            {
				tabsControl.SelectedTab.Controls.Add(lMatrixLineWidth);
				tabsControl.SelectedTab.Controls.Add(tbMatrixLineWidth);
				tabsControl.SelectedTab.Controls.Add(rtbMatrixValues);
				tabsControl.SelectedTab.Controls.Add(cbDisableEditing);
				tabsControl.SelectedTab.Controls.Add(lListNonZeroElems);
			}
			

			tbMatrixLineWidth.Text = Matrix.Matrixes[tabsControl.SelectedIndex].D.ToString();
			
			rtbMatrixValues.Clear();

			if (Matrix.Matrixes[tabsControl.SelectedIndex].Values != null)
            {
				foreach (var i in Matrix.Matrixes[tabsControl.SelectedIndex].Values)
				{
					rtbMatrixValues.Text += i.ToString() + '\n';
				}
			}
			
			

		}

        private void MainMenu_Load(object sender, EventArgs e)
        {
			double[] arr = { 1.4, 2.5, 3.22, 4.15, 5.06, 6.22, 7.1 };

			Matrix.Matrixes.Add(new Matrix(0, 1, arr));
			Matrix.Matrixes.Add(new Matrix(0, 1, arr));
		}
    }
}
