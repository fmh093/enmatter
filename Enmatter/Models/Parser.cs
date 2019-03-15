using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    abstract class Parser : Translator
    {
        protected Parser()
        {
            Type = TranslatorType.Parser;
        }
    }
}
