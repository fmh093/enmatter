using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using Encoder = Enmatter.Models.Encoder;

namespace Enmatter.Encoders
{
    class Base64Encoder : Encoder
    {
        public Base64Encoder(bool decode = false)
        {
            Name = TranslatorStaticNames.Base64Encoder;
            Decode = decode;
        }

        public override string Translate(string input)
        {
            if (Decode)
            {
                var data = Convert.FromBase64String(input);
                return Encoding.ASCII.GetString(data);
            }

            var inputAsBytes = Encoding.ASCII.GetBytes(input);
            return Convert.ToBase64String(inputAsBytes);
        }
    }
}
