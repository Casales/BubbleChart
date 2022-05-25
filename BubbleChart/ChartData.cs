using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleChart
{

    public class ChartData
    {
        public double Before { get; set; }
        public double After { get; set; }
        public int Media { get; set; }
        public int Tech { get; set; }
        public int Count { get; set; }
        public override int GetHashCode()
        {
            var code = HashCode.Combine(Before, After);
            return HashCode.Combine(code, Media);
        }
    }
}
