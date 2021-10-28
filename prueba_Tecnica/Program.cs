using System;
using System.Collections.Generic;

namespace prueba_Tecnica
{
    class Program
    {
        //Primer Ejercicio
        static void Main(string[] args)
        {
            
            int[] myArray = new int[] { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
            Array.Sort(myArray);
            int maximo = myArray[myArray.Length - 1];
            for (int indice = 1; indice <= maximo; indice++)
            {
                Console.WriteLine(indice + ": ");
                for (int x = 0; x < myArray.Length; x++)
                {
                    if (indice == myArray[x])
                    {
                        Console.WriteLine("*");
                    }
                }
            }

            //Segundo Ejercicio
            int[] myArray2 = new int[] {1,3,4,2,7,0};

            Console.WriteLine("teniendo los numeros: ");
            for (int indice = 0; indice < myArray2.Length; indice++)
            {
                Console.Write(myArray2[indice] + " ");
            }
            Console.Write("\n");
            for (int i = 0; i < myArray2.Length - 1; i++)
            {
                for (int j = 1; j < myArray2.Length; j++)
                {
                    if (myArray2[i] + myArray2[j] == 10)
                    {
                        Console.WriteLine($"el numero {myArray2[i]} sumado al numero { myArray2[j]} da 10");
                    }
                }
            }





           

        }
    }
}
