﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal <= 59)
                return "Reprobado";
            else if (notaFinal <= 79)
                return "Bueno";
            else if (notaFinal <= 89)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            Console.WriteLine("Datos del Alumno:");
            Console.WriteLine($"Nombre: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("Datos de la Asignatura:");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {NombreDocente}");

            double notaFinal = CalcularNotaFinal();
            double notaFinalConParametros = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine($"Nota Final (sin parámetros): {notaFinal}");
            Console.WriteLine($"Nota Final (con parámetros): {notaFinalConParametros}");
            Console.WriteLine($"Mensaje: {MensajeNotaFinal(notaFinal)}");
        }
    }
}
