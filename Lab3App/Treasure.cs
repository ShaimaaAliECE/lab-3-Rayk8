using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Treasure : Collectable
    {
        public int Score { get; set; }

        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!");
            Board?.UpdateTotalScore(Score); // Update score when added.
        }
    }
}
