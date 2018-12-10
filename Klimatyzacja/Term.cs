using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klimatyzacja
{
    class Term
    {
        public Dictionary<string, List<TermValues>> Values;

        public Term()
        {
            Values = new Dictionary<string, List<TermValues>>();
        }
    }
}
