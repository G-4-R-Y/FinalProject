using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Storage
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              StorageId       { get; set; }
        public  DateTime                           Validity        { get; set; }
        public  DateTime                           Date            { get; set; }
        public  DateTime                           Expiration      { get; set; }
        public  double                             Cost            { get; set; }
        public  int                                Quantity        { get; set; }
        public  int                                Lot             { get; set; }
        public  bool                               Canceled        { get; set; }
        public  double                             Total           { get; set; }

        public  long?                              ProductId       { get; set; }
      [ForeignKey("ProductId")]
        public  virtual Product                    Product         { get; set; }

      /*------------------------------------------------------------------------------*/
        public Storage()
        {
            Canceled = false;
        }

        public Storage(DateTime validity, DateTime expiration, double cost, int quantity, int lot, DateTime date)
        {
            Validity = validity;
            Expiration = expiration;
            Cost = cost;
            Quantity = quantity;
            Lot = lot;
            Date = date;
            Product = null;
            Canceled = false;
            Total = Cost * Quantity;
        }
    }
}
