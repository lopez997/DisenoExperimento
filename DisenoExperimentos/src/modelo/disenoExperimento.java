package modelo;

import java.util.Random;

public class disenoExperimento {

	private int[] arregloInt;
    private double[] arregloDouble;
    private long[] arregloLong;
    private Random aleatorio;

    private void creacionArregloAleatorio(String tipo,int tamaño)
    {
        aleatorio = new Random();
        if (tipo.equals("int"))
        {
            arregloInt = new int[tamaño];

            for(int i=0;i<tamaño;i++) {
            	arregloInt[i]= aleatorio.nextInt(tamaño);
            }
        }else if (tipo.equals("double"))
        {
            arregloDouble = new double[tamaño];

            for(int i=0;i<tamaño;i++) {
            	arregloDouble[i]= aleatorio.nextDouble();
            }        }
        else if (tipo.equals("long"))
        {
            arregloLong = new long[tamaño];

            for(int i=0;i<tamaño;i++) {
            	arregloLong[i]= aleatorio.nextLong();
            }
            
        }
    }

    private void insertionSortInt()
    {
        //Console.WriteLine("El arreglo de enteros desordenados es:");
        //arregloInt.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        for (int i = 1; i < arregloInt.length; i++)
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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");

    }

    private void insertionSortDouble()
    {
        //Console.WriteLine("El arreglo de double desordenados es:");
        //arregloDouble.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        for (int i = 1; i < arregloDouble.length; i++)
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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");
    }

    private void insertionSortLong()
    {
        //Console.WriteLine("El arreglo de long desordenados es:");
        //arregloLong.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        for (int i = 1; i < arregloLong.length; i++)
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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");
    }

    private void cocktailSortInt()
    {
        //Console.WriteLine("El arreglo de enteros desordenados es:");
        //arregloInt.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        boolean swapped = true;
        int start = 0;
        int end = arregloInt.length;

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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");
    }

    private void cocktailSortDouble()
    {
        //Console.WriteLine("El arreglo de double desordenados es:");
        //arregloDouble.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        boolean swapped = true;
        int start = 0;
        int end = arregloDouble.length;

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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");
    }

    private void cocktailSortLong()
    {
        //Console.WriteLine("El arreglo de long desordenados es:");
        //arregloLong.ToList().ForEach(x => Console.Write(x));
        long tiempo = System.nanoTime();
        boolean swapped = true;
        int start = 0;
        int end = arregloLong.length;

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
        long t= (System.nanoTime()-tiempo)/100;
        System.out.println("\nExecution Time: " +  t +" ticks");
    }

    public static void main(String[] args)
    {
        disenoExperimento modelo = new disenoExperimento();

        System.out.println("Sistema operativo= Windows  Intel(R) core(TM) i5-5200U CPU @ 2.20 GHZ");

        System.out.println("Tamaño del arreglo= 10");

        System.out.println("Tipo de los elementos del arreglo= int");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("int", 10);
        modelo.insertionSortInt();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortInt();

        System.out.println("Tipo de los elementos del arreglo= double");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("double", 10);
        modelo.insertionSortDouble();

        System.out.println("Algoritmo de busqueda= cocktail Sort");
        modelo.cocktailSortDouble();

        System.out.println("Tipo de los elementos del arreglo= long");

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.creacionArregloAleatorio("long", 10);
        modelo.insertionSortLong();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortLong();



        System.out.println("Tamaño del arreglo= 100");

        System.out.println("Tipo de los elementos del arreglo= int");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("int", 100);
        modelo.insertionSortInt();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortInt();

        System.out.println("Tipo de los elementos del arreglo= double");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("double", 100);
        modelo.insertionSortDouble();

        System.out.println("Algoritmo de busqueda= cocktail Sort");
        modelo.cocktailSortDouble();

        System.out.println("Tipo de los elementos del arreglo= long");

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.creacionArregloAleatorio("long", 100);
        modelo.insertionSortLong();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortLong();


        System.out.println("Tamaño del arreglo= 1000");

        System.out.println("Tipo de los elementos del arreglo= int");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("int", 1000);
        modelo.insertionSortInt();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortInt();

        System.out.println("Tipo de los elementos del arreglo= double");

        System.out.println("Algoritmo de busqueda= Insertion Sort");

        modelo.creacionArregloAleatorio("double", 1000);
        modelo.insertionSortDouble();

        System.out.println("Algoritmo de busqueda= cocktail Sort");
        modelo.cocktailSortDouble();

        System.out.println("Tipo de los elementos del arreglo= long");

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.creacionArregloAleatorio("long", 1000);
        modelo.insertionSortLong();

        System.out.println("Algoritmo de busqueda= cocktail Sort");

        modelo.cocktailSortLong();
    }
}


