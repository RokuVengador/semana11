
using Laboratorio_2_Programacion1.DAO;
using Laboratorio_2_Programacion1.Models;
using Laboratorio_2_Programacion1.Negocios;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

Notas nota = new Notas();

CrudNotas crudNotas = new CrudNotas();
Calcularnotas calcularnotas = new Calcularnotas();
bool Continuar = true;
while (Continuar)
{
	Console.WriteLine("¿Que desea hacer?");
	Console.WriteLine("-------------------");
	Console.WriteLine("1) Calcular Notas");
	Console.WriteLine("2) Listar Notas");

	var Menu = Convert.ToInt32(Console.ReadLine());

	switch (Menu)
	{
		case 1:

		 int bucle = 1;
			while (bucle == 1)
			{
				Console.WriteLine("Ingrese el nombre del estudiante: ");
				nota.NombreEstudiante = Console.ReadLine();
				Console.WriteLine("Ingrese el nombre de la materia: ");
				nota.Materia = Console.ReadLine();

				Console.WriteLine("Ingrese la nota del primer labotorio: ");
				nota.Lab1 = Convert.ToDecimal(Console.ReadLine());
				calcularnotas.CalcNotaLab(nota);
				calcularnotas.Resultado(nota);


				Console.WriteLine("Ingrese la nota del primer parcial: ");
				nota.Parcial1 = Convert.ToDecimal(Console.ReadLine());
				calcularnotas.CalcNotaParc(nota);
				calcularnotas.Resultado(nota);


				

			


				Console.WriteLine("Ingrese la nota del segundo labotorio: ");
				nota.Lab2 = Convert.ToDecimal(Console.ReadLine());
				calcularnotas.CalcNotaLab1(nota);
				calcularnotas.Resultado1(nota);


				Console.WriteLine("Ingrese la nota del segundo parcial: ");
				nota.Parcial2 = Convert.ToDecimal(Console.ReadLine());
				calcularnotas.CalcNotaLab1(nota);
				calcularnotas.Resultado1(nota);


				
			

				crudNotas.AgregarNotas(nota);
				Console.WriteLine("Su registro se ingreso corectamente");
				Console.WriteLine("pulse 1 para continuar agregando notas");
				Console.WriteLine("Pulsa 0 para salir");
				bucle = Convert.ToInt32(Console.ReadLine());
			}

			break;
		case 2:

			Console.WriteLine("Lista de notas");
			var Lista = crudNotas.listarnota();
			foreach (var lista in Lista)
			{
				Console.WriteLine($"{lista.NombreEstudiante} {lista.Materia} {lista.Lab1} {lista.Parcial1} \n {lista.Lab2}{lista.Parcial2} \n {lista.Lab3} {lista.Parcial3}");
			}


			break;

	}

	Console.WriteLine("¿Desea Seguir haciendo operaciones?");
	string cont = Console.ReadLine();
	if (cont.Equals("N"))
	{
		Continuar = false;
	}

}