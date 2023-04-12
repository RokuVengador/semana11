using Laboratorio_2_Programacion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Programacion1.Negocios
{
	public class Calcularnotas
	{
		public void CalcNotaLab(Notas nota)
		{
			decimal notafinal = nota.Lab1 * 0.4M;

			nota.Lab1 = notafinal;
		}
		public void CalcNotaParc(Notas nota)
		{
			decimal notafinal = nota.Parcial1 * 0.6M;

			nota.Parcial1 = notafinal;
		}
		public void Resultado(Notas nota)
		{
			decimal notaF = nota.Lab1 + nota.Parcial1;

			nota.Promedio1 = notaF;
		}

		public void CalcNotaLab1(Notas nota)
		{
			decimal notafinal = nota.Lab2 * 0.4M;

			nota.Lab2 = notafinal;
		}
		public void CalcNotaParc1(Notas nota)
		{
			decimal notafinal = nota.Parcial2 * 0.6M;

			nota.Parcial2 = notafinal;
		}
		public void Resultado1(Notas nota)
		{
			decimal notaF = nota.Lab2 + nota.Parcial2;

			nota.Promedio2 = notaF;
		}




		//public decimal Resultado2(Notas nota)
		//{
		//	decimal notaF1 = nota.Lab2 + nota.Parcial2;

		//	return notaF1;
		//}

		//public decimal Resultado3(Notas nota)
		//{
		//	decimal notaF2 = nota.Lab3 + nota.Parcial3;

		//	return notaF2;
		//}

		public void Promefinal(Notas nota )
		{
			decimal Prome = nota.Promedio1 + nota.Promedio2;

			decimal prom = Prome / 3;

			nota.Resultado = prom;
        }
	}
}
