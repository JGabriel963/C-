using Petfolio.Communication.Requests;

namespace Petfolio.Communication.Responses.Task;

public class ResponseAllTaskJson
{
    public List<RequestTaskJson> Tasks { get; set; } = []; 
}
