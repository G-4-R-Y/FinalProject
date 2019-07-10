using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Persistence.Interfaces
{
    public interface IDataAccessLayer<T>
    {
        IList<T> ShowAll();

        void Insert(T toBeInserted);

        void Alter(T toBeAltered);

        void Remove(long? Id);

        T GetById(long? Id);
    }
}
