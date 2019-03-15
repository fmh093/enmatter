using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;

namespace Enmatter.Formatters
{
    class StacktraceFormatter : Formatter
    {
        public StacktraceFormatter()
        {
            Name = "Stacktrace Formatter";
        }

        public override string Translate(string input)
        {
            throw new NotImplementedException();
        }
    }
}
