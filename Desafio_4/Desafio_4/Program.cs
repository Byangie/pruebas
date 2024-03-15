namespace Desafio_4
{
    internal class Program
    {
        class Caja
        {
            public int Largo { get; set; }
            public int Alto { get; set; }

            public int SuperficieFrontal
            {
                get
                {
                    return Largo * Alto;
                }
            }

            public Caja(int largo, int alto)
            {
                Largo = largo;
                Alto = alto;
                
            }

        }
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 10);
            Console.WriteLine("Dimensiones de la caja Largo={0}, alto={1}, Superficie Frontal={2}",
                                caja.Largo, caja.Alto, caja.SuperficieFrontal);
        }
    }
    }

