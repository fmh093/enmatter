﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    abstract class Misc : Translator
    {
        protected Misc()
        {
            Type = TranslatorType.Misc;
        }
        public abstract string Translate();
    }
}
