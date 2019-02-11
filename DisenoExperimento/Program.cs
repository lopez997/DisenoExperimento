using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisenoExperimento
{
    class Program
    {
        private int[] arregloInt;
        private double[] arregloDouble;
        private long[] arregloLong;
        private Random aleatorio;

        private void creacionArregloAleatorio(String tipo,int tamaño)
        {
            aleatorio = new Random();
            if (tipo.Equals("int"))
            {
                arregloInt = new int[tamaño];

                Enumerable.Range(0, tamaño).ToList().ForEach(x => arregloInt[x] = aleatorio.Next(0, tamaño));
            }else if (tipo.Equals("double"))
            {
                arregloDouble = new double[tamaño];

                Enumerable.Range(0, tamaño).ToList().ForEach(x => arregloDouble[x] = aleatorio.NextDouble());
            }
            else if (tipo.Equals("long"))
            {
                arregloLong = new long[tamaño];

                long min = 10000000000001;
                long max = 99999999999999;
                Enumerable.Range(0, tamaño).ToList().ForEach(x => arregloLong[x] = min + (long)(aleatorio.NextDouble() * (max - min)));

            }
        }

        private void insertionSortInt()
        {
            //Console.WriteLine("El arreglo de enteros desordenados es:");
            //arregloInt.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            for (int i = 1; i < arregloInt.Length; i++)
            {
                int key = arregloInt[i];
                int j = i - 1;
                while (j >= 0 && arregloInt[j] > key)
                {
                    //loop
                    arregloInt[j + 1] = arregloInt[j];
                    j--;
                }
                arregloInt[j + 1] = key;
            }
            //Console.WriteLine("\nEl arreglo de enteros ordenado por insertion es:");
            //arregloInt.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");

        }

        private void insertionSortDouble()
        {
            //Console.WriteLine("El arreglo de double desordenados es:");
            //arregloDouble.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            for (int i = 1; i < arregloDouble.Length; i++)
            {
                double key = arregloDouble[i];
                int j = i - 1;
                while (j >= 0 && arregloDouble[j] > key)
                {
                    //loop
                    arregloDouble[j + 1] = arregloDouble[j];
                    j--;
                }
                arregloDouble[j + 1] = key;
            }
            //Console.WriteLine("\nEl arreglo de double ordenado por insertion es:");
            //arregloDouble.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");
        }

        private void insertionSortLong()
        {
            //Console.WriteLine("El arreglo de long desordenados es:");
            //arregloLong.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            for (int i = 1; i < arregloLong.Length; i++)
            {
                long key = arregloLong[i];
                int j = i - 1;
                while (j >= 0 && arregloLong[j] > key)
                {
                    //loop
                    arregloLong[j + 1] = arregloLong[j];
                    j--;
                }
                arregloLong[j + 1] = key;
            }
            //Console.WriteLine("\nEl arreglo de long ordenado por insertion es:");
            //arregloLong.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");
        }

        private void cocktailSortInt()
        {
            //Console.WriteLine("El arreglo de enteros desordenados es:");
            //arregloInt.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            bool swapped = true;
            int start = 0;
            int end = arregloInt.Length;

            while (swapped == true)
            {
                swapped = false;
                
                for (int i = start; i < end - 1; ++i)
                {
                    if (arregloInt[i] > arregloInt[i + 1])
                    {
                        int temp = arregloInt[i];
                        arregloInt[i] = arregloInt[i + 1];
                        arregloInt[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
    
                swapped = false;
                end = end - 1;
 
                for (int i = end - 1; i >= start; i--)
                {
                    if (arregloInt[i] > arregloInt[i + 1])
                    {
                        int temp = arregloInt[i];
                        arregloInt[i] = arregloInt[i + 1];
                        arregloInt[i + 1] = temp;
                        swapped = true;
                    }
                } 
                start = start + 1;
            }
            //Console.WriteLine("\nEl arreglo de enteros ordenado por cocktail es:");
            //arregloInt.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");
        }

        private void cocktailSortDouble()
        {
            //Console.WriteLine("El arreglo de double desordenados es:");
            //arregloDouble.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            bool swapped = true;
            int start = 0;
            int end = arregloDouble.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (arregloDouble[i] > arregloDouble[i + 1])
                    {
                        double temp = arregloDouble[i];
                        arregloDouble[i] = arregloDouble[i + 1];
                        arregloDouble[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;
                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arregloDouble[i] > arregloDouble[i + 1])
                    {
                        double temp = arregloDouble[i];
                        arregloDouble[i] = arregloDouble[i + 1];
                        arregloDouble[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
            //Console.WriteLine("\nEl arreglo de double ordenado por cocktail es:");
            //arregloDouble.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");
        }

        private void cocktailSortLong()
        {
            //Console.WriteLine("El arreglo de long desordenados es:");
            //arregloLong.ToList().ForEach(x => Console.Write(x));
            var tiempo = new System.Diagnostics.Stopwatch();
            tiempo.Start();
            bool swapped = true;
            int start = 0;
            int end = arregloLong.Length;

            while (swapped == true)
            {
                swapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (arregloLong[i] > arregloLong[i + 1])
                    {
                        long temp = arregloLong[i];
                        arregloLong[i] = arregloLong[i + 1];
                        arregloLong[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;

                swapped = false;
                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (arregloLong[i] > arregloLong[i + 1])
                    {
                        long temp = arregloLong[i];
                        arregloLong[i] = arregloLong[i + 1];
                        arregloLong[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
            //Console.WriteLine("\nEl arreglo de long ordenado por cocktail es:");
            //arregloLong.ToList().ForEach(x => Console.Write(x));
            tiempo.Stop();
            Console.WriteLine($"\nExecution Time: {tiempo.ElapsedTicks} ticks");
        }

        static void Main(string[] args)
        {
            Program modelo = new Program();

            Console.WriteLine("Sistema operativo= Windows  Intel(R) core(TM) i5-5200U CPU @ 2.20 GHZ");

            Console.WriteLine("Tamaño del arreglo= 10");

            Console.WriteLine("Tipo de los elementos del arreglo= int");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("int", 10);
            modelo.insertionSortInt();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortInt();

            Console.WriteLine("Tipo de los elementos del arreglo= double");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("double", 10);
            modelo.insertionSortDouble();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");
            modelo.cocktailSortDouble();

            Console.WriteLine("Tipo de los elementos del arreglo= long");

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.creacionArregloAleatorio("long", 10);
            modelo.insertionSortLong();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortLong();



            Console.WriteLine("Tamaño del arreglo= 100");

            Console.WriteLine("Tipo de los elementos del arreglo= int");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("int", 100);
            modelo.insertionSortInt();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortInt();

            Console.WriteLine("Tipo de los elementos del arreglo= double");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("double", 100);
            modelo.insertionSortDouble();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");
            modelo.cocktailSortDouble();

            Console.WriteLine("Tipo de los elementos del arreglo= long");

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.creacionArregloAleatorio("long", 100);
            modelo.insertionSortLong();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortLong();


            Console.WriteLine("Tamaño del arreglo= 1000");

            Console.WriteLine("Tipo de los elementos del arreglo= int");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("int", 1000);
            modelo.insertionSortInt();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortInt();

            Console.WriteLine("Tipo de los elementos del arreglo= double");

            Console.WriteLine("Algoritmo de busqueda= Insertion Sort");

            modelo.creacionArregloAleatorio("double", 1000);
            modelo.insertionSortDouble();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");
            modelo.cocktailSortDouble();

            Console.WriteLine("Tipo de los elementos del arreglo= long");

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.creacionArregloAleatorio("long", 1000);
            modelo.insertionSortLong();

            Console.WriteLine("Algoritmo de busqueda= cocktail Sort");

            modelo.cocktailSortLong();
        }
    }
}
