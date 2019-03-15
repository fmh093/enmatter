using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Encoders;
using Enmatter.Formatters;
using Enmatter.Models;
using Newtonsoft.Json;

namespace Enmatter.Services
{
    class TranslatorService
    {
        private Translator _currentTranslator;

        public void UpdateCurrentTranslator(string translatorName)
        {
            switch (translatorName)
            {
                case "Json Formatter":
                    _currentTranslator = new JsonFormatter();
                    break;
                case "Xml Formatter":
                    _currentTranslator = new XmlFormatter();
                    break;
                case "Stacktrace Formatter":
                    _currentTranslator = new StacktraceFormatter();
                    break;
                case "Base64 Encoder":
                    _currentTranslator = new Base64Encoder();
                    break;
                default:
                    _currentTranslator = new JsonFormatter();
                    break;
            }
        }

        public string Translate(string input)
        {
            try
            {
                return _currentTranslator.Translate(input);
            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
    }
}
