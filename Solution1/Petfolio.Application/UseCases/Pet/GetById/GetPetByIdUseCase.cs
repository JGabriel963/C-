using Petfolio.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Lulu",
            Type = Communication.Enum.PetType.Cat,
            Birthday = new DateTime(year: 2025, month: 01, day: 01)
        };
    }
}
