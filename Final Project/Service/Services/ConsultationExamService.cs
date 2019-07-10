using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class ConsultationExamService : ServiceGeneric<ConsultationExam>
    {
        private ConsultationExamDAL consultationExamDAL = new ConsultationExamDAL();

        public override void Insert(ConsultationExam consultationExam)
        {
            consultationExamDAL.Insert(consultationExam);
        }

        public override IList<ConsultationExam> ShowAll()
        {
            return consultationExamDAL.ShowAll();
        }

        public IList<ConsultationExam> ShowAll(Vet vet)
        {
            return consultationExamDAL.ShowAll(vet);
        }

        public IList<ConsultationExam> ShowAllByOwner(Owner owner)
        {
            return consultationExamDAL.ShowAll(owner);
        }

        public IList<ConsultationExam> ShowAll(Pet pet)
        {
            return consultationExamDAL.ShowAll(pet);
        }

        public IList<ConsultationExam> ShowAll(MedicalConsultation medicalConsultation)
        {
            return consultationExamDAL.ShowAll(medicalConsultation);
        }
    }
}
