using System.Collections.Generic;

namespace DomainDriven.CleanArchitecture.Application
{
    public class BaseUseCaseResponse
    {
        public BaseUseCaseResponse() => Errors = new List<string>();

        public List<string> Errors { get; set; }
    }
}
