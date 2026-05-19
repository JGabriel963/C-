using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses.Task;

namespace Petfolio.Application.UseCases.Task.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<RequestTaskJson>
            {
                new RequestTaskJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Task 1",
                    Description = "Description 1",
                    Priority = Communication.Enum.PriorityType.High
                },
                new RequestTaskJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Task 2",
                    Description = "Description 2",
                    Priority = Communication.Enum.PriorityType.Medium
                },
                new RequestTaskJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Task 3",
                    Description = "Description 3",
                    Priority = Communication.Enum.PriorityType.Low
                }
            }
        };
    }
}
