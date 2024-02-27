using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Translator;
public record Language
{
    [JsonPropertyName("code")]
    public string? LangCode { get; set; }
    [JsonPropertyName("name")]
    public string? LangName { get; set; }
    [JsonPropertyName("targets")]
    public string[]? TargetLangs { get; set; }
}
