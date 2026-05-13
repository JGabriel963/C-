using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;

public class RegisterPetUserCase
{
    public ResponseRegisteredPetJson Execute(RequestRegisterPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 1,
            Name = request.Name
        };
    }
}
