using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class MedicalConsultation
    {
      //#access #type  &  Relations               #PropName 
        public  long?                             MedicalConsultationId { get; set; }
        public  DateTime                          AppointmentDate       { get; set; }
        
        public  List<ConsultationProduct>         PrescriptedProducts   { get; set; }
        public  List<ConsultationExam>            PrescriptedExams      { get; set; }

        public  long?                             VetId                 { get; set; }
      [ForeignKey("VetId")]
        public  Vet                               Vet                   { get; set; }

        public  long?                             OwnerId               { get; set; }
      [ForeignKey("OwnerId")]
        public  Owner                             Owner                 { get; set; }

        public  long?                             PetId                 { get; set; }
      [ForeignKey("PetId")]
        public  Pet                               Pet                   { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        public override string ToString()
        {
            return AppointmentDate.ToShortDateString();
        }

        public MedicalConsultation ()
        {

        }

        public MedicalConsultation(DateTime appointmentDate, long? vetId, long? ownerId, long? petId, List<ConsultationProduct> prescriptedProducts, List<ConsultationExam> prescriptedExams)
        {
            AppointmentDate     = appointmentDate;
            VetId               = vetId;
            OwnerId             = ownerId;
            PetId               = petId;
            PrescriptedProducts = prescriptedProducts;
            PrescriptedExams    = prescriptedExams;
        }
    }
}
