using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using Newtonsoft.Json;

namespace Enmatter.Formatters
{
    class JsonFormatter : Formatter
    {
        public JsonFormatter()
        {
            Name = "Json Formatter";
        }

        public override string Translate(string input)
        {
            var json = JsonConvert.SerializeObject(input, Formatting.Indented);
            return json;
        }
    }
}
