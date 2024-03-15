
namespace Desafio_5
{
    public class Caja
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }

        // Método para calcular el volumen de la caja
        public int CalcularVolumen()
        {
            return Alto * Ancho * Largo;
        }
    }
}

