using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Sale
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              SaleId         { get; set; }
        public  DateTime                           Date           { get; set; }
        public  DateTime                           ExpirationDate { get; set; }
        public  bool                               Canceled       { get; set; }
        public  double                             TotalValue     { get; set; }
        
        public  virtual List<SaleProduct>          SaleProduct    { get; set; }

        /*public  long?                              OwnerId        { get; set; }
      [ForeignKey("OwnerId")]
        public  virtual Owner                      Owner          { get; set; }*/
      /*------------------------------------------------------------------------------*/
        public Sale()
        {
            Canceled = false;
        }

        public Sale(DateTime date, DateTime expirationDate)
        {
            Date = date;
            ExpirationDate = ExpirationDate;
            Canceled = false;
            SaleProduct = null;
        }
    }
}
