using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum OutingType
    {
        Golf = 1, Bowling, Skiing, Concert
    }

    public class Outing
    {
        public Outing(int people, string date, decimal costperhead, double outingcost, OutingType type)
        {
            People = people;
            Date = date;
            CostPerHead = costperhead;
            OutingCost = outingcost;
            Type = type;
        }

        public int People { get; set; }
        public string Date { get; set; }
        public decimal CostPerHead { get; set; }
        public double OutingCost { get; set; }
        public OutingType Type { get; set; }
    }
}
