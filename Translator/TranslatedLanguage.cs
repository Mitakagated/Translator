using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Translator;
public record TranslatedLanguage
{
    [JsonPropertyName("translatedText")]
    public string? TranslatedText { get; set; }
}
