using System;
using elayazmisamaxi.models;

namespace elayazmisamaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neçe kitab olacaq?");
            int num = Convert.ToInt32(Console.ReadLine());
            book[] datas = new book[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("No");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Book Name");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Book price");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Book count");
                int count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Book genre");
                string genre = Convert.ToString(Console.ReadLine());

                datas[i] = new book(genre,no,name,price,count);

            }

            double option;
            
            do
            {
                
                Console.WriteLine("0. Proqrami bagla");
                Console.WriteLine("1. Kitablari qiymete gore filterle");
                Console.WriteLine("2. Butun kitablari goster");
                option = Convert.ToDouble(Console.ReadLine());

                if (option == 1)
                {
                    double min = Convert.ToDouble(Console.ReadLine());
                    double max = Convert.ToDouble(Console.ReadLine());

                    for (int i = 0; i < datas.Length; i++)
                    {
                        if (datas[i].price > min && datas[i].price<max)
                        {
                            Console.WriteLine($"Name: {datas[i].name}\n Genre: {datas[i].genre}\n No: {datas[i].no}\n Price: {datas[i].price}\n Count: {datas[i].count}");
                        }
                    }
                    

                }

                if (option==2)
                {
                    foreach (var a in datas)
                    {
                        a.GetInfo();
                    }
                }


            } while (option != 0) ;
        }
    }
}
