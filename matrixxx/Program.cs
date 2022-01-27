using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matrixxx
{
	class Matrix
    {
		int V = 0;  // Нулевое значение
		int D = 1;	// Ширина ленты
		double[] Values;	//Массив ненулевых значений
    }
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());
			
		}
	}
}
