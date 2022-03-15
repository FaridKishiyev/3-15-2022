using System;
using System.Collections.Generic;
using System.Text;

namespace elayazmisamaxi.models
{
    class product
    {

       public int no;
       public string name;
       public double price;
       public int count;

        public product(int no, string name, double price, int count)
        {
            this.no = no;
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public product()
        {

        }
    }
}
//No
//- Name
//- Price
//- Count