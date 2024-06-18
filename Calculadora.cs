namespace EspacioCalculadora
{
    class Calculadora
    {
        // Campo para almacenar el resultado
        private double dato;

        // Método para sumar
        public void Sumar(double termino)
        {
            dato += termino;
        }

        // Método para restar
        public void Restar(double termino)
        {
            dato -= termino;
        }

        // Método para multiplicar
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }

        // Método para dividir
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
        }

        // Método para limpiar el resultado
        public void Limpiar()
        {
            dato = 0;
        }

        // Método para obtener el valor actual de dato
        public double Resultado()
        {
            return dato;
        }
    }
}
