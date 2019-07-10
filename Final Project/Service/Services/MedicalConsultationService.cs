using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class MedicalConsultationService : ServiceGeneric<MedicalConsultation>
    {
        private MedicalConsultationDAL medicalConsultationDAL = new MedicalConsultationDAL();

        public override IList<MedicalConsultation> ShowAll()
        {
            return medicalConsultationDAL.ShowAll();
        }

        public IList<MedicalConsultation> ShowAll(Vet vet)
        {
            return medicalConsultationDAL.ShowAll(vet);
        }

        public IList<MedicalConsultation> ShowAll(Owner owner)
        {
            return medicalConsultationDAL.ShowAll(owner);
        }

        public IList<MedicalConsultation> ShowAll(Pet pet)
        {
            return medicalConsultationDAL.ShowAll(pet);
        }
    }
}
