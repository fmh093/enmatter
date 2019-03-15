using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Enmatter.Models;

namespace Enmatter.Formatters
{
    class XmlFormatter : Formatter
    {
        public XmlFormatter()
        {
            Name = TranslatorStaticNames.XmlFormatter;
        }

        public override string Translate(string input)
        {
            var doc = XDocument.Parse(input);
            return doc.ToString();
        }
    }
}
