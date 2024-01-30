using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : IDisplayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        // AddMe is now abstract, requiring derived classes to implement their own logic.
        public abstract void AddMe(List<Collectable> collectables);

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }
    }
}
