using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value)
        {
            this.Description = description;
            this.Score = score;
            this.Value = value;
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            Board?.UpdateTotalValue(Value); // Update value in addition to score.
        }
    }
}
