using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using System.Web;
using Encoder = Enmatter.Models.Encoder;

namespace Enmatter.Encoders
{
    class UrlEncoder : Encoder
    {
        public UrlEncoder(bool decode = false)
        {
            Name = TranslatorStaticNames.UrlEncoder;
            Decode = decode;
        }

        public override string Translate(string input)
        {
            return Decode 
                ? HttpUtility.UrlDecode(input) 
                : HttpUtility.UrlEncode(input);
        }
    }
}
