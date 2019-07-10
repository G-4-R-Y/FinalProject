using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class ConsultationProduct
    {
      //#access #type  &  Relations                  #PropName 
        public long?                                 ConsultationProductId { get; set; }
        public string                                Frequency              { get; set; }
        public string                                Dose                   { get; set; }

        public  long?                                MedicalConsultationId  { get; set; }
      [ForeignKey("MedicalConsultationId")]
        public virtual MedicalConsultation           MedicalConsultation    { get; set; }
        
        public  long?                                ProductId              { get; set; }
      [ForeignKey("ProductId")]
        public virtual Product                       Product                { get; set; }
        /*------------------------------------------------------------------------------*/
        //Methods:
        public ConsultationProduct(string dose, string frequency, long? productId)
        {
            ConsultationProductId = null;
            Dose = dose;
            Frequency = frequency;
            ProductId = productId;
        }

        public ConsultationProduct(string dose, string frequency, long? medicalConsultationId, long? productId)
        {
            Dose                  = dose;
            Frequency             = frequency;
            MedicalConsultationId = medicalConsultationId;
            ProductId             = productId;
        }
    }
}
