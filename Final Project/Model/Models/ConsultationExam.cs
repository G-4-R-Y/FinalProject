using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class ConsultationExam
    {
      
      //#access #type  &  Relations                  #PropName 
        public  long?                                ConsultationExamId   { get; set; }
        
        public  long?                                MedicalConsultationId { get; set; }
      [ForeignKey("MedicalConsultationId")]
        public  virtual MedicalConsultation          MedicalConsultation   { get; set; }


        public  long?                                ExamId                { get; set; }
      [ForeignKey("ExamId")]
        public  virtual Exam                         Exam                  { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        public ConsultationExam(long? examId)
        {
            ConsultationExamId = null;
            ExamId = examId;
        }

        public ConsultationExam(long? medicalConsultationId, long? examId)
        {
            MedicalConsultationId = medicalConsultationId;
            ExamId                = examId;
        }
    }
}
