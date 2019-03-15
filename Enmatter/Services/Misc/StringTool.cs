using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Enmatter.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//using Newtonsoft.Json;

namespace Enmatter.Formatters
{
    class StringTool : Misc
    {
        public StringTool()
        {
            Name = TranslatorStaticNames.StringTool;
        }

        public override string Translate(string input)
        {
            var stringBuilder = new StringBuilder();

            var containsNumbers = "No";
            if (input.Any(char.IsDigit))
                containsNumbers = "Yes";

            stringBuilder.AppendLine($"Length:".PadRight(20) + input.Length);
            stringBuilder.AppendLine($"\nContains numbers:".PadRight(20) + containsNumbers);
            stringBuilder.AppendLine($"\nLowercased:".PadRight(20) + input.ToLowerInvariant());
            stringBuilder.AppendLine($"\nUppercased:".PadRight(20) + input.ToUpperInvariant());

            return stringBuilder.ToString();
        }
    }
}
