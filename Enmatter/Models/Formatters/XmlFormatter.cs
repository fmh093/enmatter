using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;

namespace Enmatter.Formatters
{
    class XmlFormatter : Formatter
    {
        public XmlFormatter()
        {
            Name = "Xml Formatter";
        }

        public override string Translate(string input)
        {
            throw new NotImplementedException();
        }
    }
}
