using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TheCoustRoles.Modules.CustomHats;

public class SkinsConfigFile
{
    [JsonPropertyName("hats")] public List<CustomHat> Hats { get; set; }
}
