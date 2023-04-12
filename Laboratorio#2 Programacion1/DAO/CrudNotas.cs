using Laboratorio_2_Programacion1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_Programacion1.DAO
{
	public class CrudNotas
	{

		public void AgregarNotas(Notas notas)
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext())
			{
				Notas nota = new Notas();
				nota.NombreEstudiante = notas.NombreEstudiante;
				nota.Materia = notas.Materia;
				nota.Lab1 = notas.Lab1;
				nota.Parcial1 = notas.Parcial1;
				nota.Lab2 = notas.Lab2;
				nota.Parcial2 = notas.Parcial2;
				nota.Lab3 = notas.Lab3;
				nota.Parcial3 = notas.Parcial3;
				nota.Resultado = notas.Resultado;
				db.Nota.Add(nota);
				db.SaveChanges();
			}
		}

		public Notas NotaIndividual(int id)
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext())
			{
				var buscar = db.Nota.FirstOrDefault(s => s.IdNotas == id);

				return buscar;
			}
		}

		public void ActualizarNotas(Notas notas, int actualizador)
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext())
			{
				var buscar = NotaIndividual(notas.IdNotas);
				if (buscar == null)
				{
					Console.WriteLine("El id que buscas no existe");
				}
				else
				{
					if (actualizador == 1)
					{
						buscar.Lab1 = notas.Lab1;
					}
					else if (actualizador == 2)
					{
						buscar.Parcial1 = notas.Parcial1;
					}
					else if (actualizador == 3)
					{
						buscar.Lab2 =notas.Lab2;
					}
					else if (actualizador == 4)
					{
						buscar.Parcial2 =  notas.Parcial2;
					}
					else if (actualizador == 5)
					{
						buscar.Lab3 = notas.Lab3;
					}
					else if (actualizador == 6)
					{
						buscar.Parcial3 = notas.Parcial3;
					}
					else 
					{
						buscar.Resultado = notas.Resultado;
					}
					db.Update(buscar);
					db.SaveChanges();
				}
				
			}
		}

		public String EliminarNotas(int id) 
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext())
			{
				var buscar = NotaIndividual(id);
				if (buscar == null)
				{
					return("El id no existe");
				}
				else 
				{
					db.Nota.Remove(buscar);
					db.SaveChanges();
					return ("Se elimino correctamente");
				}
			}
		}

		public List<Notas> listarnota() 
		{
			using (NotaEstudianteContext db = new NotaEstudianteContext()) 
			{
				return db.Nota.ToList();
			}


		}
	}	 
}
      
	

