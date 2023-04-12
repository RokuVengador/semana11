using System;
using System.Collections.Generic;

namespace Laboratorio_2_Programacion1.Models;

public class Notas
{
    public int IdNotas { get; set; }

    public string NombreEstudiante { get; set; } = null!;

    public string Materia { get; set; } = null!;

    public decimal Lab1 { get; set; }

    public decimal Parcial1 { get; set; }

    public decimal Promedio1 { get; set; }

    public decimal Lab2 { get; set; }

	public decimal Promedio2 { get; set; }

	public decimal Parcial2 { get; set; }

    public decimal Lab3 { get; set; }

    public decimal Parcial3 { get; set; }

	public decimal Promedio3  { get; set; }

	public decimal Resultado { get; set; }
}
