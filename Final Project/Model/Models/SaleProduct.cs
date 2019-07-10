using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class SaleProduct
    {
      //#access #type  &  Relations                  #PropName 
        public  long?                                SaleProductId { get; set; }
        public  int                                  Quantity      { get; set; }
        public  int                                  Lot           { get; set; }
        
        public  long?                                SaleId        { get; set; }
      [ForeignKey("SaleId")]
        public  virtual Sale                         Sale          { get; set; }

        public  long?                                ExamId        { get; set; }
      [ForeignKey("ExamId")]
        public  virtual Exam                         Exam          { get; set; }

        public  long?                                ProductId     { get; set; }
      [ForeignKey("ProductId")]
        public  virtual Product                      Product       { get; set; }
      /*------------------------------------------------------------------------------*/
      //Methods:
        public SaleProduct()
        {

        }

        public SaleProduct(long? saleId, int quantity)
        {
            SaleId = saleId;
            Quantity = quantity;
        }
    }
}
