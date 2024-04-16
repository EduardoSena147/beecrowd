using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowd.Solucoes
{
	public class Iniciante
	{
		public void s1000()
		{
			Console.WriteLine("Hello World!");
		}

		public void s1001()
		{
			int A = Convert.ToInt32(Console.ReadLine());
			int B = Convert.ToInt32(Console.ReadLine());
			int X = A + B;
			Console.WriteLine("X = " + X.ToString());
		}

		public void s1002()
		{
			double n = 3.14159;
			double raio = Convert.ToDouble(Console.ReadLine());
			double area = n * (raio * raio);
			Console.WriteLine("A=" + area.ToString("0.0000"));
		}
	}
}
