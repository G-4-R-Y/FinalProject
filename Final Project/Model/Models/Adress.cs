using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    public class Adress
    {
      //#access #type  &  Relations                #PropName 
        public  long?                              AdressId     { get; set; }
        public  string                             Street       { get; set; }
        public  string                             Details      { get; set; }
        public  string                             Neighborhood { get; set; }
        public  string                             City         { get; set; }
        public  string                             PostalCode   { get; set; }
        public  int                                Number       { get; set; }
        
        public  long?                              OwnerId      { get; set; }
        [ForeignKey("OwnerId")]
        public  virtual Owner                      Owner { get; set; }
        
        public  long?                              VetId        { get; set; }
        [ForeignKey("VetId")]
        public  virtual Vet                        Vet   { get; set; }
      /*------------------------------------------------------------------------------*/
        public Adress(string street, string details, string neighborhood, string city, string postalCode, int number)
        {
            Street       = street;
            Details      = details;
            Neighborhood = neighborhood;
            City         = city;
            PostalCode   = postalCode;
            Number       = number;
        }
    }
}
