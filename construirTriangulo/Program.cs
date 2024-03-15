using System;

namespace construirTriangulo
{
    public class Triangulo
    {
        public static bool EsTriangulo(int a, int b, int c)
        {
            // Se comprueba que los lados sean positivos y mayores que cero
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            // Se comprueba que la suma de dos lados sea mayor que el tercero o desigualdad triangular
            return a + b > c && a + c > b && b + c > a;
        }

        static void Main(string[] args)
        {
            // Lados del triangulo, cambiar los valores para probar diferentes casos
            int lado1 = 4;
            int lado2 = 5;
            int lado3 = 6;

            bool resultado = EsTriangulo(lado1, lado2, lado3); // Se llama a la función EsTriangulo y se guarda el resultado en la variable "resultado"
            Console.WriteLine("¿Se puede formar un triangulo? " + (resultado ? "Si" : "No"));
        }
    }
}
