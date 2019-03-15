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
    class StatusCodeLookup : Misc
    {
        public StatusCodeLookup()
        {
            Name = TranslatorStaticNames.StatusCodeLookup;
        }

        public override string Translate(string input)
        {
            return int.TryParse(input, out var statusCode) 
                ? HttpWorkerRequest.GetStatusDescription(statusCode) 
                : "You did not insert a number or the number you inserted was too high";
        }
    }
}
