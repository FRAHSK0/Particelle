using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 100;
            List<Particella> list = new List<Particella>();
            Random P = new Random();
            using (StreamWriter sw = new StreamWriter("c:\\Users\\Francesco\\Desktop\\P.csv"))
            {
                for (int i = 0; i < n; i++)
            {  
               Particella p=new Particella(0);   
                list.Add(p);
            }
            for (int i = 0; i < 31; i++)
            {
                foreach (Particella p in list)
                {
                    if (P.Next(1, 6) == 1)
                    {
                        if (p.Posizione == 0)   
                        p.Posizione = 1;
                        else 
                        p.Posizione = 0;
                    }
                }
                int c;
                c = 0;


                foreach (Particella p in list)
                {
                    if (p.Posizione==1)
                    {
                        c++;
                    }
                }
                Console.WriteLine("ci sono al tempo {0} in pozione B {1} particelle e in pozione A {2} particelle   ", i, c,n-c);
                sw.WriteLine($"{i};tempo;numero particelle in B;{c};numero di particelle in A {n-c};");
                }
            }
            Console.ReadLine();
        }
    }
}
