using Apps.Supertext.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Supertext.Models.Responses
{
    public class LanguageMappingResponse
    {
        public IEnumerable<SupertextLanguageDto> Languages { get; set; }
    }
}
