﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enmatter.Models
{
    abstract class Translator
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OptionName { get; set; }
    }
}
