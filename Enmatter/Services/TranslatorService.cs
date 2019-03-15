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
                case "Base64 Decoder":
                    _currentTranslator = new Base64Encoder(true);
                    break;
                default:
                    _currentTranslator = new JsonFormatter();
                    break;
            }
        }

        public TranslationResponseObject Translate(string input)
        {
            var response = new TranslationResponseObject();
            try
            {
                response.Output = _currentTranslator.Translate(input);
                response.MessageType = TranslationResponseObject.Severity.Formatted;
            }
            catch (Exception e)
            {
                response.Output = e.Message;
                response.MessageType = TranslationResponseObject.Severity.Error;
            }

            return response;
        }
    }
}
