using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static bool lista(int numero)
        {
            return numero != 0;
        }


        static void Main(string[] args)
        {
            int Suma = 0, Cuadrado = 0, Mayores = 0, Promedio = 0, Contador = 0, 
                Pares = 0, Contador2=0, Impares=0, Unicos=0, Residuo, a, b;
            

            Random NumeroAleatorio = new Random();

            List<Int32> ListaNumero = new List<Int32> { };
            List<Int32> ListaCuadrados = new List<Int32> { };
            List<Int32> ListaPrimos = new List<Int32> { };
            List<Int32> ListaUnicos = new List<Int32> { };

            for (int i = 0; i < 50; i++)
            {
                ListaNumero.Add(NumeroAleatorio.Next(0, 100));
            }

            var n = from l in ListaNumero where lista(1) select l;
            var c = from m in ListaCuadrados where lista(1) select m;

            Console.WriteLine("-----------LISTA DE NÚMEROS ALEATORIOS--------");
            foreach (var item in n)
            {
                Console.WriteLine(item);

            }
            
            foreach (int item in n)
            {
                
                a = 2;
                b = 0;
                while (((a < item) & (b == 0)))
                {
                    Residuo = item % a;
                    if ((Residuo == 0))
                    {
                        b = 1;
                    }
                    else
                    {
                        a++;
                    }
                }
                if ((b == 0))
                {
                    Console.WriteLine("----------PRIMOS--------");
                    Console.WriteLine(item);
                }
                else
                {

                }
            }

            foreach (var item in n)
            {
                 Suma = ListaNumero.Sum();
            }
            Console.WriteLine("----------SUMA TOTAL----------");
            Console.WriteLine("SUMA TOTAL: " + Suma);
            Console.WriteLine("----------LISTA CUADRADOS---------");
            foreach (var item in n)
            {
                Cuadrado = item * item;
                ListaCuadrados.Add(Cuadrado);
                Console.WriteLine(Cuadrado);
            }
            Console.WriteLine("-----------LISTA PRIMOS----------");
            foreach (int item in n)
            {

                a = 2;
                b = 0;
                while (((a < item) & (b == 0)))
                {
                    Residuo = item % a;
                    if ((Residuo == 0))
                    {
                        b = 1;
                    }
                    else
                    {
                        a++;
                    }
                }
                if ((b == 0))
                {
                    ListaPrimos.Add(item);
                    Console.WriteLine(item);
                }
                else
                {

                }
            }
            foreach (var item in n)
            {
                if (item > 50)
                {
                    Mayores = Mayores + item;
                    Contador++;
                }
            }
            Promedio = Mayores / Contador;
            Console.WriteLine("---------PROMEDIO---------");
            Console.WriteLine("PROMEDIO: " + Promedio);

            foreach (var item in n)
            {
                
                if (item % 2 == 0)
                {
                    Pares = Pares + 1;
                }
                else
                {
                    Impares = Impares + 1;
                }
                
            }
            Console.WriteLine("----------PARES E IMPARES---------");
            Console.WriteLine("PARES: " +Pares);
            Console.WriteLine("IMPARES: " +Impares);
            Console.WriteLine("-----------CANTIDAD DE VECES REPETIDO-----------");
            foreach (var item in n)
            {
                if (item == item)
                {
                    
                    Contador2++;
                }
            }
            Console.WriteLine("CONTADOR: "+Contador2);

            Console.WriteLine("------------LISTA DESCENDENTES-------------*");
            (from l in ListaNumero where l>0 orderby l descending select l).ToList().ForEach(i => Console.WriteLine(i)); ;
            Console.WriteLine("------------NÚMEROS ÚNICOS-----------");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaUnicos.Contains(ListaNumero[i])))
                {
                    ListaUnicos.Add(ListaNumero[i]);
                }
            }
            (from l in ListaNumero where l > 0 orderby l ascending select l).ToList().ForEach(i => Console.WriteLine(i)); ;
            Console.WriteLine("---------SUMA NÚMEROS ÚNICOS-------");
            for (int i = 0; i < ListaNumero.Count; i++)
            {
                if (!(ListaUnicos.Contains(ListaNumero[i])))
                {
                    ListaUnicos.Add(ListaNumero[i]);
                }
            }
            foreach (var item in ListaUnicos)
            {
                Unicos = Unicos + item;
            }
            Console.WriteLine("SUMA DE NÚMEROS ÚNICOS: " + Unicos);

            Console.ReadKey();
        }

    }  
}
