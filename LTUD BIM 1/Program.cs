
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LTUD_BIM_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double T = 0;
            for (int i = 0; i < n; i++)
            {
                T = 0;
                Console.WriteLine("i=" + i.ToString()); //debug 
                for (int j = 0; j < n; j++)
                {
                   
                    Console.WriteLine("     j=" + j.ToString());
                    T = T + i;
                    Console.WriteLine("Tong = " + T.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tong = " + T.ToString());
            Console.ReadLine();

            // b1// nhap vao 1 day so
            Console.Write("Nhap vao a:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao A[" + i.ToString() + "]=");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            //b2// nhap vao 1 ma tran
            Console.Write("Nhap vao m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao n:");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] B = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap vao B[" + i.ToString() + "," + j.ToString() + "]=");
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //b3// nhap vao ma tran vuong A [nxn] và tính tổng các phần tử trên đường chéo trên
            //b4 tich lam giong het
            Console.Write("Nhap vao n:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] C = new int[n];
            for (int i = 0; i < n; i++)
            {    
                    Console.Write("Nhap vao C[" + i.ToString() + "]=");
                    C[i] = Convert.ToInt32(Console.ReadLine());  
            }
            double Tong = 0;
            for (int i = 0; i < n; i++)
            {
                    Tong = Tong + C[i];  
            }
            Console.Write("Tong  = " + Tong.ToString());
            Console.ReadLine();
            // ma trận 2 
            Console.Write("Nhap vao m hang:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao n cot:");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] D = new int[m, n];
            
            //nhap theo hang//

            for (int i = 0; i < m; i++)
            
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap vao D[" + i.ToString() + "," + j.ToString() + "]=");
                    D[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            //in
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(D[i, j]);
                }
                Console.ReadLine();
            }
                    double TONG = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                  TONG = TONG + D[i, j];  
                }    
                    
            }
            Console.Write("TONG = " + TONG.ToString());
            Console.ReadLine();

            // nhập 1 dãy n tahcs 2 dãy <=0 >0//
            Console.Write("Nhập n =");
            n= Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int[] DG = new int[n];
            int[] AM = new int[n];

            int demdg = 0;
            int demam = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao A[" + i.ToString() + "]=");
           
                a[i] = Convert.ToInt32(Console.ReadLine());

                if (a[i] > 0)
                {
                    DG[demdg] = a[i];
                    demdg++;
                }    
                else
                {
                    AM[demam] = a[i];
                    demam++;

                }    

            }
            Console.Write("day >0:");
            for (int i = 0; i < demdg; i++) 
            Console.Write(DG[i] + " ");

            Console.Write("day <=0:");
            for (int i = 0; i < demam; i++) 
            Console.Write(AM[i] + " ");


            // nhập 1 dãy n sắp xếp theo thứ tự tăng dần//
            Console.Write("Nhap vao a:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao b[" + i.ToString() + "]=");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (b[i] > b[j])
                    {
                        int TG = b[i];
                        b[i] = b[j];
                        b[j] = TG;
                    }
                }
            }
            Console.WriteLine("day da sap xep:");
            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");


        }
    }
}
