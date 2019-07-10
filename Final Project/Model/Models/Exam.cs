using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Exam
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              ExamId { get; set; }
        public  string                             Name   { get; set; }
        public  double                             Cost   { get; set; }
      /*------------------------------------------------------------------------------*/
      //Methods:
        public override string ToString()
        {
            return Name;
        }

        public Exam()
        {

        }

        public Exam(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
