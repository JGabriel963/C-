using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Responses.Pet;

public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
