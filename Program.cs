using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ListaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>();
            Random random = new Random();
            

            for (int i = 0; i < 5; i++)
            {
            lista.Add(new List<int>());


                for (int j = 0; j < 3; j++)
                {
                    lista[i].Add(random.Next());
                    
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("[ " + i + " ]");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + lista[i][j]);
                }
                Console.Write("\n");
            }
           

           
            Console.WriteLine("Srednie: ");

            for(int i=0;i<5;i++)
            {
                Console.Write("[ " + i + " ] ");
                double srednia=0;
                double suma=0;
                for (int j = 0; j < 3; j++)
                {
                    suma += lista[i][j];
                }
                srednia = suma / 3;
               
                
                Console.Write(srednia + "\n");
            }

            Console.ReadLine();
        }
    }
}
