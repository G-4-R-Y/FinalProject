using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.Interfaces;
using System.Linq;

namespace Persistence.RepositoryFiles
{
    public class VetDAL : RepositoryGeneric<Vet>, IDataAccessLayer<Vet>
    {
        public override Vet GetById(long? vetId)
        {
            //recupera pelo Id
            try
            {
                using (var context = new EFContext())
                {
                    return context.Vets.Where(vet => vet.VetId.Equals(vetId)).FirstOrDefault();
                }
            }
            catch
            {
                throw new Exception("Não foi possível modificar a base de dados.");
            }
        }
    }
}
