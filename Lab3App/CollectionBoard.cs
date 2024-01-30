using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class CollectionBoard
    {
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }

        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {TotalScore}");
        }

        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
            //below prints the total value as well but not in expected output
            //Console.WriteLine($"Total Value is updated to: {TotalValue}");
        }
    }
}
