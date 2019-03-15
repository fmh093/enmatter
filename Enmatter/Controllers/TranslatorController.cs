using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string Translate(string input)
        {
            _translatorService.Translate(input);
            return null;
        }

        public void UpdateCurrentTranslator(string translatorName)
        {
            _translatorService.UpdateCurrentTranslator(translatorName);
        }

    }
}
