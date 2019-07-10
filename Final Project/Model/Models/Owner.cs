using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace Model.Models
{
    public class Owner
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              OwnerId        { get; set; }
        public  string                             Name           { get; set; }
        public  string                             CPF            { get; set; }
        public  string                             Email          { get; set; }
        public  string                             Telephone      { get; set; }
        public  string                             CellPhone      { get; set; }
        public  double                             PendingPayment { get; set; }
        public  DateTime                           Birthday       { get; set; }
        public  int                                Age            { get;      }
 
        public  virtual  List<Adress>              Adress              { get; set; }
        public  virtual  List<Pet>                 PetsOwned           { get; set; }
        public  virtual  List<MedicalConsultation> ConsultationHistory { get; set; }
      /*------------------------------------------------------------------------------*/
      //Methods:
        protected Owner()
        {

        }

        public override string ToString()
        {
            return Name;
        }

        public Owner(String name, String cpf)
        {
            Name = name;
            CPF = cpf;
        }

        public Owner(String name, String cpf, String email, String telephone, String cellPhone, DateTime birthday)
        {
            Name = name;
            CPF = cpf;
            Email = email;
            Telephone = telephone;
            CellPhone = cellPhone;
            Birthday = birthday;
            Age = DateTime.Now.Year - Birthday.Year;
            if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                Age -= 1;
        }
    }
}
