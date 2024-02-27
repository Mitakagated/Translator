using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Translator;
public record DetectedLanguage
{
    [JsonPropertyName("confidence")]
    public float Confidence { get; set; }
    [JsonPropertyName("language")]
    public string? LangCode { get; set; }
}
