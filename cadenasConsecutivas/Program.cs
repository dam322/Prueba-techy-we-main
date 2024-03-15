using System;
using System.Collections.Generic;

namespace cadenasConsecutivas
{
    public class cadenasConsecutivas
    {

        static string CadenaMasLarga(string[] cadenas, int r)
        {
            if (cadenas.Length < r) // Verifica si el tamaño del array es menor que r
            {
                return "No hay suficientes cadenas para formar una concatenación consecutiva";
            }

            string maxCadena = "";
            for (int i = 0; i <= cadenas.Length - r; i++) // Itera sobre todas las posibles combinaciones de cadenas consecutivas
            {
                string concatenacion = string.Join("", cadenas, i, r);// Concatena r cadenas consecutivas
                if (concatenacion.Length > maxCadena.Length) // Compara la longitud de la concatenación con la longitud de maxCadena
                {
                    maxCadena = concatenacion; // Si hay una concatenación más larga, se actualiza maxCadena
                }
            }

            return maxCadena;
        }
        static void Main(string[] args)
        {
            string[] cadenas = ["abcd", "efghij", "klmnop", "qrst", "cuenta", "uvwxyz"]; // Array de cadenas de texto
            int r = 3; // factor de cadenas consecutivas
            string resultado = CadenaMasLarga(cadenas, r);
            Console.WriteLine($"La cadena más larga formada por {r} cadenas consecutivas es: {resultado}");

        }
    }
}
