using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klimatyzacja
{
    class TermValues
    {
        public double Level;
        public double Value;

        public TermValues(double level, double @value)
        {
            Level = level;
            Value = @value;
        }
    }
}