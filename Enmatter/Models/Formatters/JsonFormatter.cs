using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//using Newtonsoft.Json;

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
            var json = JToken.Parse(input).ToString(Formatting.Indented);
            return json;
        }
    }
}
