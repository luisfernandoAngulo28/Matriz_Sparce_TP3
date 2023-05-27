using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{



    public class ClsSparce
    {    //Atributos
        const int Max = 30;  // Maxima Cantidad de elementos en el arreglo V alternativo
                             //fila,columna
        public int[,] Sparce = new int[Max, 3];// Vector donde se almacena los datos de las MatriZ A original
        int F;// Cantidad de filas de la Matriz A original
        int C;// Cantidad de columnas de la Matriz A original
        int cant; //cantidad de elementos


        //Constructor

        public ClsSparce()
        {
            F = 0;
            C = 0;
            cant = 0;
            int i = 0;
            while ( i < Max)
            {
                this.Sparce[i, 0] = 0;
                this.Sparce[i, 1] = 0;
                this.Sparce[i, 2] = 0;
                i++;
            }
        }

        public ClsSparce(ClsSparce m)
        {
            F = m.F;
            C = m.C;
            cant = 0;
            for (int i = 0; i < Max; i++)
            {
                Sparce[i, 0] = m.Sparce[i, 0];
                Sparce[i, 1] = m.Sparce[i, 1];
                Sparce[i, 2] = m.Sparce[i, 2];
            }
        }

        public void Limpiar()
        {
            cant = 0;
            for (int i = 0; i < Max; i++)
            {
                Sparce[i, 0] = 0;
                Sparce[i, 1] = 0;
                Sparce[i, 2] = 0;
            }
        }


        /*
 ///Matriz Original
        int[,] A = { { 1, 0, 0, 0, 0, 0 }, 
                     { 3, 2, 0, 0, 3, 0 },
                     { 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0,-4 },
                     { 1,-2, 0, 0, 0, 1 },
                     { 0, 0, 0, 0, 1, 0 }
                    };

 */

       //cargar valores a la matriz Sparce que devuelva una mS
       public ClsSparce CargarSparce(int[,] A)
        {
            ClsSparce p = new ClsSparce();
            p.F = A.GetLength(0);//filas
            p.C = A.GetLength(1);//columna
            p.cant = 1;
            p.Sparce[0, 0] = p.F;
            p.Sparce[0, 1] = p.C;
            for (int i = 0; i < p.F; i++)
            {
                for (int j = 0; j < p.C; j++)
                {
                    if (A[i,j]!=0)
                    {
                        p.Sparce[p.cant, 0] = i;
                        p.Sparce[p.cant, 1] = j;
                        p.Sparce[p.cant, 2] = A[i,j];
                        p.cant++;
                    }


                }
            }
            p.Sparce[0, 2] =p.cant - 1;
           // Console.WriteLine(p.MostrarMatrizSparce());
            return p;
        }

        public ClsSparce CargarSparce2(int[,] A)
        {
           
            F = A.GetLength(0);//filas
            C = A.GetLength(1);//columna
            cant = 1;
            Sparce[0, 0] = F;
            Sparce[0, 1] = C;
            for (int i = 0; i < F; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (A[i, j] != 0)
                    {
                        Sparce[cant, 0] = i;
                        Sparce[cant, 1] = j;
                        Sparce[cant, 2] = A[i, j];
                        cant++;
                    }


                }
            }
            Sparce[0, 2] = cant - 1;
            // Console.WriteLine(p.MostrarMatrizSparce());
            return this;
        }

        //-- Mostrar Mostrar Original
        public String MostrarMatriz(int[,] A)
        {
            String S = "";
            F = A.GetLength(0);//fila
            C = A.GetLength(1);//columna
            for (int i = 0; i < F; i++)
            {
                S = S + "\n";//salto de Linea
                for (int j = 0; j <C; j++)
                {
                    S = S + "[" + A[i, j] + "]";
                }
                //S = S + "\n";//salto de Linea
            }
            return S;
        }

        //-- Mostrar Mostrar Original
        public String MostrarMatrizSparce()
        {
            String S = "";
          
            for (int i = 0; i < cant; i++)
            {
                //S = S + "\n";//salto de Linea
                for (int j = 0; j < 3; j++)
                {
                    S = S + "[" + Sparce[i, j] + "]";
                }
                S = S + "\n";//salto de Linea
            }
            return S;
        }
        //a)A = B x C
        /*
        public ClsSparce Multiplicacion(ClsSparce matrizB,ClsSparce matrizC)
        {
            if (matrizB.C != matrizC.F)
            {
                Console.WriteLine(" el numero de MatrizB.C deber ser igual a MatrizC.F");
            }
            ClsSparce A = new ClsSparce();
            A.F = matrizB.F;//6
            A.C = matrizC.C;//6
            A.Sparce[0, 0] = A.F;
            A.Sparce[0, 1] = A.C;

            A.cant = 1;
            for (int i = 0; i < matrizB.F; i++)
            {
                for (int j = 0; j < matrizC.C; j++)
                {
                    int valorA = 0;
                    for (int k = 0; k < matrizB.C; k++)
                    {
                        valorA = A.Sparce[A.cant, 2] + (matrizB.Sparce[i, k] * matrizC.Sparce[k, j]);

                        
                    }
                    A.Sparce[A.cant, 0] = i;
                    A.Sparce[A.cant, 1] = j;
                    A.Sparce[A.cant, 2] = valorA;


                }

            }


            A.Sparce[0, 2] = A.cant - 1;
            Console.WriteLine(A.MostrarMatrizSparce());
            return A;
        }

        */

        public ClsSparce Multiplicacion(int[,] matrizB, int[,] matrizc)
        {
            F = matrizB.GetLength(0);// 
            C = matrizB.GetLength(1);
            int filaDelaC = matrizc.GetLength(0);
            int columnaDelaC = matrizc.GetLength(1);

            int[,] D = new int[C,filaDelaC];
            ClsSparce n = new ClsSparce();
            if (C == filaDelaC)
            {
                for (int i = 0; i < F; i++)
                {
                    for (int j = 0; j < columnaDelaC; j++)
                    {
                        int s = 0;
                        for (int k = 0; k < filaDelaC; k++)
                        {
                            s += matrizB[i, k] * matrizc[k, j];

                        }
                        D[i, j] = s;
                    }
                }
                /*
                Console.WriteLine("------------------------------");
                Console.WriteLine(MostrarMatriz(D));
                Console.WriteLine("------------------------------");
                Console.WriteLine(n.CargarSparce(D).MostrarMatrizSparce());*/
            }
            n.CargarSparce(D);
            Console.WriteLine(n.MostrarMatrizSparce());
            return n;

        }



        public bool Existe(int x,int y)
        {
            int i = 1;
            bool s = false;
            while(i<cant && (s == false))
            {
                if ((Sparce[i,0]==x && Sparce[i, 1] == y))
                {
                    s = true;
                }
                i++;
            }
            return s;
        }

        public ClsSparce diagonal()
        {
            ClsSparce m = new ClsSparce();
            for (int i = 0; i < cant; i++)
            {
                if (Existe(i, i))
                {
                    m.Sparce[m.cant, 0] = Sparce[i, 0];
                    m.Sparce[m.cant, 1] = Sparce[i, 1];
                    m.Sparce[m.cant, 2] = Sparce[i, 2];
                    m.cant++;
                }   
            }
            return m;
        }
                              //A con datos  ,B sin datos
        public void Transpose(ClsSparce A, ClsSparce B)
        {
            int m = A.Sparce[0, 0];//f
            int n = A.Sparce[0, 1];//C
            int t = A.Sparce[0, 2];//t numero de terminos
            B.Sparce[0, 0] = n;//
            B.Sparce[0, 1] = m;//
            B.Sparce[0, 2] = t;//
            B.F = n;
            B.C = m;
            B.cant = t;
            if (t <= 0)
            {

                return;
            }
            int q = 1;  //es la posicion del siguiente termono de B
            for (int col = 0; col < n; col++)
            {
                for (int p = 1; p <= t; p++)
                {
                    if (A.Sparce[p, 1] == col)
                    {
                        B.Sparce[q, 0] = A.Sparce[p, 1];
                        B.Sparce[q, 1] = A.Sparce[p, 0];
                        B.Sparce[q, 2] = A.Sparce[p, 2];


                        q++;
                    }
                }
            }
            Console.WriteLine(MostrarMatrizSparce());

        }

        public void Fast_Transpose(ClsSparce A, ClsSparce B)
        {
            int m = A.Sparce[0, 0];//f
            int n = A.Sparce[0, 1];//C
            int t = A.Sparce[0, 2];//t numero de terminos
            B.Sparce[0, 0] = n;//
            B.Sparce[0, 1] = m;//
            B.Sparce[0, 2] = t;//
            B.F = n;
            B.C = m;
            B.cant = t;
            int[] S = new int[n];
            int[] T = new int[n];
            if (t <= 0)
            {

                return;
            }
            for (int i = 0; i < n; i++)////C=6
            {
                S[i] = 0;
            }
            for (int i = 1; i <= t; i++)//cantidad
            {
                S[A.Sparce[i, 1]] = S[A.Sparce[i, 1]] + 1;
            }
            T[0] = 1;
            for (int i = 1; i < n; i++)
            {
                T[i] = T[i - 1] + S[i - 1];
            }
            for (int i = 1; i <= t; i++)
            {
                int j = A.Sparce[i, 1];
                B.Sparce[T[j], 0] = A.Sparce[i, 1];
                B.Sparce[T[j], 1] = A.Sparce[i, 0];
                B.Sparce[T[j], 2] = A.Sparce[i, 2];
                T[j] = T[j] + 1;
            }

        }














    }
}
