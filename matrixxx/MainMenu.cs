using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace matrixxx
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

	
		// Вывод окна "о программе"
        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
			var About = new About();
			About.Show();
        }

		// Событие добавления новой вкладки с матрицей
        private void bAddNewTab_Click(object sender, EventArgs e)
        {

			Matrix.Matrixes.Add(new Matrix(0, 0, new List<double>()));
			
			var page = new TabPage();
			page.Text = $"Матрица{tabsControl.TabPages.Count}";

			tabsControl.TabPages.Add(page);
		}
		
		// Событие удаления текущей вкладки
        private void bDelCurrentTab_Click(object sender, EventArgs e)
        {
			if(tabsControl.SelectedIndex != 0) {
				tabsControl.TabPages.Remove(tabsControl.SelectedTab);
				Matrix.Matrixes.RemoveAt(tabsControl.SelectedIndex);
			}
		}

		// Событие обновления данных в структурах матриц при изменении значения ширины ленты на вкладке
		private void tbMatrixWidth_Changed(object sender, EventArgs e)
        {
			if (tabsControl.SelectedIndex != 0)
			{
				Matrix.Matrixes[tabsControl.SelectedIndex].D = Convert.ToInt32(tbMatrixLineWidth.Text);
			}
		}
		// Событие обновления данных в структурах матриц при изменении ненулевых значений на вкладках
		private void rtbMatrixValues_Changed(object sender, EventArgs e)
		{
			var i = 0;
			if (tabsControl.SelectedIndex != 0)
			{
				double result;
				
				foreach(string Number in rtbMatrixValues.Lines)
                {
					if(Double.TryParse(Number, out result))
                    {
                        if (i >= Matrix.Matrixes[tabsControl.SelectedIndex].Values.Count)
                        {
							Matrix.Matrixes[tabsControl.SelectedIndex].Values.Add(result);
						}
                        else
                        {
							Matrix.Matrixes[tabsControl.SelectedIndex].Values[i] = result;
						}
						i++;
					}		
                }
			}	// Отрезаем "хвост" если новый список короче старого
			while(i < Matrix.Matrixes[tabsControl.SelectedIndex].Values.Count) {
				Matrix.Matrixes[tabsControl.SelectedIndex].Values.RemoveAt(Matrix.Matrixes[tabsControl.SelectedIndex].Values.Count-1);
			}
		}
		// Событие переключения вкладок
		private void MatrixTab_Click(object sender, EventArgs e)
        {
			// Переносим элементы с прошлой вкладки матрицы на текущую
			if(tabsControl.SelectedIndex != 0)
            {
				tabsControl.SelectedTab.Controls.Add(lMatrixLineWidth);
				tabsControl.SelectedTab.Controls.Add(tbMatrixLineWidth);
				tabsControl.SelectedTab.Controls.Add(rtbMatrixValues);
				tabsControl.SelectedTab.Controls.Add(cbDisableEditing);
				tabsControl.SelectedTab.Controls.Add(lListNonZeroElems);
			}
			// Обновляем значения текущих элементов в соответствии с новой текущей матрицей

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

		// Событие "при появлении формы"
        private void MainMenu_Load(object sender, EventArgs e)
        {
			Matrix.Matrixes.Add(new Matrix(0, 0, new List<double>()));
			Matrix.Matrixes.Add(new Matrix(0, 1, new List<double> { 1.4, 2.5, 3.22, 4.15, 5.06, 6.22, 7.1 }));
		}

		// Событие сохранения текущей матрицы
		private void bSaveMX_Click(object sender, EventArgs e)
		{
			// Создаем диалог сохранения файла
			var saveFile = new SaveFileDialog();
			saveFile.FileName = tabsControl.SelectedTab.Text;
			saveFile.InitialDirectory = AppContext.BaseDirectory;           // Начальный каталог - каталог с программой
			saveFile.Filter = "matrixxx файл|*.mtx|Текстовый файл|*.txt";
			saveFile.Title = $"Сохранить матрицу \"{tabsControl.SelectedTab.Text}\"";	

			if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != "")
			{
				//Если файл сущетсвует, то удаляем его
				if (System.IO.File.Exists(saveFile.FileName))
				{
					System.IO.File.Delete(saveFile.FileName);
				}

				// Выписываем элементы текущей матрицы
				var D = Matrix.Matrixes[tabsControl.SelectedIndex].D.ToString();
				var V = Matrix.Matrixes[tabsControl.SelectedIndex].V.ToString();
				var Values = String.Join("; ", Matrix.Matrixes[tabsControl.SelectedIndex].Values);

				// Создаем файл матрицы и записываем туда информацию
				var fs = System.IO.File.Create(saveFile.FileName);
				byte[] info = new UTF8Encoding(true).GetBytes($"{D}\n{V}\n{Values}");

				fs.Write(info, 0, info.Length);
				fs.Close();
			}
		}
    }
}
