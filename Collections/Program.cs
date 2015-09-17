using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                ICollectionsExercises exercises = null;
                switch (args[0])
                {
                    case "Nikita":
                        exercises = new Nikita.CollectionsExercises();
                        break;
                    case "Taisiya":
                        exercises = new Taisiya.CollectionsExercises();
                        break;
                    case "Sergey":
                        exercises = new Sergey.CollectionsExercises();
                        break;
                    case "Tatyana":
                        exercises = new Tatyana.CollectionsExercises();
                        break;
                    default:
                        Console.WriteLine("Wrong argument. Choose one of: Nikita, Taisiya, Sergey, Tatyana");
                        break;
                }
                if (exercises != null)
                {
                    exercises.WorkPriorityQueue();
                }
            }
        }
    }
}
