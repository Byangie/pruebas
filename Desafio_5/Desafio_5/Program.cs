namespace Desafio_5
{
    internal class Program
    {
        static void Main(string[] args)

        //DESAFIO 5 PROGRAMA Y EXPLICACION DEL PROGRAMA.
        {
            // Solicitar al usuario la cantidad de cajas
            Console.Write("Ingrese la cantidad de cajas: ");
            int cantidadCajas = int.Parse(Console.ReadLine());

            int volumenTotal = 0;

            // Iterar sobre cada caja ingresada por el usuario
            for (int i = 0; i < cantidadCajas; i++)
            {
                // Solicitar al usuario las dimensiones de la caja
                Console.WriteLine($"\nIngrese las dimensiones de la caja {i + 1}:");
                Console.Write("Alto: ");
                int alto = int.Parse(Console.ReadLine());

                Console.Write("Ancho: ");
                int ancho = int.Parse(Console.ReadLine());

                Console.Write("Largo: ");
                int largo = int.Parse(Console.ReadLine());

                // Crear una nueva instancia de la clase Caja con las dimensiones ingresadas
                Caja caja = new Caja { Alto = alto, Ancho = ancho, Largo = largo };

                // Calcular y sumar el volumen de la caja a volumenTotal
                volumenTotal += caja.CalcularVolumen();
            }

            // Calcular el volumen promedio dividiendo volumenTotal por la cantidad de cajas
            int volumenPromedio = volumenTotal / cantidadCajas;

            // Mostrar el volumen total y el volumen promedio de las cajas
            Console.WriteLine("\nEl volumen total de las cajas es: {0}", volumenTotal);
            Console.WriteLine("El volumen promedio de las cajas es: {0}", volumenPromedio);
        }
    }
}
