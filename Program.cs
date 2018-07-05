using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            while (true)
            {
                Console.WriteLine("Выберите задание\t\tЗадании 5\n\n6: Выход\n");
                x = Int32.Parse(Console.ReadLine());
                if(x==1)
                {
                    Console.Clear();
                    task1();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(x ==2)
                {
                    Console.Clear();
                    task2();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(x ==3)
                {
                    Console.Clear();
                    task3();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(x ==4)
                {
                    Console.Clear();
                    task4();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(x ==5)
                {
                    Console.Clear();
                    task5();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (x ==6)
                {
                    Console.Clear();
                    break;
                }
            }
        }
        static void task1()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Random rnd = new Random();

            Console.WriteLine("Заполните массив целых чисел");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(1, 9);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n________________\n\n");

            foreach (var item in A)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine("\n\n________________\n\n");

            int proiz = 1;
            for (int i = 0; i < 5; i++)
            {
                proiz = proiz * A[i];
            }
            int Sum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Sum = Sum + A[i];
                }
            }
            Console.WriteLine("\nОдномерный массив\nMax: " + A.Max() + "\nMin: " + A.Min() + "\nSum: " + A.Sum() + "\nПроизведение: " + proiz + "\nСумма четных чисел: " + Sum);
            Console.WriteLine();

            int[] TempB = new int[3 * 4];
            int h = 0;
            proiz = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TempB[h] = B[i, j];
                    h++;
                    proiz = proiz * B[i, j];
                }
            }
            Sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                    {
                        Sum = Sum + B[i, j];
                    }
                }
            }
            Console.WriteLine("\nДвумерный массив\nMax: " + TempB.Max() + "\nMin: " + TempB.Min() + "\nSum: " + TempB.Sum() + "\nПроизведение: " + proiz + "\nСумма нечетных столбцов: " + Sum);
            Console.WriteLine();
        }
        static void task2()
        {
            int M, N;
            Console.WriteLine("\nВведите размерность первого массива\n");
            M = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите размерность второго массива\n");
            N = Int32.Parse(Console.ReadLine());
            int[] Arr1 = new int[M];
            int[] Arr2 = new int[N];
            int counter = 0;
            Console.WriteLine("Заполните 1 массив");
            for (int i = 0; i < M; i++)
            {
                Arr1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Заполните 2 массив");
            for (int i = 0; i < N; i++)
            {
                Arr2[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Arr1[i] == Arr2[j])
                    {
                        counter++;
                    }
                }
            }
            int[] Arr3 = new int[counter];
            int h = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Arr1[i] == Arr2[j])
                    {
                        Arr3[h] = Arr1[i];
                        h++;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("\nПервый массив\n");
            foreach (var item in Arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nВторой массив\n");
            foreach (var item in Arr2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nТретий массив\n");
            foreach (var item in Arr3)
            {
                Console.Write(item + " ");
            }
        }
        static void task3()
        {
            string a;
            bool f = false;
            a = Console.ReadLine();
            a = a.ToLower();
            char[] temp = a.ToCharArray();

            int j = temp.Length - 1;
            for (int i = 0; i <= temp.Length / 2; i++)
            {
                if (temp[i] == temp[j])
                {
                    f = true;
                }
                else
                {
                    f = false;
                    break;
                }
                j--;
            }
            if (f == true)
            {
                Console.WriteLine("Полиндром");
            }
            else
            {
                Console.WriteLine("Не полиндром");
            }
        }
        static void task4()
        {
            string predlozhenie; int counter = 0;
            predlozhenie = Console.ReadLine();
            char[] temp = new char[predlozhenie.Length];
            temp = predlozhenie.ToCharArray();

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ' ')
                {
                    counter++;

                    if (temp[i + 1] == ' ')
                    {
                        counter--;
                    }
                }
            }
            counter += 1;
            Console.WriteLine("Количество слов в предложении: " + counter + "\n");
        }
        static void task5()
        {
            int[,] Arr = new int[5, 5];
            int[] Temp = new int[5 * 5];
            int sum = 0, counter = 0;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr[i, j] = rnd.Next(-100, 100);
                    Console.Write(string.Format(" {0} ", Arr[i, j]));
                    Temp[counter] = Arr[i, j];
                    counter++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Format("Минимальный элемент: {0}\nИндекс: {1}\n\nМаксимальный элемент: {2}\nИндекс: {3}", Temp.Min(), Array.IndexOf(Temp, Temp.Min()), Temp.Max(), Array.IndexOf(Temp, Temp.Max())));

            if (Array.IndexOf(Temp, Temp.Min()) < Array.IndexOf(Temp, Temp.Max()))
            {
                for (int i = Array.IndexOf(Temp, Temp.Min()); i <= Array.IndexOf(Temp, Temp.Max()); i++)
                {
                    sum = sum + Temp[i];
                }
            }
            if (Array.IndexOf(Temp, Temp.Min()) > Array.IndexOf(Temp, Temp.Max()))
            {
                for (int i = Array.IndexOf(Temp, Temp.Max()); i <= Array.IndexOf(Temp, Temp.Min()); i++)
                {
                    sum = sum + Temp[i];
                }
            }
            Console.WriteLine("Сумма: " + sum);
        }
    }
}
