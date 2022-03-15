using System;
using System.Collections.Generic;
using System.Text;

namespace elayazmisamaxi.models
{
    class book : product
    {
        public string genre;

        public book(string genre, int no, string name, double price, int count):base(no,name,price,count)
        {
            this.genre = genre;

        }

        public void GetInfo() {
            Console.WriteLine($"Name: {name}\n Genre: {genre}\n No: {no}\n Price: {price}\n Count: {count}");

        }

        public book()
        {

        }
    }
}
