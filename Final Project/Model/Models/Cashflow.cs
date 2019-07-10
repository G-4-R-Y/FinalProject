using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Cashflow
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              CashflowId { get; set; }
        public  bool                               Paid       { get; set; }
        public  bool                               Canceled   { get; set; }

        public    long?                            EarningId  { get; set; }
      [ForeignKey("EarningId")]
        public    Earning                          Earning    { get; set; }

        public    long?                            PaymentId  { get; set; }
      [ForeignKey("PaymentId")]
        public    Payment                          Payment    { get; set; }
      /*------------------------------------------------------------------------------*/
        public Cashflow()
        {
            Paid = false;
            Canceled = false;
        }
    }
}
