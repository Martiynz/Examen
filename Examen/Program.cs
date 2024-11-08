using Examen;
class Program
{
    static void Main(string[] args)
    {
        Asignatura asignatura = new Asignatura();
        Console.WriteLine("Ingrese los datos del alumno:");

        try
        {
            Console.Write("Nombre del Alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Número de Cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Email: ");
            asignatura.Email = Console.ReadLine();

            Console.WriteLine("Ingrese los datos de la asignatura:");
            Console.Write("Nombre de la Asignatura: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Horario: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Nombre del Docente: ");
            asignatura.NombreDocente = Console.ReadLine();



            Console.Write("Ingrese la nota del primer parcial (máximo 30): ");
            asignatura.N1 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N1 > 30)
                throw new ArgumentException("La nota del primer parcial no puede superar el 30%.");

            Console.Write("Ingrese la nota del segundo parcial (máximo 30): ");
            asignatura.N2 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N2 > 30)
                throw new ArgumentException("La nota del segundo parcial no puede superar el 30%.");

            Console.Write("Ingrese la nota del tercer parcial (máximo 40): ");
            asignatura.N3 = Convert.ToInt32(Console.ReadLine());
            if (asignatura.N3 > 40)
                throw new ArgumentException("La nota del tercer parcial no puede superar el 40%.");



            asignatura.Imprimir();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada inválida. Debe ingresar números para las notas.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
