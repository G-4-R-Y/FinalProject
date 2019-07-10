using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class MedicalConsultationDAL : RepositoryGeneric<MedicalConsultation>, IDataAccessLayer<MedicalConsultation>
    {
        private EFContext context;

        public override IList<MedicalConsultation> ShowAll()
        {
            return base.ShowAll();
        }

        public IList<MedicalConsultation> ShowAll(Vet vet)
        {
            using (var context = new EFContext())
            {
                return context.MedicalConsultations.Where(mc => mc.VetId == vet.VetId).ToList<MedicalConsultation>();
            }
        }

        public IList<MedicalConsultation> ShowAll(Owner owner)
        {
            using (var context = new EFContext())
            {
                return context.MedicalConsultations.Where(mc => mc.OwnerId == owner.OwnerId).ToList<MedicalConsultation>();
            }
        }

        public IList<MedicalConsultation> ShowAll(Pet pet)
        {
            using (var context = new EFContext())
            {
                return context.MedicalConsultations.Where(mc => mc.PetId == pet.OwnerId).ToList<MedicalConsultation>();
            }
        }

        public override void Insert(MedicalConsultation medicalConsultation)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (medicalConsultation.VetId != null)
                medicalConsultation.Vet = null;

            if (medicalConsultation.OwnerId != null)
                medicalConsultation.Owner = null;

            if (medicalConsultation.PetId != null)
                medicalConsultation.Pet = null;

            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.MedicalConsultations.Add(medicalConsultation);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public override void Alter(MedicalConsultation medicalConsultation)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (medicalConsultation.VetId != null)
                medicalConsultation.Vet = null;

            if (medicalConsultation.OwnerId != null)
                medicalConsultation.Owner = null;

            if (medicalConsultation.PetId != null)
                medicalConsultation.Pet = null;

            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(medicalConsultation).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }
        }
    }
}
