using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1.Model
{
    public class Rule
    {
        public int MinimumUsablePoint { get; set; }

        public Rule()
        {
            MinimumUsablePoint = 1000; // Default value
        }
    }
}
