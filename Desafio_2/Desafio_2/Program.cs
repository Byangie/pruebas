namespace Desafio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("El número ingresado no es primo.");
            }
            else
            {
                bool esPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine("El número ingresado es primo.");
                }
                else
                {
                    Console.WriteLine("El número ingresado no es primo.");
                }
            }
        }
    }
}
