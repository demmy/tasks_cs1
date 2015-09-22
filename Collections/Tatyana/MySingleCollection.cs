using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tatyana
{
    class MySingleCollection<T>: System.Collections.ObjectModel.Collection<T>
    {
        ILogger history;

        public MySingleCollection(ILogger h)
        {
            history = h;
        }

        protected override void ClearItems()
        {
            string s="";
            foreach (var t in base.Items )
            {
                s+=" "+t.ToString();
            }
            history.Log("Delete all elements ", s);
            base.ClearItems();
        }
        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            history.Log("AddNewElement", "array[", index, "] =", item);
        }

        protected override void RemoveItem(int index)
        {
            history.Log("DeleteElement", "array[", index, "] =", base.Items[index]);
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, T item)
        {
            history.Log("SetElement", "array[", index, "] =", base.Items[index], "new value",  "array[", index, "] =", item);
                base.SetItem(index, item);
        }
       
    } 
}
