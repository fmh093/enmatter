using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter
{
    class TranslatorOptions
    {
        public enum TranslatorType
        {
            // Formatters
            Json = 0,
            Xml = 10,
            Stacktrace = 20,

            // Encoders / Decoders
            Base64 = 200,
            Url = 210,

            // Parsers
            Guid = 300,
            Byte = 310,
            Short = 320,
            Int = 330,
            Long = 340
        }
    }
}
