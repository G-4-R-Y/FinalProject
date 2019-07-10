using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Pet
    {
      //#access #type  &  Relations                #PropName
        public  long?                              PetId               { get; set; }
        public  string                             Name                { get; set; }
        public  string                             Species             { get; set; }
        public  DateTime                           Birthday            { get; set; }
        public  int                                Age                 { get;      }
 
        public  virtual  List<Product>             PrescriptedDrugs    { get; set; }
        public  virtual  List<MedicalConsultation> ConsultationHistory { get; set; }
        public  virtual  List<Exam>                ExamsHistory        { get; set; }
      
        public  long?                              OwnerId             { get; set; }
      [ForeignKey("OwnerId")]
        public  virtual Owner                      OwnedBy             { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        public override string ToString()
        {
            return Name;
        }

        protected Pet()
        {

        }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }

            public Pet(string name, DateTime birthday, long? ownerId, string species)
        {
            Name     = name;
            Birthday = birthday;
            Species  = species;

            Age      = DateTime.Now.Year - Birthday.Year;
            
            if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
                Age -= 1;

            OwnerId = ownerId;
        }
    }
}
