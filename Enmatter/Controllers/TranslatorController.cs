using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enmatter.Models;
using Enmatter.Services;

namespace Enmatter.Controllers
{
    class TranslatorController
    {
        private TranslatorService _translatorService;

        public TranslatorController()
        {
            _translatorService = new TranslatorService();
        }

        public TranslationResponseObject Translate(string input)
        {
            return _translatorService.Translate(input);
        }

        public void UpdateCurrentTranslator(string translatorName)
        {
            _translatorService.UpdateCurrentTranslator(translatorName);
        }

        public string SuggestTranslator(string inputText)
        {
            return _translatorService.SuggestTranslator(inputText);
        }

    }
}
