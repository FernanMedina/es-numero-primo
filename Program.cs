using System;
/*
 * Reto #3
 * ¿ES UN NÚMERO PRIMO?
 * Fecha publicación enunciado: 17/01/22
 * Fecha publicación resolución: 24/01/22
 * Dificultad: MEDIA
 *
 * Enunciado: Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */
namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if (esPrimo(numero))
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");
        }

        static bool esPrimo(int n)
        {
            int contador = 0;
            for (int x = 1; x <= n; x++)
            {
                if (n % x == 0)
                    contador++;
            }
            if (contador == 2)
                return true;
            else
                return false;
        }

    }
}
