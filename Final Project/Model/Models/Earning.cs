using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    //como se fosse um contas a receber, o nome em ingles Earning soa melhor que ToEarn
    public class Earning : EarnPay
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              EarningId      { get; set; }
        public  override double                    Value          { get; set; }
        public  override bool                      Paid           { get; set; }
        public  override DateTime                  Date           { get; set; }
        public  override DateTime                  ExpirationDate { get; set; }
        public  override bool                      Canceled       { get; set; }

        public long?                               SaleId         { get; set; }
      [ForeignKey("SaleId")]
        public virtual Sale                        Sale           { get; set; }
      /*------------------------------------------------------------------------------*/
      //Methods:
        public override string ToString()
        {
            return Convert.ToString(Value);
        }

        public Earning(double value, DateTime date, DateTime expirationDate, long? saleId)
        {
            Value          = value;
            Date           = date;
            ExpirationDate = expirationDate;
            SaleId         = saleId;
            Paid           = false;
            Canceled       = false;
        }
    }
}
