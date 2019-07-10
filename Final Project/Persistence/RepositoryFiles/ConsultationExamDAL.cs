using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class ConsultationExamDAL : RepositoryGeneric<ConsultationExam>, IDataAccessLayer<ConsultationExam>
    {
        private EFContext context;

        public override void Insert(ConsultationExam consultationExam)
        {
            if (consultationExam.ExamId != null)
                consultationExam.Exam = null;

            if (consultationExam.MedicalConsultationId != null)
                consultationExam.MedicalConsultation = null;

            if (consultationExam.ConsultationExamId > 0)
            {
                using (var context = new EFContext())
                {
                    context.Entry(consultationExam).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new EFContext())
                {
                    context.ConsultationExams.Add(consultationExam);

                    context.SaveChanges();
                }
            }
        }

        public override IList<ConsultationExam> ShowAll()
        {
            return base.ShowAll();
        }

        public IList<ConsultationExam> ShowAll(Owner owner)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationExams.Where(ce => ce.MedicalConsultation.OwnerId == owner.OwnerId).ToList<ConsultationExam>();
            }
        }

        public IList<ConsultationExam> ShowAll(Vet vet)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationExams.Where(ce => ce.MedicalConsultation.VetId == vet.VetId).ToList<ConsultationExam>();
            }
        }

        public IList<ConsultationExam> ShowAll(Pet pet)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationExams.Where(ce => ce.MedicalConsultation.PetId == pet.PetId).ToList<ConsultationExam>();
            }
        }

        public IList<ConsultationExam> ShowAll(MedicalConsultation medicalConsultation)
        {
            using (var context = new EFContext())
            {
                return context.ConsultationExams.Where(ce => ce.MedicalConsultation.MedicalConsultationId == medicalConsultation.MedicalConsultationId).ToList<ConsultationExam>();
            }
        }
    }
}
