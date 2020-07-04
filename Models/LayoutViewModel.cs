using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPresentation.Models
{
    public class LayoutViewModel
    {
        public readonly string DefaultLangCode = "RO";
        //public string LanguageCode { get; set; }
        public readonly List<string> LanguageCodes = new List<string> { "RO", "EN" };
        public LayoutViewModel()
        {
            DefaultLangCode = "RO";
            LanguageCodes = new List<string> { "RO", "EN" };
        }
    }
}
