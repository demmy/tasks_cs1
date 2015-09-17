using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Nikita
{
    class CollectionsExercises : ICollectionsExercises
    {
        public void WorkPriorityQueue()
        {
            MyLogger logger = new MyLogger();
            MySingleCollection<int> coll = new MySingleCollection<int>(logger);
            coll.Add(5);
            coll.Add(4);
            coll.Add(2);
            coll.Add(40);
            coll.Add(2);
            coll.Add(1);

            coll.RemoveAt(2);
            coll.Clear();
            logger.ShowAllItems();
            
        }
    }
}
