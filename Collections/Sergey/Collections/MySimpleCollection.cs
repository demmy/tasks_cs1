using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections.Sergey.Loger;

namespace Collections.Sergey.Collections
{
    class MySimpleCollection<T>: Collection<T>
    {
        private static ILoger _loger;
        public MySimpleCollection(ILoger loger)
        {
            _loger = loger;
        }
        protected override void ClearItems()
        {
            _loger.Log("The collection going to be empty", ArrayToLogString());
            base.ClearItems();
            _loger.Log("The collection is empty", ArrayToLogString());
        }

        private string ArrayToLogString()
        {
            return Items.Aggregate("{", (currentString, el) => currentString + (el.ToString() + ", ")) + "}";
        }

        protected override void InsertItem(int index, T item)
        {
            _loger.Log("Before entering the item", ArrayToLogString());
            base.InsertItem(index, item);
            _loger.Log("After entering the item", ArrayToLogString());
        }

        protected override void RemoveItem(int index)
        {
            _loger.Log(string.Format("Before removing the item {0} on index {1}", base[index], index), Count, ArrayToLogString());
            base.RemoveItem(index);
            _loger.Log("After removing of the item", ArrayToLogString());
        }

        protected override void SetItem(int index, T item)
        {
            _loger.Log(string.Format("Before setting item {0} on index {1}", item.ToString(), index), ArrayToLogString());
            base.SetItem(index, item);
            _loger.Log("After setting item", ArrayToLogString());
        }
    }
}
