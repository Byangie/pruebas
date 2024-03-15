namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese un número entero positivo: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=1; i<=num; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
