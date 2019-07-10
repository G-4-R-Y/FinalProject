using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Interfaces;
using Model.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class ConsultationProductDAL : RepositoryGeneric<ConsultationProduct>, IDataAccessLayer<ConsultationProduct>
    {
        private EFContext context;

        public override void Insert(ConsultationProduct consultationProduct)
        {
            if (consultationProduct.ProductId != null)
                consultationProduct.Product = null;

            if (consultationProduct.MedicalConsultationId != null)
                consultationProduct.MedicalConsultation = null;

            if (consultationProduct.ConsultationProductId > 0)
            {
                using (var context = new EFContext())
                {
                    context.Entry(consultationProduct).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new EFContext())
                {
                    context.ConsultationProducts.Add(consultationProduct);

                    context.SaveChanges();
                }
            }
        }

        public override IList<ConsultationProduct> ShowAll()
        {
            return base.ShowAll();
        }

        public IList<ConsultationProduct> ShowAll(long? petId)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationProducts.Where(cp => cp.MedicalConsultation.PetId == petId).ToList<ConsultationProduct>();
            }
        }

        public IList<ConsultationProduct> ShowAll(Owner owner)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationProducts.Where(ce => ce.MedicalConsultation.OwnerId == owner.OwnerId).ToList<ConsultationProduct>();
            }
        }

        public IList<ConsultationProduct> ShowAll(Vet vet)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationProducts.Where(ce => ce.MedicalConsultation.VetId == vet.VetId).ToList<ConsultationProduct>();
            }
        }

        public IList<ConsultationProduct> ShowAll(Pet pet)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationProducts.Where(ce => ce.MedicalConsultation.PetId == pet.PetId).ToList<ConsultationProduct>();
            }
        }

        public IList<ConsultationProduct> ShowAll(MedicalConsultation medicalConsultation)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationProducts.Where(ce => ce.MedicalConsultation.MedicalConsultationId == medicalConsultation.MedicalConsultationId).ToList<ConsultationProduct>();
            }
        }
    }
}
