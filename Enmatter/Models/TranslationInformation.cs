using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    class TranslationResponseObject
    {
        public Type MessageType { get; set; }
        public string Output { get; set; }

        public TranslationResponseObject()
        {
            MessageType = Type.Formatted;
        }

        public enum Type
        {
            Formatted = 0,
            Error = 10
        }
    }
}
