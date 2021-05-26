using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nВыберите номер задания (1-3)");
                int g = Convert.ToInt32(Console.ReadLine());

                switch (g)
                {
                    case 1:
                        Console.WriteLine("Найти номер минимального по модулю элемента массива.\nНапример, в массиве[10, -3, -5, 2, 5] минимальным по модулю элементом является число 2.Его номер 3.\n");
                        int min = 999999;
                        int id = 0;
                        int[] mas = new int[5] { 1, 5, -8, 0, 11 };
                        for (int i = 0; i < mas.Length; i++)
                        {
                            Console.Write(mas[i] + "\t");
                            if (mas[i] < 0)
                            {
                                mas[i] *= -1;
                            }

                            if (mas[i] < min)
                            {
                                min = mas[i];
                                id = i;
                            }
                        }
                        Console.WriteLine("\nМинимальный по модулю элемент:" + id);
                        break;


                    case 2:
                        Console.WriteLine("В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран. То есть найти и вывести уникальные элементы массива. Пример: [1,5,2,1,2,3]->5,3\n");
                        int[] mas1 = new int[5] { 1, 5, 1, 0, 11 };


                        //вывод
                        for (int i = 0; i < mas1.Length; i++)
                        {
                            Console.Write(mas1[i] + "\t");
                        }


                        //операция
                        for (int i = 0; i < mas1.Length; i++)
                        {
                            for (int j = 0; j < mas1.Length; j++)
                            {

                                if ((mas1[i] == mas1[j]) && (i != j))
                                {
                                    mas1[i] = -999999;
                                    mas1[j] = -999999;
                                }
                            }
                        }

                        Console.WriteLine("\nУникальные элементы массива:");
                        for (int i = 0; i < mas1.Length; i++)
                        {
                            if (mas1[i] != -999999)
                            {
                                Console.Write(mas1[i] + " ");
                            }
                        }
                        break;


                    case 3:
                        Console.WriteLine("Заполнить массив случайными положительными и отрицательными целыми числами. Вывести его на экран. Удалить из массива все отрицательные элементы и снова вывести.");
                        int[] masrand = new int[10];
                        Random rand = new Random();
                        for (int i = 0; i < masrand.Length; i++)
                        {
                            masrand[i] = rand.Next(-50, 50);
                            Console.Write(masrand[i] + " ");
                        }


                        Console.WriteLine("");
                        for (int i = 0; i < masrand.Length; i++)
                        {
                            if (masrand[i] > 0)
                            {
                                Console.Write(masrand[i] + " ");
                            }
                        }
                        break;
                }
            }
        }
    }
}
