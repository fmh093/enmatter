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
        public Base64Encoder()
        {
            Name = "Base64 Encoder";
        }

        public override string Translate(string input)
        {
            throw new NotImplementedException();
        }
    }
}
