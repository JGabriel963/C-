using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses.Task;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
        };
    }
}
