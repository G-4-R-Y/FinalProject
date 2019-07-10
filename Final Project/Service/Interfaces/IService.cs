using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    interface IService<T>
    {
        IList<T> ShowAll();

        void Insert(T toBeInserted);

        void Alter(T toBeAltered);

        void Remove(long? Id);

        T GetById(long? Id);
    }
}
