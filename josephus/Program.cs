using System;
using System.Collections.Generic;

namespace Josephus
{
    public class JosephusProblem
    {
        static List<int> PermutacionJosephus(List<int> matriz, int k)
        {
            // Crear una lista para almacenar el resultado de la permutación
            List<int> resultado = new List<int>();

            // Inicializar un índice para seguir el elemento que se va a eliminar
            int indice = 0;

            // Iterar hasta que la matriz quede vacía
            while (matriz.Count > 0)
            {
                // Calcular el índice del elemento que se va a eliminar, segun la regla de Josephus vista en el anexo de la prueba
                indice = (indice + k - 1) % matriz.Count;

                // Agregar el elemento seleccionado al resultado
                resultado.Add(matriz[indice]);

                // Eliminar el elemento seleccionado de la matriz
                matriz.RemoveAt(indice);
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            // Definir la matriz inicial y el valor de k
            List<int> matriz = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            // Obtener la permutación de Josephus y mostrar el resultado en la consola
            List<int> resultado = PermutacionJosephus(matriz, k);
            Console.WriteLine("Permutacion de Josephus: [" + string.Join(", ", resultado) + "]"); // el ultimo numero del array resultado es el sobreviviente
        }
    }
}
