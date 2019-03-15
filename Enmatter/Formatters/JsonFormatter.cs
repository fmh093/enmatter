using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;

namespace Enmatter.Formatters
{
    class JsonFormatter : Translator
    {
        public JsonFormatter()
        {
            Name = "Json Formatter";
            OptionName = "Json";

        }
    }
}
