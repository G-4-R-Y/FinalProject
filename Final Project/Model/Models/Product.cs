using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Product
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              ProductId { get; set; }
        public  String                             Name      { get; set; }
        public  double                             Cost      { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        public override string ToString()
        {
            return Name;
        }

        protected Product()
        {

        }

        public Product(String name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
