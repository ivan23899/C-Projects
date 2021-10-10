using System;
using System.Collections.Generic;
using OrdenarNumeros;

namespace UsoDll
{

    class Program
    {
        public static void Mostrar(List<int> lista)
        {
            for (int i=0;i<=lista.Count-1;i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            OrdenadorNumerico objOrdenador = new OrdenadorNumerico();
            List<int> listaDesordenada = new List<int>();
            for (int i =1;i<=10;i++)
            {
                Random r = new();
                listaDesordenada.Add(r.Next(10,101));
            }
            Console.WriteLine("Lista desordenada: ");
            Console.WriteLine();
            Mostrar(listaDesordenada);    
            Console.WriteLine("Lista ordenada Descendentemente: ");
            Console.WriteLine();
            listaDesordenada = objOrdenador.ordenarDescendente(listaDesordenada);
            Mostrar(listaDesordenada);

            Console.WriteLine("Lista ordenada Ascendentemente: ");
            Console.WriteLine();
            listaDesordenada = objOrdenador.ordenarAscendente(listaDesordenada);
            Mostrar(listaDesordenada);
        }
    }
}
