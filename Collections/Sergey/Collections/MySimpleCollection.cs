using System.Collections.ObjectModel;
using System.Linq;
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
            _loger.Log("The collection going to be empty", this);
            base.ClearItems();
            _loger.Log("The collection is empty", this);
        }
        protected override void InsertItem(int index, T item)
        {
            _loger.Log("Before entering the item", this);
            base.InsertItem(index, item);
            _loger.Log("After entering the item", this);
        }

        protected override void RemoveItem(int index)
        {
            _loger.Log(string.Format("Before removing the item {0} on index {1}", base[index], index), Count, this);
            base.RemoveItem(index);
            _loger.Log("After removing of the item", this);
        }

        protected override void SetItem(int index, T item)
        {
            _loger.Log(string.Format("Before setting item {0} on index {1}", item.ToString(), index), this);
            base.SetItem(index, item);
            _loger.Log("After setting item", this);
        }

        public override string ToString()
        {
            return Items.Aggregate("{", (currentString, el) => currentString + (el.ToString() + ", ")) + "}";
        }
    }
}
