using System.Text.Json.Serialization;

namespace WebApiCSharp.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
