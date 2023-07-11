using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Aggregator.CallRAN2G15MinAggSP();
            Aggregator.CallRAN2GCountersSP();
            Aggregator.CallRAN2GKPIsSP();
        }
    }
}
