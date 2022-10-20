//burble short

using System;
using System.Diagnostics;
using System.Threading;

namespace App
{
    class Program
    {
        static void ordeBurble(double[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    int x = j + 1;
                    if (arreglo[j] > arreglo[x])
                    {
                        double temp = arreglo[j];
                        arreglo[j] = arreglo[x];
                        arreglo[x] = temp;
                    }
                }
            }
        }


        static void Main(String[] args)
        {
            //para crear numeros aleatorios
            Random rdn = new Random();
            Stopwatch st = new Stopwatch();

            int inputNumber = int.Parse(Console.ReadLine());

            int min = 1;
            int max = 400;
            int i, j; // declaracion de parametros

            double[] numeros = new double[inputNumber];
            double[] finalNumeros = new double[inputNumber]; // para los threlds
            int k = 0;

            for (i = 0 ; i < inputNumber; i++) numeros[i] = rdn.Next(min, max + 1); // hasta aqui se ingreso 6 datos

            //imprimir el arreglo completo 
            foreach(var n in numeros) Console.WriteLine(n);

            st.Start();
            var middle = inputNumber % 2 == 0 ? inputNumber / 2 : (inputNumber + 1) / 2;

            //inputNumber % 2 == 0  ? var middle = inputNumber / 2 : var middle = (inputNumber + 1) / 2;

            var rightLength = inputNumber - middle;

            double[] leftNumeros = new double[middle];
            double[] rightNumeros = new double[rightLength];

            //Console.WriteLine("imprimiendo los vectores");

            for(i = 0; i < middle; i++) leftNumeros[i] = numeros[i];

            for(j = 0; j < rightLength; ++j) rightNumeros[j] = numeros[middle+j];

            //foreach(var n in leftNumeros) Console.WriteLine(n);
            //foreach(var n in rightNumeros) Console.WriteLine(n);


            Thread t1 = new Thread(() => ordeBurble(leftNumeros));
            Thread t2 = new Thread(() => ordeBurble(rightNumeros));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();



             i = 0;
             j = 0;

             // se aplican los hilos     // condicion para ordenar
             while(k < inputNumber){
                if(i < middle && j < rightLength){
                    if(leftNumeros[i] <= rightNumeros[j]){
                        finalNumeros[k] = leftNumeros[i];
                        i++;
                    }else{
                        finalNumeros[k] = rightNumeros[j];
                        j++;
                    }
                }
                else if( i == middle && j <= rightLength - 1){
                    finalNumeros[k] = rightNumeros[j];
                    j++;
                }
                else if( j == rightLength && i <= middle - 1){
                    finalNumeros[k] = leftNumeros[i];
                    i++;
                }
                k++;
             }

             Console.WriteLine("===========================");
            foreach(var n in finalNumeros) Console.WriteLine(n);
             Console.WriteLine("===========================");

             //Console.WriteLine("numero k {0}", k);
             //Console.WriteLine("numero i {0}", i);
             //Console.WriteLine("numero j {0}", j);


            st.Stop();
            Console.WriteLine("Tiempo Total {0} milisegundos", st.ElapsedMilliseconds);

        }
    }
}
