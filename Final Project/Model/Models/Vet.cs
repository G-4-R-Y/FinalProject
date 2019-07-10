using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Vet
    {
      //#access #type &  Relations                #PropName 
        public  long?                              VetId          { get; set; }
        public  string                             CRMV           { get; set; }
        public  string                             Name           { get; set; }
        public  string                             CPF            { get; set; }
        public  string                             Email          { get; set; }
        public  string                             Telephone      { get; set; }
        public  string                             CellPhone      { get; set; }
        public  DateTime                           Birthday       { get; set; }
        public  int                                Age            { get;      }
        
        public  virtual  List<MedicalConsultation> ConsultationHistory { get; set; }
        public  virtual  List<Adress>              Adress              { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        protected Vet()
        {

        }

        public override string ToString()
        {
            return Name;
        }

        public Vet(String name, String cpf)
        {
            Name = name;
            CPF = cpf;
        }

        public Vet(String name, String crmv, String cpf, String email, String telephone, String cellPhone, DateTime birthday)
        {
            Name = name;
            CPF = cpf;
            CRMV = crmv;
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
