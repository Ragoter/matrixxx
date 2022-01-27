using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matrixxx
{

	class Matrix
	{
		public int V { get; }          // Нулевое значение
		public int D { get; }          // Ширина ленты
		public double[] Values { get; set; }    // Массив ненулевых значений
		public static List<Matrix> Matrixes = new System.Collections.Generic.List<Matrix>();
		
        public Matrix(int V, int D, double[] Values)
        {
			this.V = V;
			this.D = D;
			this.Values = Values;
		}

		static public Matrix Revert(Matrix A)		// Обратная матрица
		{
			return A;
		}

		static public Matrix Sum(Matrix A, Matrix B) // Сложение матриц А и В
		{
			return A;
		}

		static public Matrix Multiply(Matrix A, double Number)	// Умножение матрицы на число
        {
			return A;
        }

		static public Matrix Multiply(Matrix A, Matrix B)  // Умножение матрицы А на матрицу B
		{
			return A;
		}

		static public Matrix FillRandom(Matrix A)	// Заполнить матрицу А псевдослучайными числами
		{
			return A;
		}

		

	}

	
	static class Program
	{
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainMenu());

			
		}
		
	}
}
