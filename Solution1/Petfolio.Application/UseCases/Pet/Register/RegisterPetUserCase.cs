using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses.Pet;

namespace Petfolio.Application.UseCases.Pet.Register;

public class RegisterPetUserCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 1,
            Name = request.Name
        };
    }
}
