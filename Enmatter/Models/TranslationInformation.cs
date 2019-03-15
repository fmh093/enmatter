using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    class TranslationResponseObject
    {
        public Severity MessageType { get; set; }
        public string Output { get; set; }

        public TranslationResponseObject()
        {
            MessageType = Severity.Formatted;
        }

        public enum Severity
        {
            Formatted = 0,
            Error = 10
        }
    }
}
