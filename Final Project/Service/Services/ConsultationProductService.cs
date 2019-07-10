using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class ConsultationProductService : ServiceGeneric<ConsultationProduct>
    {
        private ConsultationProductDAL consultationProductDAL = new ConsultationProductDAL();

        public override void Insert(ConsultationProduct consultationProduct)
        {
            consultationProductDAL.Insert(consultationProduct);
        }

        public override IList<ConsultationProduct> ShowAll()
        {
            return base.ShowAll();
        }

        public IList<ConsultationProduct> ShowAll(long? petId)
        {
            return consultationProductDAL.ShowAll(petId);
        }

        public IList<ConsultationProduct> ShowAll(Vet vet)
        {
            return consultationProductDAL.ShowAll(vet);
        }

        public IList<ConsultationProduct> ShowAllByOwner(Owner owner)
        {
            return consultationProductDAL.ShowAll(owner);
        }

        public IList<ConsultationProduct> ShowAll(Pet pet)
        {
            return consultationProductDAL.ShowAll(pet);
        }

        public IList<ConsultationProduct> ShowAll(MedicalConsultation medicalConsultation)
        {
            return consultationProductDAL.ShowAll(medicalConsultation);
        }
    }
}
