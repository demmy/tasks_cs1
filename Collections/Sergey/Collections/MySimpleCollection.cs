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
            _loger.Log("The collection going to be empty", ToString());
            base.ClearItems();
            _loger.Log("The collection is empty", ToString());
        }
        protected override void InsertItem(int index, T item)
        {
            _loger.Log("Before entering the item", ToString());
            base.InsertItem(index, item);
            _loger.Log("After entering the item", ToString());
        }

        protected override void RemoveItem(int index)
        {
            _loger.Log(string.Format("Before removing the item {0} on index {1}", base[index], index), Count, ToString());
            base.RemoveItem(index);
            _loger.Log("After removing of the item", ToString());
        }

        protected override void SetItem(int index, T item)
        {
            _loger.Log(string.Format("Before setting item {0} on index {1}", item.ToString(), index), ToString());
            base.SetItem(index, item);
            _loger.Log("After setting item", ToString());
        }

        public override string ToString()
        {
            return Items.Aggregate("{", (currentString, el) => currentString + (el.ToString() + ", ")) + "}";
        }
    }
}
