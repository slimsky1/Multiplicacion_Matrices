using System;

namespace Multiplicacion_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[2, 5];
            int[,] m2 = new int[5, 2];

            Console.WriteLine("Matriz 1: ");
            inicializarMatriz(m1);
            imprimirMatriz(m1);

            Console.WriteLine("Matriz 2: ");
            inicializarMatriz(m2);
            imprimirMatriz(m2);

            if (validarMultiplicacion(m1, m2))
            {
                Console.WriteLine("Resultado: ");
                imprimirMatriz(multiplicarMatrices(m1, m2));
            }
            else
            {
                Console.WriteLine("No se puede calcular ya que posee diferentes dimensiones");
            }
            Console.ReadLine();



            Boolean validarMultiplicacion(int[,] a, int[,] b)
            {
                return (m1.GetLength(1) == m2.GetLength(0)) ? true : false;
            }

            void inicializarMatriz(int[,] a)
            {
                Random rd = new Random();
                for(int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = rd.Next(10);
                    }
                }
            }

            void imprimirMatriz(int[,] a)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write("{0,-1} ", a[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            int[,] multiplicarMatrices(int[,] a, int[,] b)
            {
                int[,] respuesta = new int[a.GetLength(0), b.GetLength(1)];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            respuesta[i, j] = 0;

                            for (int z = 0; z < a.GetLength(1); z++)
                            {
                                respuesta[i, j] = (a[i, z] * b[z, j]) + respuesta[i,j];
                            }
                        }
                    }
                    return respuesta;
                
            }
        }

    }
}
