using System;
using System.Globalization;
using beecrowd.Solucoes;

namespace beecrowd
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* Alterando a culture info para en-US por questões de ponto e vírgula */
			CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

			Iniciante solIni = new Iniciante();

			solIni.s1004();
		}
	}
}
