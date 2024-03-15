namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int contador = 0;

            Console.WriteLine("Ingrese los puntajes del alumno (1-10) o escriba 'fin' para terminar:");

            string notas = Console.ReadLine();
            while (notas.ToLower() != "fin")
            {
                try
                {
                    double puntaje = double.Parse(notas);
                    if (puntaje < 1 || puntaje > 10)
                    {
                        throw new ArgumentException("El puntaje debe estar entre 1 y 10.");
                    }

                    Console.WriteLine("Ingrese los puntajes del alumno (1-10) o escriba 'fin' para terminar:");
                    total += puntaje;
                    contador++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                notas = Console.ReadLine();
            }

            if (contador > 0)
            {
                double promedio = total / contador;
                Console.WriteLine($"El puntaje promedio del alumno es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se han ingresado puntajes.");
            }
        }
    }
}

