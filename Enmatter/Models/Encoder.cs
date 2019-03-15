using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    abstract class Encoder : Translator
    {
        public bool Decode;

        protected Encoder()
        {
            Type = TranslatorType.Encoder;
        }
        public abstract string Encode();
    }
}
