using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Tool : Collectable
    {
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            DoAction(); // tools perform an action when added.
        }

        public virtual void DoAction()
        {
        }
    }
}
