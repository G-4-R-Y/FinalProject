using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public abstract class EarnPay
    {
      //#access #type  &  Relations                #PropName 
        public  abstract double                             Value          { get; set; }
        public  abstract bool                               Paid           { get; set; }
        public  abstract DateTime                           Date           { get; set; }
        public  abstract DateTime                           ExpirationDate { get; set; }
        public  abstract bool                               Canceled       { get; set; }
    }
}
