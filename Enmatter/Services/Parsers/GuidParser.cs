using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models.Parsers
{
    class GuidParser : Parser
    {
        public GuidParser()
        {
            Name = TranslatorStaticNames.GuidParser;
        }

        public override string Translate(string input)
        {
            return Guid.TryParse(input, out _) 
                ? $"Valid.\n{input} is a valid Guid" 
                : $"Invalid!\n{input} is an invalid Guid";
        }
    }
}
