using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Encoders;
using Enmatter.Formatters;
using Enmatter.Models;
using Enmatter.Models.Parsers;
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
                case TranslatorStaticNames.JsonFormatter:
                    _currentTranslator = new JsonFormatter();
                    break;
                case TranslatorStaticNames.XmlFormatter:
                    _currentTranslator = new XmlFormatter();
                    break;
                case TranslatorStaticNames.StacktraceFormatter:
                    _currentTranslator = new StacktraceFormatter();
                    break;
                case TranslatorStaticNames.Base64Encoder:
                    _currentTranslator = new Base64Encoder();
                    break;
                case TranslatorStaticNames.Base64Decoder:
                    _currentTranslator = new Base64Encoder(true);
                    break;
                case TranslatorStaticNames.UrlEncoder:
                    _currentTranslator = new UrlEncoder();
                    break;
                case TranslatorStaticNames.UrlDecoder:
                    _currentTranslator = new UrlEncoder(true);
                    break;
                case TranslatorStaticNames.MD5HashGenerator:
                    _currentTranslator = new MD5HashGenerator();
                    break;
                case TranslatorStaticNames.SHA256HashGenerator:
                    _currentTranslator = new SHA256HashGenerator();
                    break;
                case TranslatorStaticNames.GuidParser:
                    _currentTranslator = new GuidParser();
                    break;
                case TranslatorStaticNames.StatusCodeLookup:
                    _currentTranslator = new StatusCodeLookup();
                    break;
                default:
                    _currentTranslator = new StringTool();
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

        public string SuggestTranslator(string inputText)
        {
            if (inputText.Length > 0 && (inputText[0] == '{' || inputText[0] == '['))
                return TranslatorStaticNames.JsonFormatter;
            if(inputText.Length > 0 && inputText[0] == '<')
                return TranslatorStaticNames.XmlFormatter;

            if (inputText.Length > 3 && inputText.Substring(0, 4) == "http")
                return inputText.Contains('%') 
                    ? TranslatorStaticNames.UrlDecoder 
                    : TranslatorStaticNames.UrlEncoder;

            if (inputText.Length > 13 && inputText[8] == '-' && inputText[13] == '-')
                return TranslatorStaticNames.GuidParser; 

            if (inputText.Length == 3 && int.TryParse(inputText, out _))
                return TranslatorStaticNames.StatusCodeLookup;

            return TranslatorStaticNames.StringTool;

        }
    }
}
