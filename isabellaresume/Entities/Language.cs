﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace isabellaresume.Entities
{
    public class Language
    {
        [JsonProperty("languagename")]
        public string LanguageName { get; set; }

        [JsonProperty("proficiency")]
        public string Proficiency { get; set; }
    }
}