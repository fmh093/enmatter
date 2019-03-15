using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    abstract class Translator
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OptionName { get; set; }
        public TranslatorType Type { get; set; }

        internal enum TranslatorType
        {
            Formatter = 0,
            Encoder = 10,
            Parser = 20,
            Misc = 30
        }
    }
}
