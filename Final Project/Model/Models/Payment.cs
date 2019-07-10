using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    //como se fosse um contas a pagar, o nome em ingles Payment soa melhor que ToPay
    public class Payment : EarnPay
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              PaymentId      { get; set; }
        public  override double                    Value          { get; set; }
        public  override bool                      Paid           { get; set; }
        public  override DateTime                  Date           { get; set; }
        public  override DateTime                  ExpirationDate { get; set; }
        public  override bool                      Canceled       { get; set; } 

        public long?                               StorageId      { get; set; }
      [ForeignKey("StorageId")]
        public virtual Storage                     Storage        { get; set; }

      /*------------------------------------------------------------------------------*/
        public override string ToString()
        {
            return Convert.ToString(Value);
        }

        public Payment(double value, DateTime date, DateTime expirationDate, long? storageId)
        {
            Value = value;
            Date = date;
            ExpirationDate = expirationDate;
            StorageId = storageId;
            Paid = false;
            Canceled = false;
        }
    }
}
