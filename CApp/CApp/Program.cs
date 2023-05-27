using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[,] A = { { 1, 0, 0, 0, 0, 0 },
                     { 3, 2, 0, 0, 3, 0 },
                     { 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0,-4 },
                     { 1,-2, 0, 0, 0, 1 },
                     { 0, 0, 0, 0, 1, 0 }
                    };


        int[,] B = { { 1, 0, 0, 0, 0, 0 },
                     { 3, 2, 0, 0, 3, 0 },
                     { 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0,-4 },
                     { 1,-2, 0, 0, 0, 1 },
                     { 0, 0, 0, 0, 1, 0 }
                    };
            int[,] C = { { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 },
                         { 0, 0, 0, 0, 0, 0 }
                        };

            
            /*ClsSparce m = new ClsSparce();
            
            Console.WriteLine(m.MostrarMatriz(A));
           // m.CargarSparce(A);
            Console.WriteLine("-------------------------");
            Console.WriteLine(m.CargarSparce(A).MostrarMatrizSparce());
            */
            ClsSparce m = new ClsSparce();
            ClsSparce n = new ClsSparce();
            ClsSparce r = new ClsSparce();
            ClsSparce p = new ClsSparce();

            Console.WriteLine("--------Matriz Original-----------------");
            Console.WriteLine(m.MostrarMatriz(A));
            Console.WriteLine(n.MostrarMatriz(B));
            Console.WriteLine("-------------------------");
            m.CargarSparce(A);
            n.CargarSparce(B);
            //r.CargarSparce(C);
            Console.WriteLine("-------Matriz Sparce------------------");

            System.Console.WriteLine(m.CargarSparce(A).MostrarMatrizSparce());
            System.Console.WriteLine(n.CargarSparce(B).MostrarMatrizSparce());
            Console.WriteLine("-------Matriz Sparce multiplicacion------------------");
            //r = m.Multiplicacion(A, B);
            //ClsSparce P = m.Multiply(m.CargarSparce(A), n.CargarSparce(B));
            // Console.WriteLine(r.Multiply(m, n).MostrarMatrizSparce());
            //Console.WriteLine(r.Multiplicacion(A, B).MostrarMatrizSparce());
            p.Transpose(m.CargarSparce2(A), p.CargarSparce2(C));
            Console.WriteLine(p.MostrarMatrizSparce());

            Console.ReadKey();
        }
    }
}
