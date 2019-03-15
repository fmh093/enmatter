using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;

namespace Enmatter.Formatters
{
    class StacktraceFormatter : Formatter
    {
        public StacktraceFormatter()
        {
            Name = TranslatorStaticNames.StacktraceFormatter;
        }

        public override string Translate(string input)
        {
            var formattedStacktrace = input;

            var searchReplaceDictionary = new Dictionary<string, string>();
            searchReplaceDictionary.Add("   at", "\r\n   at");
            searchReplaceDictionary.Add(" ---> ", "\r\n ---> ");
            searchReplaceDictionary.Add(" at ", "\r\n at ");
            searchReplaceDictionary.Add(" --- End of inner exception stack trace ---", "\r\n   --- End of inner exception stack trace ---");
            searchReplaceDictionary.Add("\r\n\r\n   at", "\r\n   at");
            searchReplaceDictionary.Add("\r\n\r\n ---> ", "\r\n ---> ");
            searchReplaceDictionary.Add("\r\n\r\n at ", "\r\n at ");
            searchReplaceDictionary.Add("\r\n\r\n   --- End of inner exception stack trace ---", "\r\n   --- End of inner exception stack trace ---");

            foreach (var searchReplaceItem in searchReplaceDictionary)
            {
                formattedStacktrace = formattedStacktrace.Replace(searchReplaceItem.Key, searchReplaceItem.Value);
            }


            return formattedStacktrace;
        }
    }
}
