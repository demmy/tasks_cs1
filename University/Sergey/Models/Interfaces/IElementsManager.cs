using System.Collections.Generic;

namespace University.Sergey.Models.Interfaces
{
    interface IElementsManager<T>
    {
        void Add(T item);
        void AddRange(IEnumerable<T> items);
        void Remove(T item);
    }
}
