using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main (string[] args)
        {
            //16
            /*Random r=new Random();
            
            int[,] s2 = new int[6,6];
            for (int i=0;i<6;i++)
            {
                for (int j=0;j<6;j++)
                {
                    s2[i, j] = r.Next(-20, 30);
                    Console.Write(s2[i, j]+"\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            int count3 = 0;
            Console.WriteLine("-------");
            for (int i = 0; i < 6; i++)
            {
                int count = 0; 
                for (int j = 0; j < 6; j++)
                {         
                    if (s2[i,j]>0 && s2[i,j]%5==0)
                    {
                        sum = sum + s2[i, j];
                        count3++;
                    }

                    if (s2[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.Write($"{i + 1} строка = {count}|");
            }

            Console.WriteLine("\n\n");
            for (int i = 0; i < 6; i++)
            {        
                int count2 = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (s2[j, i] % 2 == 0)
                    {
                        count2++;
                    }
                } 
                Console.Write($"{i + 1} столбец = {count2}|");
            }
            int ss = sum / count3;
            Console.WriteLine($"\nСреднее арифметичское = {ss} ");

            Console.ReadKey();*/

            //19
            try
            {
                Random r = new Random();
                Console.WriteLine("Введите кол-во строк");
                int ss1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                int ss2 = int.Parse(Console.ReadLine());

                int[,] s2 = new int[ss1, ss2];
                for (int i = 0; i < ss1; i++)
                {
                    for (int j = 0; j < ss2; j++)
                    {
                        s2[i, j] = r.Next(-20, 30);
                        Console.Write(s2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nВведите a = ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < ss1; i++)
                {
                    int count1 = 0;
                    for (int j = 0; j < ss2; j++)
                    {
                        if (s2[i, j] % a == 0)
                            count1++;

                    }
                    Console.WriteLine($"{i + 1} строка: кол-во элементов кратных {a} = {count1} ");
                }
                Console.WriteLine("\n\n");
                for (int i = 0; i < ss2; i++)
                {
                    int count2 = 0;
                    for (int j = 0; j < ss1; j++)
                    {
                        if (s2[j, i] % a == 0)
                            count2++;
                    }
                    Console.WriteLine($"{i + 1} столбец: кол-во элементов кратных {a} = {count2} ");
                }




                Console.Write("\n\nВведите b = ");
                int b = int.Parse(Console.ReadLine());

                for (int i = 0; i < ss1; i++)
                {
                    int count1 = 0;
                    for (int j = 0; j < ss2; j++)
                    {
                        if (s2[i, j] % b == 0)
                            count1++;

                    }
                    Console.WriteLine($"{i + 1} строка: кол-во элементов кратных {b} = {count1} ");
                }
                Console.WriteLine("\n\n");
                for (int i = 0; i < ss2; i++)
                {
                    int count2 = 0;
                    for (int j = 0; j < ss1; j++)
                    {
                        if (s2[j, i] % b == 0)
                            count2++;
                    }
                    Console.WriteLine($"{i + 1} столбец: кол-во элементов кратных {b} = {count2} ");
                }



                //произведение отрицательных
                Console.Write("\n\nВведите k1 = ");
                int k1 = int.Parse(Console.ReadLine());

                Console.Write("\n\nВведите k2 = ");
                int k2 = int.Parse(Console.ReadLine());
                double en = 1;
                for (int i = k1-1; i < k2; i++)
                {

                    for (int j = 0; j < ss1; j++)
                    {
                        if (s2[i, j] < 0)
                        {
                            Console.WriteLine(s2[i, j]);
                            en *= s2[i, j];
                        }
                    }
                }
                Console.WriteLine("Произведение = "+ Math.Round(en, 2));
            }
            catch { Console.WriteLine("Ошибка"); }
            Console.ReadKey();
        }
    }
}
