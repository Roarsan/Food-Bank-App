using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CW1_MVC_Food_Bank_Website.Services
{
    using System.Text.Json.Serialization;

    public record class Repository(
        [property: JsonPropertyName("name")] string Name);
}
