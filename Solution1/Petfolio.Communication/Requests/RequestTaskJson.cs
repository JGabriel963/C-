using Petfolio.Communication.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Communication.Requests;

public class RequestTaskJson
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority {  get; set; }
    public StatusType Status { get; set; }
}
